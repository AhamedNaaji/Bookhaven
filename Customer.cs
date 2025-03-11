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
        //filloperation fill = new filloperation();
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
            clscus.InsertCustomer();
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
            clscus.mobileNumber2 = txtbox_Number1.Text.Trim();
        }

        private void txtbox_Number2_TextChanged(object sender, EventArgs e)
        {
            clscus.mobileNumber2 = txtbox_Number2.Text.Trim();
        }

        private void btn_updateCustomer_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_deleteCustomer_Click(object sender, EventArgs e)
        {
          
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_Email_TextChanged(object sender, EventArgs e)
        {
            clscus.Email = txtbox_Email.Text.Trim();
        }
    }
}
