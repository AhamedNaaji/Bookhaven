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
    }
}
