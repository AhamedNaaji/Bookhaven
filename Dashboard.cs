using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookhaven
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
            btn_overview.BackColor = Color.MediumAquamarine;

        }

        

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            Sales emp_sale = new Sales();
            emp_sale.ShowDialog();
        }

        private void btn_Cusorder_Click(object sender, EventArgs e)
        {
            CustomerOrder emp_cusOrder = new CustomerOrder();
            emp_cusOrder.ShowDialog();
        }

        private void btn_cus_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.ShowDialog();
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.ShowDialog();
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.ShowDialog();
        }

        private void btn_Supporder_Click(object sender, EventArgs e)
        {
            SupplierOrder supOrder = new SupplierOrder();
            supOrder.ShowDialog();
        }

        private void btn_Suppliers_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.ShowDialog();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ShowDialog();
        }

        private void lbl_TotalCustomer_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void makesales_btn_Click(object sender, EventArgs e)
        {
            Sales emp_sale = new Sales();
            emp_sale.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            //Session["Username"] = null; // Clear session variables
            // Confirm with the user before logging out
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Clear session variables (if applicable)
                    // Example: Session["Username"] = null;

                    // Close all open forms except the login form
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.Name != "Login")
                        {
                            form.Close();
                        }
                    }

                    // Open the login form
                    Form1 loginForm = new Form1();
                    loginForm.Show();
                }
                catch (Exception ex)
                {
                    // Handle any unexpected errors
                    MessageBox.Show($"An error occurred while logging out: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_overview_Click(object sender, EventArgs e)
        {
           
        }
    }
}
