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
    }
}
