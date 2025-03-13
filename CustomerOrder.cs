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
    public partial class CustomerOrder : Form
    {
        cls_cusorder clscusorder = new cls_cusorder();
        filloperation fill = new filloperation();
        public CustomerOrder()
        {
            InitializeComponent();
            FirstRun();

        }

        void FirstRun()
        {
            // Clear form fields
            cmb_customer.SelectedIndex = -1;
            cmb_Book.SelectedIndex = -1;
            lbl_Qty_cusorder.Text = "0";
            lbl_Supplier_Cusorder.Text = "";
            lbl_Processing_Cusorder.Text = "Pending";
            lbl_Totalamount.Text = "0.0";
            lbl_Deliverymethod_Cusorder.Text = "";
            lbl_Discount_Cusorder.Text = "0.0";
            lbl_Finalpayment_Cusorder.Text = "0.0";

            // Populate cmb_customer (Customers)
            string customerQuery = "SELECT Customer_Id, Customer_Name FROM Customer";
            fill.combobox(customerQuery, cmb_customer, "Customer_Name", "Customer_Id");

            // Populate cmb_Book (Books)
            string bookQuery = "SELECT Book_Id, Book_Name FROM Book";
            fill.combobox(bookQuery, cmb_Book, "Book_Name", "Book_Id");

            // Populate dgv_cusOrder (Customer Orders)
            string orderQuery = @"
                SELECT 
                    co.CustOrder_Id,
                    c.Customer_Name AS Customer,
                    b.Book_Name AS Book,
                    cod.Quantity,
                    cod.DeliveryMethod,
                    cod.Discount,
                    cod.Final_Amount,
                    os.status AS Status
                FROM CusOrder co
                INNER JOIN Customer c ON co.Customer_Id_fk = c.Customer_Id
                INNER JOIN CusOrderDetails cod ON co.CustOrder_Id = cod.CustOrder_Id_fk
                INNER JOIN Book b ON cod.Book_Id_fk = b.Book_Id
                INNER JOIN orderStatus os ON co.Status_Id_fk = os.statusId";

            fill.FillDataGridView(orderQuery, dgv_cusOrder);
            dgv_cusOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Rename columns for clarity
            dgv_cusOrder.Columns[0].HeaderText = "Order ID";
            dgv_cusOrder.Columns[1].HeaderText = "Customer";
            dgv_cusOrder.Columns[2].HeaderText = "Book";
            dgv_cusOrder.Columns[3].HeaderText = "Quantity";
            dgv_cusOrder.Columns[4].HeaderText = "Delivery Method";
            dgv_cusOrder.Columns[5].HeaderText = "Discount";
            dgv_cusOrder.Columns[6].HeaderText = "Final Amount";
            dgv_cusOrder.Columns[7].HeaderText = "Status";
        }


        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_cusOrder_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Get selected order ID
                    int orderId = Convert.ToInt32(dgv_cusOrder.Rows[e.RowIndex].Cells["CustOrder_Id"].Value);

                    // Load order data
                    clscusorder.CustOrder_Id = orderId;
                    clscusorder.Getdata();

                    // Populate form fields
                    cmb_customer.SelectedValue = clscusorder.Customer_Id_fk;
                    cmb_Book.SelectedValue = clscusorder.OrderDetails[0].Book_Id_fk;
                    lbl_Qty_cusorder.Text = clscusorder.OrderDetails[0].Quantity.ToString();
                    lbl_Deliverymethod_Cusorder.Text = clscusorder.OrderDetails[0].DeliveryMethod;
                    lbl_Discount_Cusorder.Text = clscusorder.OrderDetails[0].Discount.ToString();
                    lbl_Finalpayment_Cusorder.Text = clscusorder.OrderDetails[0].Final_Amount.ToString();
                    lbl_Totalamount.Text = clscusorder.Total_Payment.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Fetch Failed");
                }
            }
        }

        private void btn_makeorder_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (cmb_customer.SelectedIndex == -1 || cmb_Book.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a customer and a book.", "Validation Error");
                    return;
                }

                int quantity = int.Parse(lbl_Qty_cusorder.Text);
                if (quantity <= 0)
                {
                    MessageBox.Show("Quantity must be greater than zero.", "Validation Error");
                    return;
                }

                // Assign properties
                clscusorder.Staff_Id_fk = 1; // Assuming the logged-in staff ID is 1
                clscusorder.Customer_Id_fk = Convert.ToInt32(cmb_customer.SelectedValue);
                clscusorder.Date = DateTime.Now;
                clscusorder.Status_Id_fk = 1; // Assuming status 1 = "Pending"
                clscusorder.Total_Payment = float.Parse(lbl_Finalpayment_Cusorder.Text);

                // Add order details
                clscusorder.OrderDetails.Add(new cls_cusorder.CusOrderDetail
                {
                    Book_Id_fk = Convert.ToInt32(cmb_Book.SelectedValue),
                    Quantity = quantity,
                    DeliveryMethod = lbl_Deliverymethod_Cusorder.Text,
                    Discount = float.Parse(lbl_Discount_Cusorder.Text),
                    Final_Amount = float.Parse(lbl_Finalpayment_Cusorder.Text)
                });

                // Insert data
                clscusorder.Insertdata();
                FirstRun(); // Refresh the form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Insert Failed");
            }

        }

        private void cmb_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_customer.SelectedIndex != -1)
            {
                int customerId = Convert.ToInt32(cmb_customer.SelectedValue);
                // You can fetch additional customer details here if needed
            }
        }

        private void cmb_Book_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Book.SelectedIndex != -1)
            {
                int bookId = Convert.ToInt32(cmb_Book.SelectedValue);
                // Fetch book details like price, stock, etc., if needed
            }
        }

        private void btn_updateorder_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (clscusorder.CustOrder_Id <= 0)
                {
                    MessageBox.Show("Please select an order to update.", "Validation Error");
                    return;
                }

                if (cmb_customer.SelectedIndex == -1 || cmb_Book.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a customer and a book.", "Validation Error");
                    return;
                }

                int quantity = int.Parse(lbl_Qty_cusorder.Text);
                if (quantity <= 0)
                {
                    MessageBox.Show("Quantity must be greater than zero.", "Validation Error");
                    return;
                }

                // Assign properties
                clscusorder.Staff_Id_fk = 1; // Assuming the logged-in staff ID is 1
                clscusorder.Customer_Id_fk = Convert.ToInt32(cmb_customer.SelectedValue);
                clscusorder.Date = DateTime.Now;
                clscusorder.Status_Id_fk = 1; // Assuming status 1 = "Pending"
                clscusorder.Total_Payment = float.Parse(lbl_Finalpayment_Cusorder.Text);

                // Update order details
                clscusorder.OrderDetails.Clear();
                clscusorder.OrderDetails.Add(new cls_cusorder.CusOrderDetail
                {
                    Book_Id_fk = Convert.ToInt32(cmb_Book.SelectedValue),
                    Quantity = quantity,
                    DeliveryMethod = lbl_Deliverymethod_Cusorder.Text,
                    Discount = float.Parse(lbl_Discount_Cusorder.Text),
                    Final_Amount = float.Parse(lbl_Finalpayment_Cusorder.Text)
                });

                // Update data
                clscusorder.UpdateData();
                FirstRun(); // Refresh the form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Update Failed");
            }
        }

        private void btn_deleteorder_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate selection
                if (clscusorder.CustOrder_Id <= 0)
                {
                    MessageBox.Show("Please select an order to delete.", "Validation Error");
                    return;
                }

                // Delete data
                clscusorder.DeleteData();
                FirstRun(); // Refresh the form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Delete Failed");
            }
        }
    }
}
