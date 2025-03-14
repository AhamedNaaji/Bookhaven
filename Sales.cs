using Bookhaven.AppClasses;
using Bookhaven.CommonClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookhaven
{
    public partial class Sales : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=MMSALMANFARIS;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");
        filloperation fill = new filloperation(); // Declare and initialize the 'fill' object

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
            int bookId = Convert.ToInt32(comboBook.SelectedValue);

            if (CheckBookStock(bookId))
            {
                cls_Sales sale = new cls_Sales
                {
                    Staff_Id_fk = Convert.ToInt32(comboStaff.SelectedValue),
                    Customer_Id_fk = Convert.ToInt32(comboCustomer.SelectedValue),
                    Date = dateTimePickerDate.Value,
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

            cls_Sales sale = new cls_Sales
            {
                Sales_Id = salesId,
                Staff_Id_fk = Convert.ToInt32(comboStaff.SelectedValue),
                Customer_Id_fk = Convert.ToInt32(comboCustomer.SelectedValue),
                Date = dateTimePickerDate.Value,
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
            var details = new List<SalesDetail>
            {
                new SalesDetail
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
                dateTimePickerDate.Value = sale.Date;
                numericQuantity.Value = sale.SalesDetailsList[0].Quantity;
                comboBook.SelectedValue = sale.SalesDetailsList[0].Book_Id_fk;
                comboStaff.SelectedValue = sale.Staff_Id_fk;

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
    }
}