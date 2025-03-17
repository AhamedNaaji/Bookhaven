using Bookhaven.AppClasses;
using Bookhaven.CommonClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Bookhaven
{
    public partial class Sales : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=MMSALMANFARIS;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");
        filloperation fill = new filloperation(); // Declare and initialize the 'fill' object

        private int _staffId;


        public Sales(int staffId)
        {
            InitializeComponent();
            _staffId = staffId;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            // Validate input
            if (comboBook.SelectedValue == null || numericQuantity.Value <= 0)
            {
                MessageBox.Show("Please select a valid book and quantity.", "Invalid Input");
                return;
            }

            // Get book details
            int bookId = Convert.ToInt32(comboBook.SelectedValue);
            string bookName = comboBook.Text;
            float price = GetBookPrice();
            int quantity = (int)numericQuantity.Value;
            float discount = GetBookDiscount();
            float totalAmount = price * quantity;

            // Check if the book is already added
            foreach (DataGridViewRow row in dgv_books.Rows)
            {
                if (Convert.ToInt32(row.Cells["Book_Id"].Value) == bookId)
                {
                    MessageBox.Show("This book is already added. Update its quantity instead.", "Duplicate Book");
                    return;
                }
            }

            // Add the book to the DataGridView
            dgv_books.Rows.Add(bookId, bookName, price, quantity, discount, totalAmount);

            // Clear the input fields
            comboBook.SelectedIndex = -1;
            numericQuantity.Value = 1;

            // Update the total payment
            UpdateTotalPayment();
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgv_books.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to remove.", "No Selection");
                return;
            }

            // Remove the selected row
            dgv_books.Rows.RemoveAt(dgv_books.SelectedRows[0].Index);

            // Update the total payment
            UpdateTotalPayment();
        }

        private void UpdateTotalPayment()
        {
            float totalPayment = 0;

            foreach (DataGridViewRow row in dgv_books.Rows)
            {
                if (row.Cells["Total_Amount"].Value != null)
                {
                    totalPayment += Convert.ToSingle(row.Cells["Total_Amount"].Value);
                }
            }

            labelFinalPayment.Text = $"Final Payment: {totalPayment:C}";
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            // Populate combo boxes
            fill.combobox("SELECT Customer_Id, Customer_Name FROM Customer", comboCustomer, "Customer_Name", "Customer_Id");
            fill.combobox("SELECT Book_Id, Book_Name FROM Book", comboBook, "Book_Name", "Book_Id");

            // Initialize DataGridView columns
            dgv_books.Columns.Add("Book_Id", "Book ID");
            dgv_books.Columns.Add("Book_Name", "Book Name");
            dgv_books.Columns.Add("Price", "Price");
            dgv_books.Columns.Add("Quantity", "Quantity");
            dgv_books.Columns.Add("Discount", "Discount (%)");
            dgv_books.Columns.Add("Total_Amount", "Total Amount");

            dgv_books.Columns["Book_Id"].Visible = false; // Hide the Book ID column

            // Load sales data
            LoadSalesData();
        }

        private void LoadSalesData()
        {
            string query = @"
                SELECT s.Sales_Id, c.Customer_Name, st.Staff_Name, s.Date, s.Total_Payment
                FROM Sales s
                INNER JOIN Customer c ON s.Customer_Id_fk = c.Customer_Id
                INNER JOIN Staff st ON s.Staff_Id_fk = st.Staff_Id";

            fill.FillDataGridView(query, dgv_sales);
        }

        private void UpdateFinalPaymentDisplay()
        {
            float totalAmount = CalculateTotalAmount();
            float discount = GetBookDiscount();
            float finalPayment = totalAmount - (totalAmount * (discount / 100));

            label_TotalAmount.Text = "{totalAmount}";
            labelFinalPayment.Text = "{finalPayment}";
        }

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
            if (dgv_books.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one book to the sale.", "No Books Added");
                return;
            }

            cls_Sales sale = new cls_Sales
            {
                Staff_Id_fk = _staffId,
                Customer_Id_fk = Convert.ToInt32(comboCustomer.SelectedValue),
                Date = DateTime.Now,
                Total_Payment = Convert.ToSingle(labelFinalPayment.Text.Replace("Final Payment: ", "").Replace("$", "")),
                SalesDetailsList = GetSalesDetails()
            };

            sale.Insertdata();
            LoadSalesData();

            // Clear the DataGridView after saving
            dgv_books.Rows.Clear();
            UpdateTotalPayment();
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

            cls_Sales sale = new cls_Sales
            {
                Sales_Id = salesId,
                Staff_Id_fk = _staffId,
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

            cls_Sales sale = new cls_Sales
            {
                Sales_Id = salesId
            };

            sale.DeleteData();
            LoadSalesData();
        }

        private List<SalesDetail> GetSalesDetails()
        {
            var details = new List<SalesDetail>();

            foreach (DataGridViewRow row in dgv_books.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row placeholder

                details.Add(new SalesDetail
                {
                    Book_Id_fk = Convert.ToInt32(row.Cells["Book_Id"].Value),
                    Price = Convert.ToSingle(row.Cells["Price"].Value),
                    Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                    Discount = Convert.ToSingle(row.Cells["Discount"].Value),
                    Total_Amount = Convert.ToSingle(row.Cells["Total_Amount"].Value)
                });
            }

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
                // Select the clicked row
                dgv_sales.ClearSelection();
                dgv_sales.Rows[e.RowIndex].Selected = true;

                // Populate form fields with data from the selected row
                int salesId = Convert.ToInt32(dgv_sales.Rows[e.RowIndex].Cells["Sales_Id"].Value);

                cls_Sales sale = new cls_Sales
                {
                    Sales_Id = salesId
                };

                sale.Getdata();

                // Populate form fields
                comboCustomer.SelectedValue = sale.Customer_Id_fk;
                numericQuantity.Value = sale.SalesDetailsList[0].Quantity;
                comboBook.SelectedValue = sale.SalesDetailsList[0].Book_Id_fk;

                // Update the UI dynamically
                UpdateFinalPaymentDisplay();
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
                label_TotalAmount.Text = "Total Amount: $0.00";
                labelDiscount.Text = "Discount: 0%";
                labelFinalPayment.Text = "Final Payment: $0.00";
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

        private void dgv_sales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRemoveBook(object sender, EventArgs e)
        {

        }

        private void dgv_books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Customer cstms = new Customer(_staffId);
            cstms.ShowDialog();
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales(_staffId);
            sale.ShowDialog();
        }

        private void btn_Cusorder_Click(object sender, EventArgs e)
        {
            Customer cusorder = new Customer(_staffId);
            cusorder.ShowDialog();
        }

        private void btn_Supporder_Click(object sender, EventArgs e)
        {
            SupplierOrder spplyOrder = new SupplierOrder(_staffId);
            spplyOrder.ShowDialog();
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            Book book = new Book(_staffId);
            book.ShowDialog();
        }

        private void btn_Suppliers_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers(_staffId);
            suppliers.ShowDialog();
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff(_staffId);
            staff.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}