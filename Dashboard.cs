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
    }
}
