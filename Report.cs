using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Bookhaven
{
    public partial class Report : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3UAK82;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");
        public Report()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            // Reset filters
            cmb_staff.SelectedIndex = -1;
            cmb_customer.SelectedIndex = -1;
            dtp_from.Value = DateTime.Now.AddMonths(-1); // Reset to 1 month ago
            dtp_to.Value = DateTime.Now; // Reset to today

            // Reload the report
            LoadReport();
        }


        private void Report_Load(object sender, EventArgs e)
        {
            // Populate cmb_staff (Staff Names)
            string staffQuery = "SELECT Staff_Id, Staff_Name FROM Staff";
            FillComboBox(staffQuery, cmb_staff, "Staff_Name", "Staff_Id");

            // Populate cmb_customer (Customer Names)
            string customerQuery = "SELECT Customer_Id, Customer_Name FROM Customer";
            FillComboBox(customerQuery, cmb_customer, "Customer_Name", "Customer_Id");

            // Set default date range
            dtp_from.Value = DateTime.Now.AddMonths(-1); // Default: 1 month ago
            dtp_to.Value = DateTime.Now; // Default: today

            // Load initial report
            LoadReport();
        }
        private void FillComboBox(string query, ComboBox comboBox, string displayMember, string valueMember)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                comboBox.DataSource = dataTable;
                comboBox.DisplayMember = displayMember;
                comboBox.ValueMember = valueMember;
                comboBox.SelectedIndex = -1; // No selection by default
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading combo box: {ex.Message}", "Error");
            }
        }
        private void LoadReport()
        {
            try
            {
                // Build the query dynamically based on selected filters
                string query = @"
                    SELECT 
                        s.Sales_Id,
                        c.Customer_Name AS Customer,
                        st.Staff_Name AS Staff,
                        s.Date,
                        sd.Book_Id_fk AS BookId,
                        b.Book_Name AS Book,
                        sd.Quantity,
                        sd.Price,
                        sd.Discount,
                        sd.Total_Amount
                    FROM Sales s
                    INNER JOIN Customer c ON s.Customer_Id_fk = c.Customer_Id
                    INNER JOIN Staff st ON s.Staff_Id_fk = st.Staff_Id
                    INNER JOIN SalesDetails sd ON s.Sales_Id = sd.Sales_Id_fk
                    INNER JOIN Book b ON sd.Book_Id_fk = b.Book_Id
                    WHERE 1=1";

                // Add filters
                if (cmb_staff.SelectedIndex != -1)
                {
                    int staffId = Convert.ToInt32(cmb_staff.SelectedValue);
                    query += $" AND s.Staff_Id_fk = {staffId}";
                }

                if (cmb_customer.SelectedIndex != -1)
                {
                    int customerId = Convert.ToInt32(cmb_customer.SelectedValue);
                    query += $" AND s.Customer_Id_fk = {customerId}";
                }

                query += $" AND s.Date BETWEEN @FromDate AND @ToDate";

                // Execute the query
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@FromDate", dtp_from.Value.Date);
                adapter.SelectCommand.Parameters.AddWithValue("@ToDate", dtp_to.Value.Date);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind data to dgv_report
                dgv_report.DataSource = dataTable;

                // Format columns
                dgv_report.Columns["Sales_Id"].HeaderText = "Sale ID";
                dgv_report.Columns["Customer"].HeaderText = "Customer";
                dgv_report.Columns["Staff"].HeaderText = "Staff";
                dgv_report.Columns["Date"].HeaderText = "Sale Date";
                dgv_report.Columns["BookId"].HeaderText = "Book ID";
                dgv_report.Columns["Book"].HeaderText = "Book Name";
                dgv_report.Columns["Quantity"].HeaderText = "Quantity";
                dgv_report.Columns["Price"].HeaderText = "Price";
                dgv_report.Columns["Discount"].HeaderText = "Discount (%)";
                dgv_report.Columns["Total_Amount"].HeaderText = "Total Amount";

                dgv_report.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report: {ex.Message}", "Error");
            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            // Reload the report with updated filters
            LoadReport();
        }

        private void btn_exportToPdf_Click(object sender, EventArgs e)
        {
            try
            {
                // Prompt the user to choose a location to save the PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    Title = "Save Report as PDF",
                    FileName = "Report.pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Export the DataGridView to PDF
                    ExportToPdf(dgv_report, filePath);

                    MessageBox.Show("Report exported successfully!", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to PDF: {ex.Message}", "Error");
            }

        }
        private void ExportToPdf(DataGridView dgv, string filePath)
        {
            // Create a PDF document
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                PdfWriter writer = new PdfWriter(stream);
                PdfDocument pdfDoc = new PdfDocument(writer);
                Document document = new Document(pdfDoc);

                // Add a title to the PDF
                Paragraph title = new Paragraph("Sales Report")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(18);
                document.Add(title);

                // Add a blank line
                document.Add(new Paragraph("\n"));

                // Add table headers
                Table table = new Table(dgv.ColumnCount).UseAllAvailableWidth();
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    table.AddHeaderCell(column.HeaderText);
                }

                // Add rows to the table
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            table.AddCell(cell.Value.ToString());
                        }
                        else
                        {
                            table.AddCell(""); // Handle null values
                        }
                    }
                }

                // Add the table to the document
                document.Add(table);

                // Close the document
                document.Close();
            }
        
   } }   
}