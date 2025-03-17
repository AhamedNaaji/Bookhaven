using Bookhaven.AppClasses;
using Bookhaven.CommonClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookhaven
{
    public partial class Clerk_Sales : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=AFRIDI;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");
        filloperation fill = new filloperation(); // Declare and initialize the 'fill' object
        private int currentStaffId;
        private List<SalesDetail> cartItems = new List<SalesDetail>();

        public Clerk_Sales(int staffId)
        {
            InitializeComponent();
            currentStaffId = staffId;
            InitializeCartDataGridView();
        }

        private void InitializeCartDataGridView()
        {
            // Initialize the DataGridView for the cart
            dgv_cart.AutoGenerateColumns = false;
            dgv_cart.Columns.Add(new DataGridViewTextBoxColumn { Name = "Book_Id", HeaderText = "Book ID", DataPropertyName = "Book_Id_fk" });
            dgv_cart.Columns.Add(new DataGridViewTextBoxColumn { Name = "Book_Name", HeaderText = "Book Name", DataPropertyName = "Book_Name" });
            dgv_cart.Columns.Add(new DataGridViewTextBoxColumn { Name = "Price", HeaderText = "Price", DataPropertyName = "Price" });
            dgv_cart.Columns.Add(new DataGridViewTextBoxColumn { Name = "Quantity", HeaderText = "Quantity", DataPropertyName = "Quantity" });
            dgv_cart.Columns.Add(new DataGridViewTextBoxColumn { Name = "Discount", HeaderText = "Discount", DataPropertyName = "Discount" });
            dgv_cart.Columns.Add(new DataGridViewTextBoxColumn { Name = "Total_Amount", HeaderText = "Total Amount", DataPropertyName = "Total_Amount" });
        }

        private void Clerk_Sales_Load(object sender, EventArgs e)
        {
            // Populate combo boxes
            fill.combobox("SELECT Customer_Id, Customer_Name FROM Customer", comboCustomer, "Customer_Name", "Customer_Id");
            fill.combobox("SELECT Book_Id, Book_Name FROM Book", comboBook, "Book_Name", "Book_Id");
            // Load sales data
            LoadSalesData();
        }

        private void LoadSalesData()
        {
            string query = @"
                SELECT s.Sales_Id, c.Customer_Name, st.Staff_Name, s.Date, s.Total_Payment
                FROM Sales s
                INNER JOIN Customer c ON s.Customer_Id_fk = c.Customer_Id
                INNER JOIN Staff st ON s.Staff_Id_fk = st.Staff_Id
                WHERE s.Staff_Id_fk = @Staff_Id
                ORDER BY s.Date DESC";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Staff_Id", currentStaffId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_sales.DataSource = dt;
                // Rename columns
                dgv_sales.Columns[0].HeaderText = "Sales ID";
                dgv_sales.Columns[1].HeaderText = "Customer Name";
                dgv_sales.Columns[2].HeaderText = "Staff Name";
                dgv_sales.Columns[3].HeaderText = "Date";
                dgv_sales.Columns[4].HeaderText = "Total Payment";
            }
        }

        private void UpdateFinalPaymentDisplay()
        {
            float totalAmount = cartItems.Sum(item => item.Total_Amount);
            float discount = cartItems.Sum(item => item.Total_Amount * (item.Discount / 100));
            float finalPayment = totalAmount - discount;
            label_TotalAmount.Text = $"{totalAmount:F2}"; // Format to two decimal places
            labelFinalPayment.Text = $"{finalPayment:F2}"; // Format to two decimal places
        }

        public bool CheckBookStock(int bookId, int quantity)
        {
            string query = "SELECT Stock_Quantity FROM Stock WHERE Book_Id_fk = @BookId";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@BookId", bookId);
                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int stockQuantity = reader.GetInt32(0);
                            if (stockQuantity < quantity)
                            {
                                MessageBox.Show("Insufficient stock for the selected book.");
                                return false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("The book is out of stock.");
                        return false;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false;
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                        conn.Close();
                }
            }
            return true;
        }

        private void btn_addSales_Click(object sender, EventArgs e)
        {
            if (comboCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer.", "Validation Error");
                return;
            }

            if (cartItems.Count == 0)
            {
                MessageBox.Show("Please add books to the cart before making a sale.", "Validation Error");
                return;
            }

            float totalPayment;
            if (!float.TryParse(label_TotalAmount.Text.Replace("$", "").Trim(), out totalPayment))
            {
                MessageBox.Show("Invalid total payment value.", "Validation Error");
                return;
            }

            float finalPayment;
            if (!float.TryParse(labelFinalPayment.Text.Replace("$", "").Trim(), out finalPayment))
            {
                MessageBox.Show("Invalid final payment value.", "Validation Error");
                return;
            }

            sales_cls sale = new sales_cls
            {
                Staff_Id_fk = currentStaffId, // Use the logged-in staff ID
                Customer_Id_fk = Convert.ToInt32(comboCustomer.SelectedValue),
                Date = dateTimePickerDate.Value,
                Total_Payment = finalPayment,
                SalesDetailsList = cartItems
            };

            sale.Insertdata();
            LoadSalesData();
            cartItems.Clear(); // Clear the cart after inserting the sale
            dgv_cart.DataSource = null; // Clear the DataGridView
            UpdateFinalPaymentDisplay(); // Reset the payment labels
        }

        private void btn_updateSales_Click(object sender, EventArgs e)
        {
            if (dgv_sales.SelectedRows.Count == 0 && dgv_sales.CurrentRow == null)
            {
                MessageBox.Show("Please select a sale to update.", "No Selection");
                return;
            }

            if (comboCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer.", "Validation Error");
                return;
            }

            if (cartItems.Count == 0)
            {
                MessageBox.Show("Please add books to the cart before updating the sale.", "Validation Error");
                return;
            }

            int salesId;
            if (dgv_sales.SelectedRows.Count > 0)
            {
                salesId = Convert.ToInt32(dgv_sales.SelectedRows[0].Cells["Sales_Id"].Value);
            }
            else
            {
                salesId = Convert.ToInt32(dgv_sales.CurrentRow.Cells["Sales_Id"].Value);
            }

            float totalPayment;
            if (!float.TryParse(label_TotalAmount.Text.Replace("$", "").Trim(), out totalPayment))
            {
                MessageBox.Show("Invalid total payment value.", "Validation Error");
                return;
            }

            float finalPayment;
            if (!float.TryParse(labelFinalPayment.Text.Replace("$", "").Trim(), out finalPayment))
            {
                MessageBox.Show("Invalid final payment value.", "Validation Error");
                return;
            }

            sales_cls sale = new sales_cls
            {
                Sales_Id = salesId,
                Staff_Id_fk = currentStaffId, // Use the logged-in staff ID
                Customer_Id_fk = Convert.ToInt32(comboCustomer.SelectedValue),
                Date = dateTimePickerDate.Value,
                Total_Payment = finalPayment,
                SalesDetailsList = cartItems
            };

            sale.UpdateData();
            LoadSalesData();
            cartItems.Clear(); // Clear the cart after updating the sale
            dgv_cart.DataSource = null; // Clear the DataGridView
            UpdateFinalPaymentDisplay(); // Reset the payment labels
        }

        private void btn_deleteSales_Click(object sender, EventArgs e)
        {
            if (dgv_sales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a sale to delete.", "No Selection");
                return;
            }

            int salesId = Convert.ToInt32(dgv_sales.SelectedRows[0].Cells["Sales_Id"].Value);
            sales_cls sale = new sales_cls
            {
                Sales_Id = salesId
            };

            sale.DeleteData();
            LoadSalesData();
        }

        private float GetBookPrice()
        {
            try
            {
                int bookId = Convert.ToInt32(comboBook.SelectedValue);
                string query = "SELECT Price FROM Book WHERE Book_Id = @Book_Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Book_Id", bookId);
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();
                return result != null ? Convert.ToSingle(result) : 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching book price: {ex.Message}");
            }
        }

        private float GetBookDiscount()
        {
            try
            {
                int bookId = Convert.ToInt32(comboBook.SelectedValue);
                string query = "SELECT Discount FROM Book WHERE Book_Id = @Book_Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Book_Id", bookId);
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();
                return result != null ? Convert.ToSingle(result) : 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching book discount: {ex.Message}");
            }
        }

        private void nup_Quantity_ValueChanged(object sender, EventArgs e)
        {
            // Ensure a valid book is selected
            if (comboBook.SelectedValue == null || comboBook.SelectedValue.ToString() == "")
            {
                label_TotalAmount.Text = "Total Amount: 0.00";
                labelDiscount.Text = "Discount: 0%";
                labelFinalPayment.Text = "Final Payment: 0.00";
                return;
            }
            try
            {
                // Fetch the price and discount for the selected book
                float price = GetBookPrice();
                float discount = GetBookDiscount();
                // Calculate total amount based on the current quantity
                int quantity = (int)numericQuantity.Value; // Get the current quantity from NumericUpDown
                float totalAmount = price * quantity;
                // Calculate final payment after applying the discount
                float finalPayment = totalAmount - (totalAmount * (discount / 100));
                // Update the labels dynamically
                label_TotalAmount.Text = $"{totalAmount}";
                labelDiscount.Text = $"{discount}%";
                labelFinalPayment.Text = $"{finalPayment}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }

        private void btn_add_books_Click(object sender, EventArgs e)
        {
            if (comboBook.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a book.", "Validation Error");
                return;
            }

            int bookId = Convert.ToInt32(comboBook.SelectedValue);
            int quantity = (int)numericQuantity.Value;
            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.", "Validation Error");
                return;
            }

            if (!CheckBookStock(bookId, quantity))
            {
                return;
            }

            float price = GetBookPrice();
            float discount = GetBookDiscount();
            float totalAmount = price * quantity;
            float finalAmount = totalAmount - (totalAmount * (discount / 100));

            // Check if the book is already in the cart
            var existingItem = cartItems.FirstOrDefault(item => item.Book_Id_fk == bookId);
            if (existingItem != null)
            {
                // Update the existing item
                existingItem.Quantity = quantity; // Set to new quantity
                existingItem.Total_Amount = existingItem.Price * existingItem.Quantity;
                existingItem.Total_Amount -= existingItem.Total_Amount * (existingItem.Discount / 100);
            }
            else
            {
                // Add a new item to the cart
                cartItems.Add(new SalesDetail
                {
                    Book_Id_fk = bookId,
                    Book_Name = comboBook.Text,
                    Price = price,
                    Quantity = quantity,
                    Discount = discount,
                    Total_Amount = finalAmount
                });
            }

            // Bind the cart items to the DataGridView
            dgv_cart.DataSource = null;
            dgv_cart.DataSource = cartItems.ToList();
            UpdateFinalPaymentDisplay();
        }

        private void btn_remove_books_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected in the DataGridView
            if (dgv_cart.SelectedRows.Count == 0 && dgv_cart.CurrentRow == null)
            {
                MessageBox.Show("Please select a book to remove from the cart.", "No Selection");
                return;
            }

            try
            {
                int bookId;
                if (dgv_cart.SelectedRows.Count > 0)
                {
                    // Use SelectedRows if available
                    bookId = Convert.ToInt32(dgv_cart.SelectedRows[0].Cells["Book_Id"].Value);
                }
                else
                {
                    // Fallback to CurrentRow
                    bookId = Convert.ToInt32(dgv_cart.CurrentRow.Cells["Book_Id"].Value);
                }

                // Remove the item from the cartItems list
                var itemToRemove = cartItems.FirstOrDefault(item => item.Book_Id_fk == bookId);
                if (itemToRemove != null)
                {
                    cartItems.Remove(itemToRemove);
                }

                // Refresh the DataGridView and update the final payment display
                dgv_cart.DataSource = null;
                dgv_cart.DataSource = cartItems.ToList();
                UpdateFinalPaymentDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }

        private void dgv_sales_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Get selected order ID
                    int salesId = Convert.ToInt32(dgv_sales.Rows[e.RowIndex].Cells["Sales_Id"].Value);
                    // Load order data
                    sales_cls sale = new sales_cls
                    {
                        Sales_Id = salesId
                    };
                    sale.Getdata();
                    // Populate form fields
                    comboCustomer.SelectedValue = sale.Customer_Id_fk;
                    dateTimePickerDate.Value = sale.Date;
                    // Clear the cart
                    cartItems.Clear();
                    // Add the sale details to the cart
                    foreach (var detail in sale.SalesDetailsList)
                    {
                        cartItems.Add(new SalesDetail
                        {
                            Book_Id_fk = detail.Book_Id_fk,
                            Book_Name = GetBookName(detail.Book_Id_fk),
                            Price = detail.Price,
                            Quantity = detail.Quantity,
                            Discount = detail.Discount,
                            Total_Amount = detail.Total_Amount
                        });
                    }
                    // Bind the cart items to the DataGridView
                    dgv_cart.DataSource = null;
                    dgv_cart.DataSource = cartItems.ToList();
                    UpdateFinalPaymentDisplay();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Fetch Failed");
                }
            }
        }

        private void dgv_cart_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected book ID
                int bookId = Convert.ToInt32(dgv_cart.Rows[e.RowIndex].Cells["Book_Id"].Value);
                // Get the selected book from the cart
                var selectedItem = cartItems.FirstOrDefault(item => item.Book_Id_fk == bookId);
                if (selectedItem != null)
                {
                    // Set the selected item's quantity to the numericUpDown control
                    numericQuantity.Value = selectedItem.Quantity;
                    // Set the selected book to the comboBook control
                    comboBook.SelectedValue = selectedItem.Book_Id_fk;
                }
            }
        }

        private string GetBookName(int bookId)
        {
            string query = "SELECT Book_Name FROM Book WHERE Book_Id = @Book_Id";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Book_Id", bookId);
                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();
                    object result = command.ExecuteScalar();
                    conn.Close();
                    return result != null ? result.ToString() : "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}");
                    return "";
                }
            }
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Customer_Clerk customer = new Customer_Clerk(currentStaffId);
            customer.ShowDialog();
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            Clerk_Sales sales = new Clerk_Sales(currentStaffId);
            sales.ShowDialog();
        }

        private void btn_Cusorder_Click(object sender, EventArgs e)
        {
            Clerk_CustomerOrder clerk_CustomerOrder = new Clerk_CustomerOrder(currentStaffId);
            clerk_CustomerOrder.ShowDialog();
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            Clerk_Book book = new Clerk_Book(currentStaffId);
            book.ShowDialog();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            // Display a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // Clear session data or reset user-specific information
                // Program.CurrentUser = null;

                // Close the current Dashboard form
                this.Close();

                // Show the LoginForm
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
        }

        private void btn_dashboard_Click_1(object sender, EventArgs e)
        {
            Dashboard_Clerk dasclerk = new Dashboard_Clerk(currentStaffId);
            dasclerk.ShowDialog();
        }

        private void btn_update_books_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected in the DataGridView
            if (dgv_cart.SelectedRows.Count == 0 && dgv_cart.CurrentRow == null)
            {
                MessageBox.Show("Please select a book to update.", "No Selection");
                return;
            }

            try
            {
                int bookId;
                if (dgv_cart.SelectedRows.Count > 0)
                {
                    // Use SelectedRows if available
                    bookId = Convert.ToInt32(dgv_cart.SelectedRows[0].Cells["Book_Id"].Value);
                }
                else
                {
                    // Fallback to CurrentRow
                    bookId = Convert.ToInt32(dgv_cart.CurrentRow.Cells["Book_Id"].Value);
                }

                // Find the corresponding item in the cartItems list
                var selectedItem = cartItems.FirstOrDefault(item => item.Book_Id_fk == bookId);
                if (selectedItem != null)
                {
                    // Update the quantity from the numericUpDown control
                    int newQuantity = (int)numericQuantity.Value;
                    if (newQuantity <= 0)
                    {
                        MessageBox.Show("Quantity must be greater than zero.", "Validation Error");
                        return;
                    }

                    // Check stock availability
                    if (!CheckBookStock(selectedItem.Book_Id_fk, newQuantity))
                    {
                        return;
                    }

                    // Update the item's quantity and recalculate total amount
                    selectedItem.Quantity = newQuantity;
                    selectedItem.Total_Amount = selectedItem.Price * newQuantity;
                    selectedItem.Total_Amount -= selectedItem.Total_Amount * (selectedItem.Discount / 100);

                    // Refresh the DataGridView and update the final payment display
                    dgv_cart.DataSource = null;
                    dgv_cart.DataSource = cartItems.ToList();
                    UpdateFinalPaymentDisplay();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }
    }
}