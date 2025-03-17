using Bookhaven.AppClasses;
using Bookhaven.CommonClasses;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookhaven
{
    public partial class Clerk_CustomerOrder : Form
    {
        cls_CusOrder clscusorder = new cls_CusOrder();

        filloperation fill = new filloperation();

        private int _staffId;
        public Clerk_CustomerOrder(int staffId)
        {
            InitializeComponent();
            nup_Quantity.ValueChanged += nup_Quantity_ValueChanged;
            FirstRun();
            _staffId = staffId;
        }

        private void cmb_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Book.SelectedIndex != -1)
            {
                nup_Quantity_ValueChanged(sender, e); // Recalculate prices when a new book is selected
            }

        }
        void FirstRun()
        {
            // Clear form fields
            cmb_customer.SelectedIndex = -1;
            cmb_Book.SelectedIndex = -1;
            nup_Quantity.Value = 1; // Default quantity
            cmb_Status.SelectedIndex = -1; // Default status (combobox)
            lbl_Totalamount.Text = "0.0";
            cmb_Deliverymethod.SelectedIndex = -1;
            lbl_Discount_Cusorder.Text = "0.0";
            lbl_Finalpayment_Cusorder.Text = "0.0";

            // Populate combo boxes
            string customerQuery = "SELECT Customer_Id, Customer_Name FROM Customer";
            fill.combobox(customerQuery, cmb_customer, "Customer_Name", "Customer_Id");

            string bookQuery = "SELECT Book_Id, Book_Name FROM Book";
            fill.combobox(bookQuery, cmb_Book, "Book_Name", "Book_Id");

            string supplierQuery = "SELECT Supplier_Id, Supplier_Name FROM Supplier";
            fill.combobox(supplierQuery, cmb_Suporder, "Supplier_Name", "Supplier_Id");

            string deliveryQuery = "SELECT DISTINCT DeliveryMethod FROM CusOrderDetails";
            fill.combobox(deliveryQuery, cmb_Deliverymethod, "DeliveryMethod", "DeliveryMethod");

            string statusQuery = "SELECT statusId, status FROM orderStatus"; // Populate cmb_Status
            fill.combobox(statusQuery, cmb_Status, "status", "statusId");


            // Populate DataGridView with existing orders
            string orderQuery = @"
    SELECT 
        co.CustOrder_Id,
        c.Customer_Name AS Customer,
        b.Book_Name AS Book,
        cod.Quantity,
        cod.DeliveryMethod,
        cod.Discount,
        cod.Final_Amount,
        os.status AS Status,
        s.Supplier_Name AS Supplier -- Include supplier name
    FROM CusOrder co
    INNER JOIN Customer c ON co.Customer_Id_fk = c.Customer_Id
    INNER JOIN CusOrderDetails cod ON co.CustOrder_Id = cod.CustOrder_Id_fk
    INNER JOIN Book b ON cod.Book_Id_fk = b.Book_Id
    INNER JOIN orderStatus os ON co.Status_Id_fk = os.statusId
    LEFT JOIN Supplier s ON co.Supplier_Id_fk = s.Supplier_Id"; // Join with Supplier table

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
            dgv_cusOrder.Columns[8].HeaderText = "Supplier"; // Add supplier column
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
                    nup_Quantity.Value = clscusorder.OrderDetails[0].Quantity;
                    cmb_Deliverymethod.Text = clscusorder.OrderDetails[0].DeliveryMethod;
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
                    MessageBox.Show("Please fill all required fields.", "Validation Error");
                    return;
                }

                int quantity = (int)nup_Quantity.Value; // Get quantity from NumericUpDown
                if (quantity <= 0)
                {
                    MessageBox.Show("Quantity must be greater than zero.", "Validation Error");
                    return;
                }

                // Validate and parse total payment
                if (!float.TryParse(lbl_Finalpayment_Cusorder.Text, out float totalPayment))
                {
                    MessageBox.Show("Invalid total payment value.", "Validation Error");
                    return;
                }

                // Validate and parse discount
                string discountText = lbl_Discount_Cusorder.Text.Replace("%", "").Trim(); // Remove '%' and trim whitespace
                if (!float.TryParse(discountText, out float discount))
                {
                    MessageBox.Show("Invalid discount value.", "Validation Error");
                    return;
                }

                // Assign properties
                clscusorder.Staff_Id_fk = _staffId;
                clscusorder.Customer_Id_fk = Convert.ToInt32(cmb_customer.SelectedValue);
                clscusorder.Date = DateTime.Now;
                clscusorder.Status_Id_fk = Convert.ToInt32(cmb_Status.SelectedValue); // Use selected status
                clscusorder.Total_Payment = totalPayment;
                clscusorder.Supplier_Id_fk = Convert.ToInt32(cmb_Suporder.SelectedValue);

                // Add order details
                clscusorder.OrderDetails.Add(new cls_CusOrder.CusOrderDetail
                {
                    Book_Id_fk = Convert.ToInt32(cmb_Book.SelectedValue),
                    Quantity = quantity,
                    DeliveryMethod = cmb_Deliverymethod.Text,
                    Discount = discount,
                    Final_Amount = totalPayment
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

        private void cmb_Book_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Book.SelectedIndex != -1)
            {
                nup_Quantity_ValueChanged(sender, e); // Recalculate prices when a new book is selected
            }
        }

        private void btn_updateorder_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate selection
                if (clscusorder.CustOrder_Id <= 0)
                {
                    MessageBox.Show("Please select an order to update.", "Validation Error");
                    return;
                }

                // Validate inputs
                if (cmb_customer.SelectedIndex == -1 || cmb_Book.SelectedIndex == -1)
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

                // Validate and parse total payment
                if (!float.TryParse(lbl_Finalpayment_Cusorder.Text, out float totalPayment))
                {
                    MessageBox.Show("Invalid total payment value.", "Validation Error");
                    return;
                }

                // Validate and parse discount
                string discountText = lbl_Discount_Cusorder.Text.Replace("%", "").Trim(); // Remove '%' and trim whitespace
                if (!float.TryParse(discountText, out float discount))
                {
                    MessageBox.Show("Invalid discount value.", "Validation Error");
                    return;
                }

                // Assign properties

                clscusorder.Staff_Id_fk = _staffId;
                clscusorder.Customer_Id_fk = Convert.ToInt32(cmb_customer.SelectedValue);
                clscusorder.Date = DateTime.Now;
                clscusorder.Status_Id_fk = Convert.ToInt32(cmb_Status.SelectedValue); // Use selected status
                clscusorder.Total_Payment = totalPayment;
                clscusorder.Supplier_Id_fk = Convert.ToInt32(cmb_Suporder.SelectedValue);

                // Update order details
                clscusorder.OrderDetails.Clear();
                clscusorder.OrderDetails.Add(new cls_CusOrder.CusOrderDetail
                {
                    Book_Id_fk = Convert.ToInt32(cmb_Book.SelectedValue),
                    Quantity = quantity,
                    DeliveryMethod = cmb_Deliverymethod.Text,
                    Discount = discount,
                    Final_Amount = totalPayment
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

        private void cmb_Suporder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Suporder.SelectedIndex != -1)
            {
                int supplierId = Convert.ToInt32(cmb_Suporder.SelectedValue);
                // You can fetch additional supplier details here if needed
            }
        }
        private float GetBookPrice()
        {
            try
            {
                int bookId = Convert.ToInt32(cmb_Book.SelectedValue);

                string query = "SELECT Price FROM Book WHERE Book_Id = @Book_Id";
                SqlCommand cmd = new SqlCommand(query, clscusorder.Connection); // Use the public property
                cmd.Parameters.AddWithValue("@Book_Id", bookId);

                clscusorder.Connection.Open();
                object result = cmd.ExecuteScalar();
                clscusorder.Connection.Close();

                return result != null ? Convert.ToSingle(result) : 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching book price: {ex.Message}");
            }
        }

        private float GetBookDiscount()
        {
            try
            {
                int bookId = Convert.ToInt32(cmb_Book.SelectedValue);

                string query = "SELECT Discount FROM Book WHERE Book_Id = @Book_Id";
                SqlCommand cmd = new SqlCommand(query, clscusorder.Connection); // Use the public property
                cmd.Parameters.AddWithValue("@Book_Id", bookId);

                clscusorder.Connection.Open();
                object result = cmd.ExecuteScalar();
                clscusorder.Connection.Close();

                return result != null ? Convert.ToSingle(result) : 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching book discount: {ex.Message}");
            }
        }

        private void nup_Quantity_ValueChanged(object sender, EventArgs e)
        {
            // Ensure a valid book is selected
            if (cmb_Book.SelectedValue == null || cmb_Book.SelectedValue.ToString() == "")
            {
                lbl_Totalamount.Text = "0.00";
                lbl_Discount_Cusorder.Text = "0%";
                lbl_Finalpayment_Cusorder.Text = "0.00";
                return;
            }

            try
            {
                // Fetch the price and discount for the selected book
                float price = GetBookPrice();
                float discount = GetBookDiscount();

                // Calculate total amount based on the current quantity
                int quantity = (int)nup_Quantity.Value; // Get the current quantity from NumericUpDown
                float totalAmount = price * quantity;

                // Calculate final payment after applying the discount
                float finalPayment = totalAmount - (totalAmount * (discount / 100));

                // Update the labels dynamically
                lbl_Totalamount.Text = totalAmount.ToString("0.00");
                lbl_Discount_Cusorder.Text = $"{discount}%";
                lbl_Finalpayment_Cusorder.Text = finalPayment.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }

        private void btn_Cusorder_Click(object sender, EventArgs e)
        {
            Clerk_CustomerOrder clerk_CustomerOrder = new Clerk_CustomerOrder(_staffId);
            ShowDialog(clerk_CustomerOrder);
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(_staffId);
            customer.ShowDialog();
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales(_staffId);
            sales.ShowDialog();
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            Book book = new Book(_staffId);
            book.ShowDialog();
        }
    }
}
