using Bookhaven.AppClasses;
using Bookhaven.CommonClasses;
using System;
using System.Windows.Forms;

namespace Bookhaven
{
    public partial class Suppliers : Form
    {
        cls_Supplier clssup = new cls_Supplier();
        filloperation fill = new filloperation();
        private int _staffId;

        public Suppliers(int staffId)
        {
            _staffId = staffId;
            InitializeComponent();
        }

        void FirstRun()
        {
            // Clear form fields
            txtbox_Suppliername.Text = "";
            txtbox_NIC.Text = "";
            txtbox_Address.Text = "";
            txtbox_Email.Text = "";
            txtbox_Contact1.Text = "";
            txtbox_Contact2.Text = "";

            // Updated query to include mobile numbers
            string query = @"
        SELECT 
            c.Supplier_Id,
            c.Supplier_Name,
            c.NIC,
           
            c.Address,
            c.Email,
            MAX(CASE WHEN cm.RowNum = 1 THEN cm.SupMobNumber END) AS Mobile1,
            MAX(CASE WHEN cm.RowNum = 2 THEN cm.SupMobNumber END) AS Mobile2
        FROM Supplier c
        LEFT JOIN (
            SELECT 
                Supplier_Id_fk,
                SupMobNumber,
                ROW_NUMBER() OVER (PARTITION BY Supplier_Id_fk ORDER BY SupplierMobile_Id) AS RowNum
            FROM SupplierMobile
        ) cm ON c.Supplier_Id = cm.Supplier_Id_fk
        GROUP BY 
            c.Supplier_Id,
            c.Supplier_Name,
            c.NIC,
       
            c.Address,
            c.Email";

            // Populate DataGridView
            fill.FillDataGridView(query, dgv_Sup);
            dgv_Sup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Rename columns
            dgv_Sup.Columns[0].HeaderText = "ID";
            dgv_Sup.Columns[1].HeaderText = "Name";
            dgv_Sup.Columns[2].HeaderText = "NIC";

            dgv_Sup.Columns[3].HeaderText = "Address";
            dgv_Sup.Columns[4].HeaderText = "Email";
            dgv_Sup.Columns[5].HeaderText = "Mobile 1";
            dgv_Sup.Columns[6].HeaderText = "Mobile 2";
        }
        private void txtbox_Suppliername_TextChanged(object sender, EventArgs e)
        {
            clssup.Supplier_Name = txtbox_Suppliername.Text.Trim();
        }

        private void dgv_sup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get selected customer ID
                int Supplier_Id = Convert.ToInt32(dgv_Sup.Rows[e.RowIndex].Cells["Supplier_Id"].Value);

                // Load customer data
                clssup.Supplier_Id = Supplier_Id;
                clssup.Getdata();

                // Populate form fields
                txtbox_Suppliername.Text = clssup.Supplier_Name;
                txtbox_NIC.Text = clssup.NIC;

                txtbox_Address.Text = clssup.Address;
                txtbox_Email.Text = clssup.Email;

                // Populate mobile numbers (handle up to 2 numbers)
                txtbox_Contact1.Text = clssup.supMobNumbers.Count > 0 ? clssup.supMobNumbers[0] : "";
                txtbox_Contact2.Text = clssup.supMobNumbers.Count > 1 ? clssup.supMobNumbers[1] : "";
            }
        }

        private void txtbox_NIC_TextChanged(object sender, EventArgs e)
        {
            clssup.NIC = txtbox_NIC.Text.Trim();
        }

        private void txtbox_Address_TextChanged(object sender, EventArgs e)
        {
            clssup.Address = txtbox_Address.Text.Trim();
        }

        private void txtbox_Contact1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_Email_TextChanged(object sender, EventArgs e)
        {
            clssup.Email = txtbox_Email.Text.Trim();
        }

        private void btn_addSupplier_Click(object sender, EventArgs e)
        {
            // Clear previous entries
            clssup.supMobNumbers.Clear();

            // Add both numbers to the list (trim and validate)
            if (!string.IsNullOrEmpty(txtbox_Contact1.Text))
                clssup.supMobNumbers.Add(txtbox_Contact1.Text.Trim());

            if (!string.IsNullOrEmpty(txtbox_Contact2.Text))
                clssup.supMobNumbers.Add(txtbox_Contact2.Text.Trim());

            clssup.Insertdata();
            Suppliers_Load(sender, e);

        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            FirstRun();
        }

        private void btn_updateSupplier_Click(object sender, EventArgs e)
        {
            clssup.Supplier_Name = txtbox_Suppliername.Text.Trim();
            clssup.NIC = txtbox_NIC.Text.Trim();

            clssup.Address = txtbox_Address.Text.Trim();
            clssup.Email = txtbox_Email.Text.Trim();

            // Update mobile numbers
            clssup.supMobNumbers.Clear();
            if (!string.IsNullOrEmpty(txtbox_Contact1.Text))
                clssup.supMobNumbers.Add(txtbox_Contact1.Text.Trim());
            if (!string.IsNullOrEmpty(txtbox_Contact2.Text))
                clssup.supMobNumbers.Add(txtbox_Contact2.Text.Trim());
            clssup.UpdateData();
            Suppliers_Load(sender, e);
        }

        private void btn_deleteSupplier_Click(object sender, EventArgs e)
        {
            if (dgv_Sup.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(dgv_Sup.SelectedRows[0].Cells["Customer_Id"].Value);
                clssup.Supplier_Id = customerId;
                clssup.DeleteDate();
            }
            else
            {
                MessageBox.Show("Please select a supplier to delete.", "No Selection");
            }
            clssup.DeleteDate();
            Suppliers_Load(sender, e);
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

        private void btn_Cusorder_Click(object sender, EventArgs e)
        {
            CustomerOrder customerOrder = new CustomerOrder(_staffId); customerOrder.ShowDialog();
        }

        private void btn_Supporder_Click(object sender, EventArgs e)
        {
            SupplierOrder supplierOrder = new SupplierOrder(_staffId);
            supplierOrder.ShowDialog();
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            Book book = new Book(_staffId);
            book.ShowDialog();
        }

        private void btn_Suppliers_Click(object sender, EventArgs e)
        {
            SupplierOrder supplierOrder1 = new SupplierOrder(_staffId);
            supplierOrder1.ShowDialog();
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff(_staffId);
            staff.ShowDialog();
        }
    }
}
