using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookhaven
{
    public partial class Dashboard_Clerk : Form
    {
        private string connectionString = "Data Source=AFRIDI;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False";
        private int currentStaffId;

        public Dashboard_Clerk(int staffId)
        {
            InitializeComponent();
            currentStaffId = staffId;
            LoadCounts();
            LoadRecentSales();
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
                    // Count Sales
                    label_Total_Sales.Text = GetCount(connection, "Sales").ToString();
                    // Count Customer Orders
                    label_Total_Customer_Orders.Text = GetCount(connection, "CusOrder").ToString();
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

        private void LoadRecentSales()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Query to get recent sales for the current staff member with staff name and customer name
                    string query = @"
    SELECT 
        s.Sales_Id,
        st.Staff_Name,
        c.Customer_Name,
        s.Date,
        s.Total_Payment
    FROM Sales s
    INNER JOIN Staff st ON s.Staff_Id_fk = st.Staff_Id
    INNER JOIN Customer c ON s.Customer_Id_fk = c.Customer_Id
    WHERE s.Staff_Id_fk = @Staff_Id
    ORDER BY s.Date DESC";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Staff_Id", currentStaffId);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgv_recent_sales.DataSource = dt;
                        // Rename columns
                        dgv_recent_sales.Columns[0].HeaderText = "Sales ID";
                        dgv_recent_sales.Columns[1].HeaderText = "Staff Name";
                        dgv_recent_sales.Columns[2].HeaderText = "Customer Name";
                        dgv_recent_sales.Columns[3].HeaderText = "Date";
                        dgv_recent_sales.Columns[4].HeaderText = "Total Payment";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard_Clerk dasclerk = new Dashboard_Clerk(currentStaffId);
            dasclerk.ShowDialog();
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

        private void books_btn_Click(object sender, EventArgs e)
        {
            Clerk_Book book = new Clerk_Book(currentStaffId);
            book.ShowDialog();
        }

        private void customer_btn_Click(object sender, EventArgs e)
        {
            Customer_Clerk customer = new Customer_Clerk(currentStaffId);
            customer.ShowDialog();
        }

        private void sales_btn_Click(object sender, EventArgs e)
        {
            Clerk_Sales sales = new Clerk_Sales(currentStaffId);
            sales.ShowDialog();
        }
    }
}