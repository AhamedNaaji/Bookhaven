using Bookhaven.AppClasses;
using Bookhaven.CommonClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bookhaven
{
    public partial class Sales : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3UAK82;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");
        filloperation fill = new filloperation(); // Declare and initialize the 'fill' object

        private List<cls_sales.SalesDetail> cartItems = new List<cls_sales.SalesDetail>();
        public Sales()
        {
            InitializeComponent();
        }
       
        private void Sales_Load(object sender, EventArgs e)
        {
            // Populate combo boxes
            fill.combobox("SELECT Customer_Id, Customer_Name FROM Customer", comboCustomer, "Customer_Name", "Customer_Id");
            fill.combobox("SELECT Book_Id, Book_Name FROM Book", comboBook, "Book_Name", "Book_Id");
            fill.combobox("SELECT Staff_Id, Staff_Name FROM Staff", comboStaff, "Staff_Name", "Staff_Id");

            // Load sales data
            LoadSalesData();

            // Configure dgv_addtocart
            dgv_addtocart.Columns.Add("BookName", "Book Name");
            dgv_addtocart.Columns.Add("Quantity", "Quantity");
            dgv_addtocart.Columns.Add("Price", "Price");
            dgv_addtocart.Columns.Add("Discount", "Discount (%)");
            dgv_addtocart.Columns.Add("TotalAmount", "Total Amount");
            dgv_addtocart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Initialize total payment display
            label_TotalAmount.Text = "Total Amount: $0.00";
        }

        private void LoadSalesData()
        {
            string query = @"
        SELECT 
            s.Sales_Id,
            c.Customer_Name,
            st.Staff_Name,
            s.Date,
            b.Book_Name,
            sd.Quantity,
            sd.Price,
            sd.Discount,
            sd.Total_Amount
        FROM Sales s
        INNER JOIN Customer c ON s.Customer_Id_fk = c.Customer_Id
        INNER JOIN Staff st ON s.Staff_Id_fk = st.Staff_Id
        INNER JOIN SalesDetails sd ON s.Sales_Id = sd.Sales_Id_fk
        INNER JOIN Book b ON sd.Book_Id_fk = b.Book_Id";

            fill.FillDataGridView(query, dgv_sales);

            // Rename columns for clarity
            dgv_sales.Columns[0].HeaderText = "Sale ID";
            dgv_sales.Columns[1].HeaderText = "Customer Name";
            dgv_sales.Columns[2].HeaderText = "Staff Name";
            dgv_sales.Columns[3].HeaderText = "Date";
            dgv_sales.Columns[4].HeaderText = "Book Name";
            dgv_sales.Columns[5].HeaderText = "Quantity";
            dgv_sales.Columns[6].HeaderText = "Price";
            dgv_sales.Columns[7].HeaderText = "Discount (%)";
            dgv_sales.Columns[8].HeaderText = "Total Amount";

            dgv_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //private void UpdateFinalPaymentDisplay()
        //{
        //    float totalAmount = CalculateTotalAmount();
        //    float discount = GetBookDiscount();
        //    float finalPayment = totalAmount - (totalAmount * (discount / 100));

        //    label_TotalAmount.Text = "{totalAmount}";
        //    labelFinalPayment.Text = "{finalPayment}";
        //}

        public bool CheckBookStock(int bookId)
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

                            if (stockQuantity < 1)
                            {
                                MessageBox.Show("The book is out of stock.");
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
            int bookId = Convert.ToInt32(comboBook.SelectedValue);

            if (CheckBookStock(bookId))
            {
                cls_sales sale = new cls_sales
                {
                    Staff_Id_fk = Convert.ToInt32(comboStaff.SelectedValue),
                    Customer_Id_fk = Convert.ToInt32(comboCustomer.SelectedValue),
                    Date = DateTime.Now,
                    Total_Payment = CalculateFinalPayment(),
                    SalesDetailsList = GetSalesDetails()
                };

                sale.Insertdata();
                LoadSalesData();
            }
        }
        private void btn_updateSales_Click(object sender, EventArgs e)
        {
            // Debugging: Log the selection state
            Console.WriteLine($"Selected Rows Count: {dgv_sales.SelectedRows.Count}");
            Console.WriteLine($"Current Row Index: {dgv_sales.CurrentRow?.Index}");

            if (dgv_sales.SelectedRows.Count == 0 && dgv_sales.CurrentRow == null)
            {
                MessageBox.Show("Please select a sale to update.", "No Selection");
                return;
            }

            // Proceed with updating the selected sale
            int salesId;
            if (dgv_sales.SelectedRows.Count > 0)
            {
                salesId = Convert.ToInt32(dgv_sales.SelectedRows[0].Cells["Sales_Id"].Value);
            }
            else
            {
                salesId = Convert.ToInt32(dgv_sales.CurrentRow.Cells["Sales_Id"].Value);
            }

            cls_sales sale = new cls_sales
            {
                Sales_Id = salesId,
                Staff_Id_fk = Convert.ToInt32(comboStaff.SelectedValue),
                Customer_Id_fk = Convert.ToInt32(comboCustomer.SelectedValue),
                Date = DateTime.Now,
                Total_Payment = CalculateFinalPayment(),
                SalesDetailsList = GetSalesDetails()
            };

            sale.UpdateData();
            LoadSalesData();
        }
        private void btn_deleteSales_Click(object sender, EventArgs e)
        {
            if (dgv_sales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a sale to delete.", "No Selection");
                return;
            }

            int salesId = Convert.ToInt32(dgv_sales.SelectedRows[0].Cells["Sales_Id"].Value);

            cls_sales sale = new cls_sales
            {
                Sales_Id = salesId
            };

            sale.DeleteData();
            LoadSalesData();
        }

        private List<cls_sales.SalesDetail> GetSalesDetails()
        {
            var details = new List<cls_sales.SalesDetail>
            {
                new cls_sales.SalesDetail
                {
                    Book_Id_fk = Convert.ToInt32(comboBook.SelectedValue),
                    Price = GetBookPrice(),
                    Quantity = (int)numericQuantity.Value,
                    Discount = GetBookDiscount(),
                    Total_Amount = CalculateTotalAmount()
                }
            };
            return details;
        }

        private float GetBookPrice()
        {
            return ExecuteScalarQuery<float>("SELECT Price FROM Book WHERE Book_Id = @Book_Id",
                new SqlParameter[] { new SqlParameter("@Book_Id", comboBook.SelectedValue) });
        }

        private float GetBookDiscount()
        {
            return ExecuteScalarQuery<float>("SELECT Discount FROM Book WHERE Book_Id = @Book_Id",
                new SqlParameter[] { new SqlParameter("@Book_Id", comboBook.SelectedValue) });
        }

        private float CalculateTotalAmount()
        {
            float price = GetBookPrice();
            int quantity = (int)numericQuantity.Value;
            return price * quantity;
        }

        private float CalculateFinalPayment()
        {
            float totalAmount = CalculateTotalAmount();
            float discount = GetBookDiscount();
            return totalAmount - (totalAmount * (discount / 100));
        }

        private T ExecuteScalarQuery<T>(string query, SqlParameter[] parameters)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                object result = cmd.ExecuteScalar();
                return result != null ? (T)Convert.ChangeType(result, typeof(T)) : default(T);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}");
                return default(T);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        private void comboBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFinalPaymentDisplay();
        }

        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {
            UpdateFinalPaymentDisplay();
        }

        private void dgv_sales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Select the clicked row
                    dgv_sales.ClearSelection();
                    dgv_sales.Rows[e.RowIndex].Selected = true;

                    // Get selected sale ID
                    int salesId = Convert.ToInt32(dgv_sales.Rows[e.RowIndex].Cells["Sales_Id"].Value);

                    // Load sale data
                    cls_sales sale = new cls_sales
                    {
                        Sales_Id = salesId
                    };
                    sale.Getdata();

                    // Populate form fields
                    comboCustomer.SelectedValue = sale.Customer_Id_fk;
                    comboStaff.SelectedValue = sale.Staff_Id_fk;

                    // Populate the first book in the sale (if available)
                    if (sale.SalesDetailsList.Count > 0)
                    {
                        var firstBook = sale.SalesDetailsList[0];
                        comboBook.SelectedValue = firstBook.Book_Id_fk;
                        numericQuantity.Value = firstBook.Quantity;

                        // Update labels with total amount, discount, and final payment
                        float totalAmount = firstBook.Price * firstBook.Quantity;
                        float discount = firstBook.Discount;
                        float finalPayment = totalAmount - (totalAmount * (discount / 100));

                        label_TotalAmount.Text = $" {totalAmount:C}";
                        labelDiscount.Text = $" {discount}%";
                        labelFinalPayment.Text = $"{finalPayment:C}";
                    }
                    else
                    {
                        // Clear fields if no books are found in the sale
                        comboBook.SelectedIndex = -1;
                        numericQuantity.Value = 1;
                        label_TotalAmount.Text = " $0.00";
                        labelDiscount.Text = " 0%";
                        labelFinalPayment.Text = "F $0.00";
                    }

                    // Optional: Highlight the selected row
                    dgv_sales.ClearSelection();
                    dgv_sales.Rows[e.RowIndex].Selected = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Fetch Failed");
                }
            }
        }
        private float GetTotalPaymentForSale(int salesId)
        {
            string query = @"
        SELECT SUM(Total_Amount)
        FROM SalesDetails
        WHERE Sales_Id_fk = @Sales_Id";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Sales_Id", salesId);
                conn.Open();
                float totalAmount = Convert.ToSingle(command.ExecuteScalar());
                conn.Close();
                return totalAmount;
            }
        }

        private void comboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void comboBook_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Ensure a valid book is selected
            if (comboBook.SelectedValue == null || comboBook.SelectedValue.ToString() == "")
            {
                label_TotalAmount.Text = " $0.00";
                labelDiscount.Text = "Discount: 0%";
                labelFinalPayment.Text = " $0.00";
                return;
            }

            try
            {
                // Fetch the price and discount for the selected book
                float price = GetBookPrice();
                float discount = GetBookDiscount();

                // Calculate total amount based on the current quantity
                int quantity = (int)numericQuantity.Value;
                float totalAmount = price * quantity;

                // Calculate final payment after applying the discount
                float finalPayment = totalAmount - (totalAmount * (discount / 100));

                // Update the labels dynamically
                label_TotalAmount.Text = $"{totalAmount:C}";
                labelDiscount.Text = $"{discount}%";
                labelFinalPayment.Text = $"{finalPayment:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }

        private void numericQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            // Ensure a valid book is selected
            if (comboBook.SelectedValue == null || comboBook.SelectedValue.ToString() == "")
            {
                label_TotalAmount.Text = "0.00";
                labelDiscount.Text = "0%";
                labelFinalPayment.Text = "0.00";
                return;
            }

            try
            {
                // Fetch the price and discount for the selected book
                float price = GetBookPrice();
                float discount = GetBookDiscount();

                // Calculate total amount based on the current quantity
                int quantity = (int)numericQuantity.Value;
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

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            btn_Sales.BackColor = Color.MediumAquamarine;
        }

        private void btn_addbook_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (comboBook.SelectedIndex == -1 || numericQuantity.Value <= 0)
                {
                    MessageBox.Show("Please select a book and enter a valid quantity.", "Validation Error");
                    return;
                }

                // Get selected book details
                int bookId = Convert.ToInt32(comboBook.SelectedValue);
                string bookName = comboBook.Text;
                float price = GetBookPrice(bookId);
                float discount = GetBookDiscount(bookId);
                int quantity = Convert.ToInt32(numericQuantity.Value);

                // Check stock availability
                if (!CheckBookStock(bookId, quantity))
                {
                    MessageBox.Show("Insufficient stock for the selected book.", "Stock Error");
                    return;
                }

                // Calculate total amount
                float totalAmount = quantity * price * (1 - discount / 100);

                // Add item to cart
                var newItem = new cls_sales.SalesDetail
                {
                    Book_Id_fk = bookId,
                    Quantity = quantity,
                    Price = price,
                    Discount = discount,
                    Total_Amount = totalAmount
                };

                cartItems.Add(newItem);

                // Add to dgv_addtocart
                int rowIndex = dgv_addtocart.Rows.Add(bookName, quantity, price, discount, totalAmount);
                dgv_addtocart.Rows[rowIndex].Cells["BookName"].Tag = bookId; // Store Book_Id for reference

                // Clear selection and reset quantity
                comboBook.SelectedIndex = -1;
                numericQuantity.Value = 1;

                // Update total payment display
                UpdateFinalPaymentDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Add to Cart Failed");
            }
        }

        private void btn_removebook_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_addtocart.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a book to remove from the cart.", "Selection Error");
                    return;
                }

                // Get selected row
                int rowIndex = dgv_addtocart.SelectedRows[0].Index;
                int bookId = Convert.ToInt32(dgv_addtocart.Rows[rowIndex].Cells["BookName"].Tag);

                // Remove item from cart
                var itemToRemove = cartItems.FirstOrDefault(item => item.Book_Id_fk == bookId);
                if (itemToRemove != null)
                {
                    cartItems.Remove(itemToRemove);
                }

                // Remove from dgv_addtocart
                dgv_addtocart.Rows.RemoveAt(rowIndex);

                // Update total payment display
                UpdateFinalPaymentDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Remove from Cart Failed");
            }
        }

        private void btn_saveSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (cartItems.Count == 0)
                {
                    MessageBox.Show("No items in the cart to save.", "Cart Empty");
                    return;
                }

                // Create a new sale
                cls_sales sale = new cls_sales
                {
                    Staff_Id_fk = Convert.ToInt32(comboStaff.SelectedValue),
                    Customer_Id_fk = Convert.ToInt32(comboCustomer.SelectedValue),
                    Date = DateTime.Now,
                    Total_Payment = cartItems.Sum(item => item.Total_Amount),
                    SalesDetailsList = cartItems
                };

                // Insert data into the database
                sale.Insertdata();

                // Clear cart and refresh UI
                cartItems.Clear();
                dgv_addtocart.Rows.Clear();
                LoadSalesData();
                UpdateFinalPaymentDisplay();

                MessageBox.Show("Sale saved successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Save Sale Failed");
            }
        }
        private void UpdateFinalPaymentDisplay()
        {
            try
            {
                // Ensure a valid book is selected
                if (comboBook.SelectedValue == null || comboBook.SelectedValue.ToString() == "")
                {
                    label_TotalAmount.Text = " $0.00";
                    labelDiscount.Text = " 0%";
                    labelFinalPayment.Text = " $0.00";
                    return;
                }

                // Fetch price and discount for the selected book
                int bookId = Convert.ToInt32(comboBook.SelectedValue);
                float price = GetBookPrice(bookId);
                float discount = GetBookDiscount(bookId);

                // Calculate total amount based on the current quantity
                int quantity = (int)numericQuantity.Value;
                float totalAmount = price * quantity;

                // Calculate final payment after applying the discount
                float finalPayment = totalAmount - (totalAmount * (discount / 100));

                // Update the labels dynamically with proper formatting
                label_TotalAmount.Text = $" {totalAmount:C}";
                labelDiscount.Text = $" {discount}%";
                labelFinalPayment.Text = $" {finalPayment:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }

        private float GetBookPrice(int bookId)
        {
            string query = "SELECT Price FROM Book WHERE Book_Id = @BookId";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@BookId", bookId);
                conn.Open();
                float price = Convert.ToSingle(command.ExecuteScalar());
                conn.Close();
                return price;
            }
        }

        private float GetBookDiscount(int bookId)
        {
            string query = "SELECT Discount FROM Book WHERE Book_Id = @BookId";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@BookId", bookId);
                conn.Open();
                float discount = Convert.ToSingle(command.ExecuteScalar());
                conn.Close();
                return discount;
            }
        }

        private bool CheckBookStock(int bookId, int quantity)
        {
            string query = "SELECT Stock_Quantity FROM Stock WHERE Book_Id_fk = @BookId";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@BookId", bookId);
                conn.Open();
                int stockQuantity = Convert.ToInt32(command.ExecuteScalar());
                conn.Close();
                return stockQuantity >= quantity;
            }
        }

        private void dgv_sales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}