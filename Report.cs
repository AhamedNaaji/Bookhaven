using Bookhaven.CommonClasses;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;
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

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            saveFileDialog.FileName = "SalesReport.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToPDF(filePath);
            }
        }

        private void ExportToPDF(string filePath)
        {
            try
            {
                // Create a PDF document
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    PdfWriter writer = new PdfWriter(stream);
                    PdfDocument pdfDoc = new PdfDocument(writer);
                    Document document = new Document(pdfDoc);

                    // Add a title to the PDF
                    Paragraph title = new Paragraph("Sales Report")
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                        .SetFontSize(18);
                    document.Add(title);

                    // Add filter details (if any)
                    StringBuilder filterDetails = new StringBuilder("Filters Applied:\n");
                    if (comboCustomerFilter.SelectedIndex != -1)
                        filterDetails.AppendLine($"Customer: {comboCustomerFilter.Text}");
                    if (comboStaffFilter.SelectedIndex != -1)
                        filterDetails.AppendLine($"Staff: {comboStaffFilter.Text}");
                    if (dateTimePickerFrom.Checked)
                        filterDetails.AppendLine($"From Date: {dateTimePickerFrom.Value.ToShortDateString()}");
                    if (dateTimePickerTo.Checked)
                        filterDetails.AppendLine($"To Date: {dateTimePickerTo.Value.ToShortDateString()}");

                    document.Add(new Paragraph(filterDetails.ToString()).SetFontSize(10).SetMarginBottom(10));

                    // Add a blank line
                    document.Add(new Paragraph("\n"));

                    // Create a table with the same number of columns as the DataGridView
                    int columnCount = dgv_sales.Columns.Count;
                    Table table = new Table(columnCount).UseAllAvailableWidth();

                    // Add headers to the table
                    foreach (DataGridViewColumn column in dgv_sales.Columns)
                    {
                        Cell headerCell = new Cell().Add(new Paragraph(column.HeaderText))
                            .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                        table.AddHeaderCell(headerCell);
                    }

                    // Add rows to the table
                    foreach (DataGridViewRow row in dgv_sales.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            string cellValue = cell.Value?.ToString() ?? "";
                            Cell dataCell = new Cell().Add(new Paragraph(cellValue))
                                .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);
                            table.AddCell(dataCell);
                        }
                    }

                    // Add the table to the document
                    document.Add(table);

                    // Close the document
                    document.Close();
                }

                MessageBox.Show($"Report exported successfully to {filePath}", "Export Successful");
            }
            catch (iText.IO.Exceptions.IOException ioEx) // Catch iText-specific IOException
            {
                MessageBox.Show($"IO Error while exporting the report: {ioEx.Message}", "Export Failed");
            }
            catch (iText.Kernel.Exceptions.PdfException pdfEx) // Catch iText-specific PdfException
            {
                MessageBox.Show($"PDF Error while exporting the report: {pdfEx.Message}", "Export Failed");
            }
            catch (Exception ex) // Catch all other exceptions
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Export Failed");
            }
        }

        private void dgv_sales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_sales.Rows.Count == 0)
            {
                MessageBox.Show("No data available to export.", "Export Failed");
                return;
            }
        }
    }
}
