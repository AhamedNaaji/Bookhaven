using Bookhaven.AppClasses;
using Bookhaven.CommonClasses;
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
    public partial class Customer_Clerk : Form
    {
        customer_cls clscus = new customer_cls();
        filloperation fill = new filloperation();
        public Customer_Clerk()
        {
            InitializeComponent();
        }

        private void txtbox_name_TextChanged(object sender, EventArgs e)
        {
            clscus.Customer_Name = txtbox_name.Text.Trim();
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            // Clear previous entries
            clscus.Mobile_Numbers.Clear();

            // Add both numbers to the list (trim and validate)
            if (!string.IsNullOrEmpty(txtbox_Number1.Text))
                clscus.Mobile_Numbers.Add(txtbox_Number1.Text.Trim());

            if (!string.IsNullOrEmpty(txtbox_Number2.Text))
                clscus.Mobile_Numbers.Add(txtbox_Number2.Text.Trim());

            clscus.Insertdata();
            Customer_Clerk_Load(sender, e);

        }

        private void txtbox_NIC_TextChanged(object sender, EventArgs e)
        {
            clscus.NIC = txtbox_NIC.Text.Trim();
        }

        private void txtbox_DOB_TextChanged(object sender, EventArgs e)
        {
            clscus.DOB = txtbox_DOB.Text.Trim();
        }

        private void txtbox_Address_TextChanged(object sender, EventArgs e)
        {
            clscus.Address = txtbox_Address.Text.Trim();
        }

        private void txtbox_Number1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_updateCustomer_Click(object sender, EventArgs e)
        {
            clscus.Customer_Name = txtbox_name.Text.Trim();
            clscus.NIC = txtbox_NIC.Text.Trim();
            clscus.DOB = txtbox_DOB.Text.Trim();
            clscus.Address = txtbox_Address.Text.Trim();
            clscus.Email = txt_Email.Text.Trim();

            // Update mobile numbers
            clscus.Mobile_Numbers.Clear();
            if (!string.IsNullOrEmpty(txtbox_Number1.Text))
                clscus.Mobile_Numbers.Add(txtbox_Number1.Text.Trim());
            if (!string.IsNullOrEmpty(txtbox_Number2.Text))
                clscus.Mobile_Numbers.Add(txtbox_Number2.Text.Trim());
            clscus.UpdateData();
            Customer_Clerk_Load(sender, e);
        }

        private void btn_deleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgv_cus.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(dgv_cus.SelectedRows[0].Cells["Customer_Id"].Value);
                clscus.Customer_Id = customerId;
                clscus.DeleteDate();
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.", "No Selection");
            }
            clscus.DeleteDate();
            Customer_Clerk_Load(sender, e);
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            clscus.Email = txt_Email.Text.Trim();
        }

        private void Customer_Clerk_Load(object sender, EventArgs e)
        {
            FirstRun();
        }
        void FirstRun()
        {
            // Clear form fields
            txtbox_name.Text = "";
            txtbox_NIC.Text = "";
            txtbox_DOB.Text = "";
            txtbox_Address.Text = "";
            txt_Email.Text = "";
            txtbox_Number1.Text = "";
            txtbox_Number2.Text = "";

            // Updated query to include mobile numbers
            string query = @"
        SELECT 
            c.Customer_Id,
            c.Customer_Name,
            c.NIC,
            c.DOB,
            c.Address,
            c.Email,
            MAX(CASE WHEN cm.RowNum = 1 THEN cm.Mobile_Number END) AS Mobile1,
            MAX(CASE WHEN cm.RowNum = 2 THEN cm.Mobile_Number END) AS Mobile2
        FROM Customer c
        LEFT JOIN (
            SELECT 
                Customer_Id_fk,
                Mobile_Number,
                ROW_NUMBER() OVER (PARTITION BY Customer_Id_fk ORDER BY CustomerMobile_Id) AS RowNum
            FROM CustomerMobile
        ) cm ON c.Customer_Id = cm.Customer_Id_fk
        GROUP BY 
            c.Customer_Id,
            c.Customer_Name,
            c.NIC,
            c.DOB,
            c.Address,
            c.Email";

            // Populate DataGridView
            fill.FillDataGridView(query, dgv_cus);
            dgv_cus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Rename columns
            dgv_cus.Columns[0].HeaderText = "ID";
            dgv_cus.Columns[1].HeaderText = "Name";
            dgv_cus.Columns[2].HeaderText = "NIC";
            dgv_cus.Columns[3].HeaderText = "DOB";
            dgv_cus.Columns[4].HeaderText = "Address";
            dgv_cus.Columns[5].HeaderText = "Email";
            dgv_cus.Columns[6].HeaderText = "Mobile 1";
            dgv_cus.Columns[7].HeaderText = "Mobile 2";
        }

        private void dgv_cus_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get selected customer ID
                int customerId = Convert.ToInt32(dgv_cus.Rows[e.RowIndex].Cells["Customer_Id"].Value);

                // Load customer data
                clscus.Customer_Id = customerId;
                clscus.Getdata();

                // Populate form fields
                txtbox_name.Text = clscus.Customer_Name;
                txtbox_NIC.Text = clscus.NIC;
                txtbox_DOB.Text = clscus.DOB;
                txtbox_Address.Text = clscus.Address;
                txt_Email.Text = clscus.Email;

                // Populate mobile numbers (handle up to 2 numbers)
                txtbox_Number1.Text = clscus.Mobile_Numbers.Count > 0 ? clscus.Mobile_Numbers[0] : "";
                txtbox_Number2.Text = clscus.Mobile_Numbers.Count > 1 ? clscus.Mobile_Numbers[1] : "";
            }
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

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard_Clerk dasclerk = new Dashboard_Clerk();
            dasclerk.ShowDialog();
        }
    }
}
