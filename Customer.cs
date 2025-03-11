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
    public partial class Customer : Form
    {
        cls_customer clscus = new cls_customer();
        filloperation fill = new filloperation();
        public Customer()
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
            //clscus.Mobile_Number = txtbox_Number1.Text.Trim();
        }

        private void txtbox_Number2_TextChanged(object sender, EventArgs e)
        {
            //clscus.Mobile_Number = txtbox_Number2.Text.Trim();
        }

        private void btn_updateCustomer_Click(object sender, EventArgs e)
        {
            clscus.UpdateData();
        }

        private void btn_deleteCustomer_Click(object sender, EventArgs e)
        {
            clscus.DeleteDate();
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            clscus.Email = txt_Email.Text.Trim();
        }

        private void frm_load(object sender, EventArgs e)
        {
            //fill.combobox("SELECT * FROM tbl_employeetype", cmb_emptype, "emp_type", "emp_type_id");
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

            // Populate the customer DataGridView
            fill.FillDataGridView("SELECT Customer_Id, Customer_Name, NIC, DOB, Address, Email FROM Customer", dgv_cus);
            dgv_cus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Rename columns for clarity
            dgv_cus.Columns[0].HeaderText = "ID";
            dgv_cus.Columns[1].HeaderText = "Name";
            dgv_cus.Columns[2].HeaderText = "NIC";
            dgv_cus.Columns[3].HeaderText = "DOB";
            dgv_cus.Columns[4].HeaderText = "Address";
            dgv_cus.Columns[5].HeaderText = "Email";
        }

        private void dgv_cus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                // Get the selected customer's ID
                int customerId = Convert.ToInt32(dgv_cus.Rows[e.RowIndex].Cells["Customer_Id"].Value);

                // Retrieve customer data
                clscus.Customer_Id = customerId;
                clscus.Getdata();

                // Populate form fields
                txtbox_name.Text = clscus.Customer_Name;
                txtbox_NIC.Text = clscus.NIC;
                txtbox_DOB.Text = clscus.DOB;
                txtbox_Address.Text = clscus.Address;
                txt_Email.Text = clscus.Email;

                // Populate mobile numbers (assuming two textboxes for numbers)
                if (clscus.Mobile_Numbers.Count > 0)
                    txtbox_Number1.Text = clscus.Mobile_Numbers[0];
                if (clscus.Mobile_Numbers.Count > 1)
                    txtbox_Number2.Text = clscus.Mobile_Numbers[1];
            }
        }

        private void dgv_cus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
