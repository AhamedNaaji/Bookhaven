using Bookhaven.CommonClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookhaven
{
    public partial class Report : Form
    {
        filloperation fill = new filloperation();

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // Populate combo boxes
            fill.combobox("SELECT Customer_Id, Customer_Name FROM Customer", comboCustomerFilter, "Customer_Name", "Customer_Id");
            fill.combobox("SELECT Staff_Id, Staff_Name FROM Staff", comboStaffFilter, "Staff_Name", "Staff_Id");

            // Load initial sales data
            LoadSalesData();
        }

        private void LoadSalesData(string customerId = null, string staffId = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            string query = @"
        SELECT s.Sales_Id, c.Customer_Name, st.Staff_Name, s.Date, s.Total_Payment
        FROM Sales s
        INNER JOIN Customer c ON s.Customer_Id_fk = c.Customer_Id
        INNER JOIN Staff st ON s.Staff_Id_fk = st.Staff_Id
        WHERE 1=1";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(customerId))
            {
                query += " AND c.Customer_Id = @CustomerId";
                parameters.Add(new SqlParameter("@CustomerId", customerId));
            }

            if (!string.IsNullOrEmpty(staffId))
            {
                query += " AND st.Staff_Id = @StaffId";
                parameters.Add(new SqlParameter("@StaffId", staffId));
            }

            if (fromDate.HasValue)
            {
                query += " AND s.Date >= @FromDate";
                parameters.Add(new SqlParameter("@FromDate", fromDate.Value));
            }

            if (toDate.HasValue)
            {
                query += " AND s.Date <= @ToDate";
                parameters.Add(new SqlParameter("@ToDate", toDate.Value));
            }

            fill.FillDataGridView(query, dgv_sales, parameters.ToArray());
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            string customerId = comboCustomerFilter.SelectedValue?.ToString();
            string staffId = comboStaffFilter.SelectedValue?.ToString();
            DateTime? fromDate = dateTimePickerFrom.Checked ? dateTimePickerFrom.Value : (DateTime?)null;
            DateTime? toDate = dateTimePickerTo.Checked ? dateTimePickerTo.Value : (DateTime?)null;

            LoadSalesData(customerId, staffId, fromDate, toDate);
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            comboCustomerFilter.SelectedIndex = -1;
            comboStaffFilter.SelectedIndex = -1;
            dateTimePickerFrom.Checked = false;
            dateTimePickerTo.Checked = false;

            LoadSalesData();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
