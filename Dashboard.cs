using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookhaven
{
    public partial class Dashboard : Form
    {
        private string connectionString = "Data Source=AFRIDI;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False";

        public Dashboard()
        {
            InitializeComponent();
            LoadCounts();
        }

        private void LoadCounts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Count Customers
                    label_Total_Customers.Text = GetCount(connection, "Customer").ToString();

                    // Count Books
                    label_Total_Books.Text = GetCount(connection, "Book").ToString();

                    // Count Suppliers
                    label_Total_Suppliers.Text = GetCount(connection, "Supplier").ToString();

                    // Count Staffs
                    label_Total_Staffs.Text = GetCount(connection, "Staff").ToString();

                    // Count Sales
                    label_Total_Sales.Text = GetCount(connection, "Sales").ToString();

                    // Count Customer Orders
                    label_Total_Customer_Orders.Text = GetCount(connection, "CusOrder").ToString();

                    // Count Supplier Orders
                    label_Total_Supplier_Orders.Text = GetCount(connection, "supOrder").ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private int GetCount(SqlConnection connection, string tableName)
        {
            string query = $"SELECT COUNT(*) FROM {tableName}";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                return (int)command.ExecuteScalar();
            }
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
                //Program.CurrentUser = null;

                // Close the current Dashboard form
                this.Close();

                // Show the LoginForm
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
        }

        private void books_btn_Click(object sender, EventArgs e)
        {
            Book books = new Book();
            books.ShowDialog();
        }

        private void customer_btn_Click(object sender, EventArgs e)
        {
            Customer customers = new Customer();
            customers.ShowDialog();
        }

        private void supplier_btn_Click(object sender, EventArgs e)
        {
            Suppliers supplier = new Suppliers();
            supplier.ShowDialog();
        }

        private void sales_btn_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales();
            sale.ShowDialog();
        }

        private void staffs_btn_Click(object sender, EventArgs e)
        {
            Staff stffs = new Staff();
            stffs.ShowDialog();
        }
    }
}