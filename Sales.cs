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
    public partial class Sales : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=AFRIDI;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");
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

            labelFinalPayment.Text = $"Final Payment: {finalPayment:C}";
        }

        private void comboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label_TotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void labelDiscount_Click(object sender, EventArgs e)
        {

        }

        private void labelFinalPayment_Click(object sender, EventArgs e)
        {

        }

        private void btn_addSales_Click(object sender, EventArgs e)
        {
            cls_sales sale = new cls_sales
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

        private void btn_updateSales_Click(object sender, EventArgs e)
        {
            cls_sales sale = new cls_sales
            {
                Sales_Id = Convert.ToInt32(dgv_sales.SelectedRows[0].Cells["Sales_Id"].Value),
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

            cls_sales sale = new cls_sales
            {
                Sales_Id = salesId
            };

            sale.DeleteData();
            LoadSalesData();
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateFinalPaymentDisplay();
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
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string query = "SELECT Price FROM Book WHERE Book_Id = @Book_Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Book_Id", comboBook.SelectedValue);

                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToSingle(result) : 0; // Handle null values gracefully
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching book price: {ex.Message}");
                return 0;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        private float GetBookDiscount()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string query = "SELECT Discount FROM Book WHERE Book_Id = @Book_Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Book_Id", comboBook.SelectedValue);

                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToSingle(result) : 0; // Handle null values gracefully
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching book discount: {ex.Message}");
                return 0;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
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

        private void comboStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_sales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int salesId = Convert.ToInt32(dgv_sales.Rows[e.RowIndex].Cells["Sales_Id"].Value);

                cls_sales sale = new cls_sales
                {
                    Sales_Id = salesId
                };

                sale.Getdata();

                // Populate form fields
                comboCustomer.SelectedValue = sale.Customer_Id_fk;
                dateTimePickerDate.Value = sale.Date;
                numericQuantity.Value = sale.SalesDetailsList[0].Quantity;
                comboBook.SelectedValue = sale.SalesDetailsList[0].Book_Id_fk;

                // Update the UI dynamically
                UpdateFinalPaymentDisplay();
            }

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

    }
}
