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
    public partial class Dashboard_Clerk : Form
    {
        public Dashboard_Clerk()
        {
            InitializeComponent();
            btn_overview.BackColor = Color.MediumAquamarine;
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Customer_Clerk customer = new Customer_Clerk();
            customer.ShowDialog();
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            Clerk_Sales sales = new Clerk_Sales();
            sales.ShowDialog();
        }

        private void btn_Cusorder_Click(object sender, EventArgs e)
        {
            Clerk_CustomerOrder clerk_CustomerOrder = new Clerk_CustomerOrder();
            clerk_CustomerOrder.ShowDialog();
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            Clerk_Book book = new Clerk_Book();
            book.ShowDialog();
        }

        private void btn_overview_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Clerk_Load(object sender, EventArgs e)
        {

        }

        private void btn_updateBook_Click(object sender, EventArgs e)
        {

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
    }
}
