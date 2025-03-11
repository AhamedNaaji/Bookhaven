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
    }
}
