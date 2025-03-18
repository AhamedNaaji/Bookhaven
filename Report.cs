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
        private string connectionString = "Data Source=AFRIDI;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False";
        public Report()
        {
            InitializeComponent();
            LoadFilters();
        }

        private void LoadFilters()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Populate Staff dropdown
                    string staffQuery = "SELECT Staff_Id, Staff_Name FROM Staff";
                    using (SqlCommand staffCmd = new SqlCommand(staffQuery, connection))
                    {
                        SqlDataAdapter staffAdapter = new SqlDataAdapter(staffCmd);
                        DataTable staffTable = new DataTable();
                        staffAdapter.Fill(staffTable);

                        DataRow allStaffRow = staffTable.NewRow();
                        allStaffRow["Staff_Id"] = -1;
                        allStaffRow["Staff_Name"] = "All Staff";
                        staffTable.Rows.InsertAt(allStaffRow, 0);

                        
                    }

                    // Populate Customer dropdown
                    string customerQuery = "SELECT Customer_Id, Customer_Name FROM Customer";
                    using (SqlCommand customerCmd = new SqlCommand(customerQuery, connection))
                    {
                        SqlDataAdapter customerAdapter = new SqlDataAdapter(customerCmd);
                        DataTable customerTable = new DataTable();
                        customerAdapter.Fill(customerTable);

                        DataRow allCustomerRow = customerTable.NewRow();
                        allCustomerRow["Customer_Id"] = -1;
                        allCustomerRow["Customer_Name"] = "All Customers";
                        customerTable.Rows.InsertAt(allCustomerRow, 0);

                        
                    }

                    // Populate Supplier dropdown
                    string supplierQuery = "SELECT Supplier_Id, Supplier_Name FROM Supplier";
                    using (SqlCommand supplierCmd = new SqlCommand(supplierQuery, connection))
                    {
                        SqlDataAdapter supplierAdapter = new SqlDataAdapter(supplierCmd);
                        DataTable supplierTable = new DataTable();
                        supplierAdapter.Fill(supplierTable);

                        DataRow allSupplierRow = supplierTable.NewRow();
                        allSupplierRow["Supplier_Id"] = -1;
                        allSupplierRow["Supplier_Name"] = "All Suppliers";
                        supplierTable.Rows.InsertAt(allSupplierRow, 0);

                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading filters: " + ex.Message);
                }
            }

            // Populate Report Type ComboBox
            comboReportType.Items.Clear();
            comboReportType.Items.Add("Sales");
            comboReportType.Items.Add("Books");
            comboReportType.Items.Add("Suppliers");
            comboReportType.Items.Add("Customer Orders");
            comboReportType.Items.Add("Supplier Orders");
            comboReportType.Items.Add("Staff");
            comboReportType.Items.Add("Customers");
            comboReportType.Items.Add("Staff Performance");
            comboReportType.Items.Add("Revenue");
            comboReportType.Items.Add("Inventory");
            comboReportType.Items.Add("Top-Selling Books");
            comboReportType.Items.Add("Discount Analysis");
            comboReportType.Items.Add("Author Sales");
            comboReportType.Items.Add("Genre Sales");
            comboReportType.Items.Add("Delivery Preferences");
            comboReportType.Items.Add("Order Status");

            if (comboReportType.Items.Count > 0)
            {
                comboReportType.SelectedIndex = 0; // Select the first item by default
            }
        }

        private void btn_GenerateReport_Click(object sender, EventArgs e)
        {
            string reportType = comboReportType.SelectedItem?.ToString();
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            if (string.IsNullOrEmpty(reportType))
            {
                MessageBox.Show("Please select a report type.", "Validation Error");
                return;
            }

            switch (reportType)
            {
                case "Sales":
                    GenerateSalesReport(startDate, endDate);
                    break;
                case "Books":
                    GenerateBookReport(startDate, endDate);
                    break;
                case "Suppliers":
                    GenerateSupplierReport(startDate, endDate);
                    break;
                case "Customer Orders":
                    GenerateCustomerOrderReport(startDate, endDate);
                    break;
                case "Supplier Orders":
                    GenerateSupplierOrderReport(startDate, endDate);
                    break;
                case "Staff":
                    GenerateStaffReport();
                    break;
                case "Customers":
                    GenerateCustomerReport();
                    break;
                case "Staff Performance":
                    GenerateStaffPerformanceReport(startDate, endDate);
                    break;
                case "Revenue":
                    GenerateRevenueReport(startDate, endDate);
                    break;
                case "Inventory":
                    GenerateInventoryReport();
                    break;
                case "Top-Selling Books":
                    GenerateTopSellingBooksReport(startDate, endDate);
                    break;
                case "Discount Analysis":
                    GenerateDiscountAnalysisReport(startDate, endDate);
                    break;
                case "Author Sales":
                    GenerateAuthorSalesReport();
                    break;
                case "Genre Sales":
                    GenerateGenreSalesReport();
                    break;
                case "Delivery Preferences":
                    GenerateDeliveryPreferencesReport();
                    break;
                case "Order Status":
                    GenerateOrderStatusReport();
                    break;
                default:
                    MessageBox.Show("Invalid report type selected.", "Error");
                    break;
            }
        }

        private void ExecuteReportQuery(string query, DateTime? startDate = null, DateTime? endDate = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (startDate.HasValue)
                            command.Parameters.AddWithValue("@StartDate", startDate.Value);
                        if (endDate.HasValue)
                            command.Parameters.AddWithValue("@EndDate", endDate.Value);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind the data to the DataGridView
                        dgv_report.DataSource = dt;

                        // Format the Total_Payment column to display two decimal places
                        if (dgv_report.Columns.Contains("Total_Payment"))
                        {
                            dgv_report.Columns["Total_Payment"].DefaultCellStyle.Format = "N2"; // Two decimal places
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while generating the report: " + ex.Message);
                }
            }
        }

        // Reports Implementation
        private void GenerateSalesReport(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT 
                    s.Sales_Id,
                    st.Staff_Name AS Staff,
                    c.Customer_Name AS Customer,
                    s.Date,
                    s.Total_Payment
                FROM Sales s
                INNER JOIN Staff st ON s.Staff_Id_fk = st.Staff_Id
                INNER JOIN Customer c ON s.Customer_Id_fk = c.Customer_Id
                WHERE s.Date BETWEEN @StartDate AND @EndDate
                ORDER BY s.Date DESC";

            ExecuteReportQuery(query, startDate, endDate);
        }

        private void GenerateBookReport(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT 
                    b.Book_Id,
                    b.Book_Name,
                    SUM(sd.Quantity) AS Total_Sold,
                    SUM(sd.Total_Amount) AS Total_Revenue
                FROM Book b
                LEFT JOIN SalesDetails sd ON b.Book_Id = sd.Book_Id_fk
                INNER JOIN Sales s ON sd.Sales_Id_fk = s.Sales_Id
                WHERE s.Date BETWEEN @StartDate AND @EndDate
                GROUP BY b.Book_Id, b.Book_Name
                ORDER BY Total_Revenue DESC";

            ExecuteReportQuery(query, startDate, endDate);
        }

        private void GenerateSupplierReport(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT 
                    sp.Supplier_Id,
                    sp.Supplier_Name,
                    COUNT(so.supOrder_Id) AS Total_Orders,
                    SUM(so.Total_Payment) AS Total_Payments
                FROM Supplier sp
                LEFT JOIN supOrder so ON sp.Supplier_Id = so.Supplier_Id_fk
                WHERE so.Date BETWEEN @StartDate AND @EndDate
                GROUP BY sp.Supplier_Id, sp.Supplier_Name
                ORDER BY Total_Payments DESC";

            ExecuteReportQuery(query, startDate, endDate);
        }

        private void GenerateCustomerOrderReport(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT 
                    co.CustOrder_Id,
                    c.Customer_Name,
                    co.Date,
                    co.Total_Payment
                FROM CusOrder co
                INNER JOIN Customer c ON co.Customer_Id_fk = c.Customer_Id
                WHERE co.Date BETWEEN @StartDate AND @EndDate
                ORDER BY co.Date DESC";

            ExecuteReportQuery(query, startDate, endDate);
        }

        private void GenerateSupplierOrderReport(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT 
                    so.supOrder_Id,
                    sp.Supplier_Name,
                    so.Date,
                    so.Total_Payment
                FROM supOrder so
                INNER JOIN Supplier sp ON so.Supplier_Id_fk = sp.Supplier_Id
                WHERE so.Date BETWEEN @StartDate AND @EndDate
                ORDER BY so.Date DESC";

            ExecuteReportQuery(query, startDate, endDate);
        }

        private void GenerateStaffReport()
        {
            string query = @"
                SELECT 
                    Staff_Id,
                    Staff_Name,
                    Email,
                    MobileNum AS Mobile_Number,
                    Address
                FROM Staff
                ORDER BY Staff_Name";

            ExecuteReportQuery(query);
        }

        private void GenerateCustomerReport()
        {
            string query = @"
                SELECT 
                    c.Customer_Id,
                    c.Customer_Name,
                    c.NIC,
                    c.DOB,
                    c.Email,
                    c.Address,
                    STRING_AGG(cm.Mobile_Number, ', ') AS Mobile_Numbers
                FROM Customer c
                LEFT JOIN CustomerMobile cm ON c.Customer_Id = cm.Customer_Id_fk
                GROUP BY c.Customer_Id, c.Customer_Name, c.NIC, c.DOB, c.Email, c.Address
                ORDER BY c.Customer_Name";

            ExecuteReportQuery(query);
        }

        private void GenerateStaffPerformanceReport(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT 
                    st.Staff_Name,
                    COUNT(s.Sales_Id) AS Total_Sales,
                    SUM(s.Total_Payment) AS Total_Revenue
                FROM Staff st
                LEFT JOIN Sales s ON st.Staff_Id = s.Staff_Id_fk
                WHERE s.Date BETWEEN @StartDate AND @EndDate
                GROUP BY st.Staff_Name
                ORDER BY Total_Revenue DESC";

            ExecuteReportQuery(query, startDate, endDate);
        }

        private void GenerateRevenueReport(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT 
                    DATEPART(YEAR, s.Date) AS Year,
                    DATEPART(MONTH, s.Date) AS Month,
                    SUM(s.Total_Payment) AS Total_Revenue
                FROM Sales s
                WHERE s.Date BETWEEN @StartDate AND @EndDate
                GROUP BY DATEPART(YEAR, s.Date), DATEPART(MONTH, s.Date)
                ORDER BY Year, Month";

            ExecuteReportQuery(query, startDate, endDate);
        }

        private void GenerateInventoryReport()
        {
            string query = @"
                SELECT 
                    b.Book_Id,
                    b.Book_Name,
                    s.Stock_Quantity,
                    b.Price,
                    (s.Stock_Quantity * b.Price) AS Total_Value
                FROM Book b
                LEFT JOIN Stock s ON b.Book_Id = s.Book_Id_fk
                ORDER BY s.Stock_Quantity ASC";

            ExecuteReportQuery(query);
        }

        private void GenerateTopSellingBooksReport(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT 
                    b.Book_Id,
                    b.Book_Name,
                    SUM(sd.Quantity) AS Total_Sold,
                    SUM(sd.Total_Amount) AS Total_Revenue
                FROM Book b
                LEFT JOIN SalesDetails sd ON b.Book_Id = sd.Book_Id_fk
                INNER JOIN Sales s ON sd.Sales_Id_fk = s.Sales_Id
                WHERE s.Date BETWEEN @StartDate AND @EndDate
                GROUP BY b.Book_Id, b.Book_Name
                ORDER BY Total_Sold DESC";

            ExecuteReportQuery(query, startDate, endDate);
        }

        private void GenerateDiscountAnalysisReport(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT 
                    b.Book_Name,
                    SUM(sd.Quantity) AS Total_Sold,
                    SUM(sd.Discount) AS Total_Discount,
                    SUM(sd.Total_Amount) AS Total_Revenue
                FROM SalesDetails sd
                INNER JOIN Book b ON sd.Book_Id_fk = b.Book_Id
                INNER JOIN Sales s ON sd.Sales_Id_fk = s.Sales_Id
                WHERE s.Date BETWEEN @StartDate AND @EndDate
                GROUP BY b.Book_Name
                ORDER BY Total_Discount DESC";

            ExecuteReportQuery(query, startDate, endDate);
        }

        private void GenerateAuthorSalesReport()
        {
            string query = @"
                SELECT 
                    a.AuthorName,
                    SUM(sd.Quantity) AS Total_Sold,
                    SUM(sd.Total_Amount) AS Total_Revenue
                FROM Author a
                INNER JOIN BookAuthor ba ON a.Author_Id = ba.Author_Id_fk
                INNER JOIN Book b ON ba.Book_Id_fk = b.Book_Id
                INNER JOIN SalesDetails sd ON b.Book_Id = sd.Book_Id_fk
                GROUP BY a.AuthorName
                ORDER BY Total_Revenue DESC";

            ExecuteReportQuery(query);
        }

        private void GenerateGenreSalesReport()
        {
            string query = @"
                SELECT 
                    g.genreName,
                    SUM(sd.Quantity) AS Total_Sold,
                    SUM(sd.Total_Amount) AS Total_Revenue
                FROM Genre g
                INNER JOIN Book b ON g.Genre_Id = b.Genre_Id_fk
                INNER JOIN SalesDetails sd ON b.Book_Id = sd.Book_Id_fk
                GROUP BY g.genreName
                ORDER BY Total_Revenue DESC";

            ExecuteReportQuery(query);
        }

        private void GenerateDeliveryPreferencesReport()
        {
            string query = @"
                SELECT 
                    cod.DeliveryMethod,
                    COUNT(cod.CusOrderDetails_Id) AS Total_Orders,
                    SUM(cod.Final_Amount) AS Total_Revenue
                FROM CusOrderDetails cod
                GROUP BY cod.DeliveryMethod
                ORDER BY Total_Orders DESC";

            ExecuteReportQuery(query);
        }

        private void GenerateOrderStatusReport()
        {
            string query = @"
                -- For Customer Orders
                SELECT 
                    os.status,
                    COUNT(co.CustOrder_Id) AS Total_Orders
                FROM CusOrder co
                INNER JOIN orderStatus os ON co.Status_Id_fk = os.statusId
                GROUP BY os.status

                UNION ALL

                -- For Supplier Orders
                SELECT 
                    os.status,
                    COUNT(so.supOrder_Id) AS Total_Orders
                FROM supOrder so
                INNER JOIN orderStatus os ON so.Status_Id_fk = os.statusId
                GROUP BY os.status";

            ExecuteReportQuery(query);
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Export functionality not implemented yet.", "Info");
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // Load any additional data or configurations here
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

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            // Display a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // Clear session data or reset user-specific information
                // Program.CurrentUser = null;
                // Close the current Dashboard form
                this.Close();
                // Show the LoginForm
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
        }
    }
}
