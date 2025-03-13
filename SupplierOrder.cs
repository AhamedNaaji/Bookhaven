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
    public partial class SupplierOrder : Form
    {
        cls_suporder clssuporder = new cls_suporder();
        filloperation fill = new filloperation();
        public SupplierOrder()
        {
            InitializeComponent();
            FirstRun();
        }

        void FirstRun()
        {
            // Clear form fields
            cmb_Suporder.SelectedIndex = -1;
            cmb_book_suporder.SelectedIndex = -1;
            lbl_Quantity_suporder.Text = "0";
            lbl_Status_suporder.Text = "Pending";
            lbl_exp_amount.Text = "0.0";
            lbl_Finalamount.Text = "0.0";

            // Populate cmb_Suporder (Suppliers)
            string supplierQuery = "SELECT Supplier_Id, Supplier_Name FROM Supplier";
            fill.combobox(supplierQuery, cmb_Suporder, "Supplier_Name", "Supplier_Id");

            // Populate cmb_book_suporder (Books)
            string bookQuery = "SELECT Book_Id, Book_Name FROM Book";
            fill.combobox(bookQuery, cmb_book_suporder, "Book_Name", "Book_Id");

            // Populate dgv_suporder (Supplier Orders)
            string orderQuery = @"
                SELECT 
                    so.supOrder_Id,
                    s.Supplier_Name AS Supplier,
                    b.Book_Name AS Book,
                    sod.Quantity,
                    os.status AS Status,
                    sod.Discount,
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
            dgv_suporder.Columns[5].HeaderText = "Discount";
            dgv_suporder.Columns[6].HeaderText = "Final Amount";

        }

        private void cmb_Suporder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Suporder.SelectedIndex != -1)
            {
                int supplierId = Convert.ToInt32(cmb_Suporder.SelectedValue);
                // You can fetch additional supplier details here if needed
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
                if (cmb_Suporder.SelectedIndex == -1 || cmb_book_suporder.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a supplier and a book.", "Validation Error");
                    return;
                }

                int quantity = int.Parse(lbl_Quantity_suporder.Text);
                if (quantity <= 0)
                {
                    MessageBox.Show("Quantity must be greater than zero.", "Validation Error");
                    return;
                }

                // Assign properties
                clssuporder.Staff_Id_fk = 1; // Assuming the logged-in staff ID is 1
                clssuporder.Supplier_Id_fk = Convert.ToInt32(cmb_Suporder.SelectedValue);
                clssuporder.Book_Id_fk = Convert.ToInt32(cmb_book_suporder.SelectedValue);
                clssuporder.Date = DateTime.Now;
                clssuporder.Status_Id_fk = 1; // Assuming status 1 = "Pending"
                clssuporder.Total_Payment = float.Parse(lbl_Finalamount.Text);

                // Add order details
                clssuporder.OrderDetails.Add(new cls_suporder.SupOrderDetail
                {
                    Book_Id_fk = Convert.ToInt32(cmb_book_suporder.SelectedValue),
                    Quantity = quantity,
                    Discount = float.Parse(lbl_exp_amount.Text),
                    Final_Amount = float.Parse(lbl_Finalamount.Text)
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
                // Validate inputs
                if (clssuporder.supOrder_Id <= 0)
                {
                    MessageBox.Show("Please select an order to update.", "Validation Error");
                    return;
                }

                if (cmb_Suporder.SelectedIndex == -1 || cmb_book_suporder.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a supplier and a book.", "Validation Error");
                    return;
                }

                int quantity = int.Parse(lbl_Quantity_suporder.Text);
                if (quantity <= 0)
                {
                    MessageBox.Show("Quantity must be greater than zero.", "Validation Error");
                    return;
                }

                // Assign properties
                clssuporder.Staff_Id_fk = 1; // Assuming the logged-in staff ID is 1
                clssuporder.Supplier_Id_fk = Convert.ToInt32(cmb_Suporder.SelectedValue);
                clssuporder.Book_Id_fk = Convert.ToInt32(cmb_book_suporder.SelectedValue);
                clssuporder.Date = DateTime.Now;
                clssuporder.Status_Id_fk = 1; // Assuming status 1 = "Pending"
                clssuporder.Total_Payment = float.Parse(lbl_Finalamount.Text);

                // Update order details
                clssuporder.OrderDetails.Clear();
                clssuporder.OrderDetails.Add(new cls_suporder.SupOrderDetail
                {
                    Book_Id_fk = Convert.ToInt32(cmb_book_suporder.SelectedValue),
                    Quantity = quantity,
                    Discount = float.Parse(lbl_exp_amount.Text),
                    Final_Amount = float.Parse(lbl_Finalamount.Text)
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
                    lbl_Quantity_suporder.Text = clssuporder.OrderDetails[0].Quantity.ToString();
                    lbl_exp_amount.Text = clssuporder.OrderDetails[0].Discount.ToString();
                    lbl_Finalamount.Text = clssuporder.OrderDetails[0].Final_Amount.ToString();
                    lbl_Status_suporder.Text = "Pending"; // Update based on actual status
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Fetch Failed");
                }
            }
        }
    }
}
