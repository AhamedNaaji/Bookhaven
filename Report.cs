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
    public partial class Report : Form
    {
        private string connectionString = "Data Source=AFRIDI;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False";
        public Report()
        {
            InitializeComponent();
            LoadFilters();
        }

        private void LoadFilters()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Populate Staff dropdown
                    string staffQuery = "SELECT Staff_Id, Staff_Name FROM Staff";
                    using (SqlCommand staffCmd = new SqlCommand(staffQuery, connection))
                    {
                        SqlDataAdapter staffAdapter = new SqlDataAdapter(staffCmd);
                        DataTable staffTable = new DataTable();
                        staffAdapter.Fill(staffTable);

                        // Add "All Staff" row to the DataTable
                        DataRow allStaffRow = staffTable.NewRow();
                        allStaffRow["Staff_Id"] = -1; // Use a unique ID (e.g., -1) for "All Staff"
                        allStaffRow["Staff_Name"] = "All Staff";
                        staffTable.Rows.InsertAt(allStaffRow, 0);

                        comboStaff.DataSource = staffTable;
                        comboStaff.DisplayMember = "Staff_Name";
                        comboStaff.ValueMember = "Staff_Id";
                    }

                    // Populate Customer dropdown
                    string customerQuery = "SELECT Customer_Id, Customer_Name FROM Customer";
                    using (SqlCommand customerCmd = new SqlCommand(customerQuery, connection))
                    {
                        SqlDataAdapter customerAdapter = new SqlDataAdapter(customerCmd);
                        DataTable customerTable = new DataTable();
                        customerAdapter.Fill(customerTable);

                        // Add "All Customers" row to the DataTable
                        DataRow allCustomerRow = customerTable.NewRow();
                        allCustomerRow["Customer_Id"] = -1; // Use a unique ID (e.g., -1) for "All Customers"
                        allCustomerRow["Customer_Name"] = "All Customers";
                        customerTable.Rows.InsertAt(allCustomerRow, 0);

                        comboCustomer.DataSource = customerTable;
                        comboCustomer.DisplayMember = "Customer_Name";
                        comboCustomer.ValueMember = "Customer_Id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading filters: " + ex.Message);
                }
            }
        }

        private void btn_GenerateReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            int? staffId = comboStaff.SelectedIndex > 0 ? (int?)comboStaff.SelectedValue : null;
            int? customerId = comboCustomer.SelectedIndex > 0 ? (int?)comboCustomer.SelectedValue : null;

            GenerateReport(startDate, endDate, staffId, customerId);
        }

        private void GenerateReport(DateTime startDate, DateTime endDate, int? staffId, int? customerId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to generate the report
                    string query = @"
                        SELECT 
                            s.Sales_Id,
                            st.Staff_Name AS Staff,
                            c.Customer_Name AS Customer,
                            s.Date,
                            s.Total_Payment
                        FROM Sales s
                        INNER JOIN Staff st ON s.Staff_Id_fk = st.Staff_Id
                        INNER JOIN Customer c ON s.Customer_Id_fk = c.Customer_Id
                        WHERE s.Date BETWEEN @StartDate AND @EndDate
                        AND (@StaffId IS NULL OR s.Staff_Id_fk = @StaffId)
                        AND (@CustomerId IS NULL OR s.Customer_Id_fk = @CustomerId)
                        ORDER BY s.Date DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);
                        command.Parameters.AddWithValue("@StaffId", staffId ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@CustomerId", customerId ?? (object)DBNull.Value);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind the data to the DataGridView
                        dgv_report.DataSource = dt;

                        // Calculate aggregated totals
                        float totalSales = dt.Rows.Count;
                        float totalPayments = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            totalPayments += Convert.ToSingle(row["Total_Payment"]);
                        }

                        // Display aggregated totals
                        label_Total_Sales.Text = $"Total Sales: {totalSales}";
                        label_Total_Payments.Text = $"Total Payments: {totalPayments}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while generating the report: " + ex.Message);
                }
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            // Export logic (e.g., to Excel or PDF)
            MessageBox.Show("Export functionality not implemented yet.", "Info");
        }



        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dshboard = new Dashboard();
            dshboard.ShowDialog();
        }

        private void btn_Staffs_Click(object sender, EventArgs e)
        {
            Staff stffs = new Staff();
            stffs.ShowDialog();
        }

        private void btn_Customers_Click(object sender, EventArgs e)
        {
            Customer customers = new Customer();
            customers.ShowDialog();
        }

        private void btn_Suppliers_Click(object sender, EventArgs e)
        {
            Suppliers supplier = new Suppliers();
            supplier.ShowDialog();
        }

        private void btn_Books_Click(object sender, EventArgs e)
        {
            Book books = new Book();
            books.ShowDialog();
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales();
            sale.ShowDialog();
        }

        private void btn_CustomerOrders_Click(object sender, EventArgs e)
        {
            CustomerOrder cusOrders = new CustomerOrder();
            cusOrders.ShowDialog();
        }

        private void btn_SupplierOrders_Click(object sender, EventArgs e)
        {
            SupplierOrder supOrders = new SupplierOrder();
            supOrders.ShowDialog();
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            Report reports = new Report();
            reports.ShowDialog();
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
    }
}
