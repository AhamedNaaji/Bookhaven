using Bookhaven.AppClasses;
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
    public partial class SupplierOrder : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=AFRIDI;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");
        cls_suporder clssuporder = new cls_suporder();
        filloperation fill = new filloperation();
        public SupplierOrder()
        {
            InitializeComponent();
            // Attach event handlers
            nup_Quantity.ValueChanged += nup_Quantity_ValueChanged;
            cmb_book_suporder.SelectedIndexChanged += cmb_book_suporder_SelectedIndexChanged;

            FirstRun();
            FirstRun();
        }

        void FirstRun()
        {
            // Clear form fields
            cmb_Suporder.SelectedIndex = -1;
            cmb_book_suporder.SelectedIndex = -1;
            nup_Quantity.Value = 1; // Default quantity
            cmb_Status.SelectedIndex = -1;
            lbl_expectedamount.Text = "0.0";
            lbl_Finalamount.Text = "0.0";

            // Populate combo boxes
            string supplierQuery = "SELECT Supplier_Id, Supplier_Name FROM Supplier";
            fill.combobox(supplierQuery, cmb_Suporder, "Supplier_Name", "Supplier_Id");

            string bookQuery = "SELECT Book_Id, Book_Name FROM Book";
            fill.combobox(bookQuery, cmb_book_suporder, "Book_Name", "Book_Id");

            string statusQuery = "SELECT statusId, status FROM orderStatus";
            fill.combobox(statusQuery, cmb_Status, "status", "statusId");

            string staffQuery = "SELECT Staff_Id, Staff_Name FROM Staff";
            fill.combobox(staffQuery, cmb_staff, "Staff_Name", "Staff_Id");

            // Populate dgv_suporder with existing orders
            string orderQuery = @"
                SELECT 
                    so.supOrder_Id,
                    s.Supplier_Name AS Supplier,
                    b.Book_Name AS Book,
                    sod.Quantity,
                    os.status AS Status,
                    sod.Final_Amount
                FROM supOrder so
                INNER JOIN Supplier s ON so.Supplier_Id_fk = s.Supplier_Id
                INNER JOIN supOrderDetails sod ON so.supOrder_Id = sod.supOrder_Id_fk
                INNER JOIN Book b ON sod.Book_Id_fk = b.Book_Id
                INNER JOIN orderStatus os ON so.Status_Id_fk = os.statusId";

            fill.FillDataGridView(orderQuery, dgv_suporder);
            dgv_suporder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Rename columns for clarity
            dgv_suporder.Columns[0].HeaderText = "Order ID";
            dgv_suporder.Columns[1].HeaderText = "Supplier";
            dgv_suporder.Columns[2].HeaderText = "Book";
            dgv_suporder.Columns[3].HeaderText = "Quantity";
            dgv_suporder.Columns[4].HeaderText = "Status";
            dgv_suporder.Columns[5].HeaderText = "Final Amount";
        }

        private void cmb_Suporder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_book_suporder.SelectedIndex != -1)
            {
                try
                {
                    int bookId = Convert.ToInt32(cmb_book_suporder.SelectedValue);

                    // Fetch book price from the database
                    float price = GetBookPrice(bookId);

                    // Calculate expected amount (price less 20%)
                    float expectedAmount = price - (price * 0.2f);

                    // Update labels
                    lbl_expectedamount.Text = expectedAmount.ToString("0.00");

                    // Recalculate final payment
                    nup_Quantity_ValueChanged(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Fetch Failed");
                }
            }
        }

        private void cmb_book_suporder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_book_suporder.SelectedIndex != -1)
            {
                int bookId = Convert.ToInt32(cmb_book_suporder.SelectedValue);
                // Fetch book details like price, stock, etc., if needed
            }
        }

        private void btn_makeOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (cmb_Suporder.SelectedIndex == -1 || cmb_book_suporder.SelectedIndex == -1 || cmb_staff.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill all required fields.", "Validation Error");
                    return;
                }

                int quantity = (int)nup_Quantity.Value;
                if (quantity <= 0)
                {
                    MessageBox.Show("Quantity must be greater than zero.", "Validation Error");
                    return;
                }

                // Validate and parse final payment
                if (!float.TryParse(lbl_Finalamount.Text, out float finalPayment))
                {
                    MessageBox.Show("Invalid final payment value.", "Validation Error");
                    return;
                }

                // Assign properties
                clssuporder.Staff_Id_fk = Convert.ToInt32(cmb_staff.SelectedValue);
                clssuporder.Supplier_Id_fk = Convert.ToInt32(cmb_Suporder.SelectedValue);
                clssuporder.Book_Id_fk = Convert.ToInt32(cmb_book_suporder.SelectedValue);
                clssuporder.Date = dtp_supplier.Value;
                clssuporder.Status_Id_fk = Convert.ToInt32(cmb_Status.SelectedValue);
                clssuporder.Total_Payment = finalPayment;

                // Add order details
                clssuporder.OrderDetails.Add(new cls_suporder.SupOrderDetail
                {
                    Book_Id_fk = Convert.ToInt32(cmb_book_suporder.SelectedValue),
                    Quantity = quantity,
                    Final_Amount = finalPayment
                });

                // Insert data
                clssuporder.Insertdata();
                FirstRun(); // Refresh the form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Insert Failed");
            }

        }

        private void btn_updateorder_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate selection
                if (clssuporder.supOrder_Id <= 0)
                {
                    MessageBox.Show("Please select an order to update.", "Validation Error");
                    return;
                }

                // Validate inputs
                if (cmb_Suporder.SelectedIndex == -1 || cmb_book_suporder.SelectedIndex == -1 || cmb_staff.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill all required fields.", "Validation Error");
                    return;
                }

                int quantity = (int)nup_Quantity.Value;
                if (quantity <= 0)
                {
                    MessageBox.Show("Quantity must be greater than zero.", "Validation Error");
                    return;
                }

                // Validate and parse final payment
                if (!float.TryParse(lbl_Finalamount.Text, out float finalPayment))
                {
                    MessageBox.Show("Invalid final payment value.", "Validation Error");
                    return;
                }

                // Assign properties
                clssuporder.Staff_Id_fk = Convert.ToInt32(cmb_staff.SelectedValue);
                clssuporder.Supplier_Id_fk = Convert.ToInt32(cmb_Suporder.SelectedValue);
                clssuporder.Book_Id_fk = Convert.ToInt32(cmb_book_suporder.SelectedValue);
                clssuporder.Date = dtp_supplier.Value;
                clssuporder.Status_Id_fk = Convert.ToInt32(cmb_Status.SelectedValue);
                clssuporder.Total_Payment = finalPayment;

                // Update order details
                clssuporder.OrderDetails.Clear();
                clssuporder.OrderDetails.Add(new cls_suporder.SupOrderDetail
                {
                    Book_Id_fk = Convert.ToInt32(cmb_book_suporder.SelectedValue),
                    Quantity = quantity,
                    Final_Amount = finalPayment
                });

                // Update data
                clssuporder.UpdateData();
                FirstRun(); // Refresh the form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Update Failed");
            }
        }

        private void btn_deleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate selection
                if (clssuporder.supOrder_Id <= 0)
                {
                    MessageBox.Show("Please select an order to delete.", "Validation Error");
                    return;
                }

                // Delete data
                clssuporder.DeleteData();
                FirstRun(); // Refresh the form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Delete Failed");
            }
        }
        private float GetBookPrice(int bookId)
        {
            try
            {

                string query = "SELECT Price FROM Book WHERE Book_Id = @Book_Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Book_Id", bookId);

                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();

                return result != null ? Convert.ToSingle(result) : 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching book price: {ex.Message}");
            }
        }

        private void dgv_suporder_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Get selected order ID
                    int orderId = Convert.ToInt32(dgv_suporder.Rows[e.RowIndex].Cells["supOrder_Id"].Value);

                    // Load order data
                    clssuporder.supOrder_Id = orderId;
                    clssuporder.Getdata();

                    // Populate form fields
                    cmb_Suporder.SelectedValue = clssuporder.Supplier_Id_fk;
                    cmb_book_suporder.SelectedValue = clssuporder.Book_Id_fk;
                    nup_Quantity.Value = clssuporder.OrderDetails[0].Quantity;
                    cmb_staff.SelectedValue = clssuporder.Staff_Id_fk;
                    dtp_supplier.Value = clssuporder.Date;
                    cmb_Status.SelectedValue = clssuporder.Status_Id_fk;
                    lbl_expectedamount.Text = (clssuporder.OrderDetails[0].Final_Amount / clssuporder.OrderDetails[0].Quantity).ToString("0.00");
                    lbl_Finalamount.Text = clssuporder.OrderDetails[0].Final_Amount.ToString("0.00");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Fetch Failed");
                }
            }
        
        }

        private void nup_Quantity_ValueChanged(object sender, EventArgs e)
        {
            // Ensure a valid book is selected
            if (cmb_book_suporder.SelectedIndex == -1 || lbl_expectedamount.Text == "0.0")
            {
                lbl_Finalamount.Text = "0.00";
                return;
            }

            try
            {
                // Parse expected amount
                float expectedAmount = float.Parse(lbl_expectedamount.Text);

                // Calculate final payment
                int quantity = (int)nup_Quantity.Value;
                float finalPayment = expectedAmount * quantity;

                // Update label
                lbl_Finalamount.Text = finalPayment.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Calculation Failed");
            }
        }

        private void dgv_suporder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
