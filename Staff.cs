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
    public partial class Staff : Form
    {
        filloperation fill = new filloperation();
        cls_staff clsstf = new cls_staff();
        public Staff()
        {
            InitializeComponent();
        }

        void FirstRun()
        {
            // Clear form fields
            txtBox_Staffname.Text = "";
            txtBox_StaffNIC.Text = "";
            txtBox_StaffAddress.Text = "";
            txtBox_StaffUsername.Text = "";
            txtBox_StaffPassword.Text = "";
            comboStaffRole.Text = "";
            txtBox_StaffMobile.Text = "";
            textBox1.Text = "";

            //    // Updated query to include mobile numbers
            //    string query = @"
            //SELECT 
            //    c.Staff_Id,
            //    c.Staff_Name,
            //    c.NIC,
            //    c.Address,
            //    c.Username,
            //    c.Password,
            //    c.MobileNum,
            //    c.Email,
            //    MAX(CASE WHEN cm.RowNum = 1 THEN cm.RoleName END) AS Role,
            //FROM Supplier c
            //LEFT JOIN (
            //    SELECT 
            //        staffRoll_Id_fk,
            //        roleName,
            //        ROW_NUMBER() OVER (PARTITION BY staffRoll_Id_fk ORDER BY rollId) AS RowNum
            //    FROM staffRole
            //) cm ON c.Staff_Id = cm.staffRoll_Id_fk
            //GROUP BY 
            //    c.Staff_Id,
            //    c.Staff_Name,
            //    c.NIC,
            //    c.Address,
            //    c.Username,
            //    c.Password,
            //    c.MobileNum,
            //    c.Email";


            string query = @"
        SELECT 
            s.Staff_Id,
            s.Staff_Name,
            s.NIC,
            s.Address,
            s.Username,
            s.Password,
            s.MobileNum,
            s.Email,
            sr.roleName AS Role
        FROM Staff s
        INNER JOIN staffRole sr ON s.staffRoll_Id_fk = sr.rollId
        ORDER BY s.Staff_Id DESC";

            fill.FillDataGridView(query, dgv_staff);
            dgv_staff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configure columns explicitly
            if (dgv_staff.Columns.Count > 0)
            {
                dgv_staff.Columns["Staff_Id"].HeaderText = "ID";
                dgv_staff.Columns["Staff_Name"].HeaderText = "Full Name";
                dgv_staff.Columns["NIC"].HeaderText = "NIC";
                dgv_staff.Columns["Address"].HeaderText = "Address";
                dgv_staff.Columns["Username"].HeaderText = "Username";
                dgv_staff.Columns["MobileNum"].HeaderText = "Mobile";
                dgv_staff.Columns["Email"].HeaderText = "Email";
                dgv_staff.Columns["Role"].HeaderText = "Role";
                dgv_staff.Columns["Password"].Visible = false; // Hide sensitive data
            }

            //fill.FillDataGridView("SELECT * FROM Staff", dgv_staff);
            //dgv_staff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //// Populate DataGridView
            //fill.FillDataGridView(query, dgv_staff);
            //dgv_staff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Rename columns
            dgv_staff.Columns[0].HeaderText = "ID";
            dgv_staff.Columns[1].HeaderText = "Name";
            dgv_staff.Columns[2].HeaderText = "NIC";
            dgv_staff.Columns[3].HeaderText = "Address";
            dgv_staff.Columns[4].HeaderText = "Username";
            dgv_staff.Columns[5].HeaderText = "Password";
            dgv_staff.Columns[6].HeaderText = "MobileNum";
            dgv_staff.Columns[7].HeaderText = "Email";
            dgv_staff.Columns[8].HeaderText = "Role";
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {
            fill.combobox("SELECT * FROM staffRole", comboStaffRole, "roleName", "rollId");
            FirstRun();
        }

        private void comboStaffRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsstf.roleName = comboStaffRole.SelectedValue.ToString();
        }

        private void txtBox_Staffname_TextChanged(object sender, EventArgs e)
        {
            clsstf.Staff_Name = txtBox_Staffname.Text.Trim();
        }

        private void txtBox_StaffNIC_TextChanged(object sender, EventArgs e)
        {
            clsstf.NIC = txtBox_StaffNIC.Text.Trim();
        }

        private void txtBox_StaffAddress_TextChanged(object sender, EventArgs e)
        {
            clsstf.Address = txtBox_StaffAddress.Text.Trim();
        }

        private void txtBox_StaffUsername_TextChanged(object sender, EventArgs e)
        {
            clsstf.Username = txtBox_StaffUsername.Text.Trim();
        }

        private void txtBox_StaffPassword_TextChanged(object sender, EventArgs e)
        {
            clsstf.Password = txtBox_StaffPassword.Text.Trim();
        }

        private void txtBox_StaffMobile_TextChanged(object sender, EventArgs e)
        {
            clsstf.MobileNum = txtBox_StaffMobile.Text.Trim();
        }

        private void btn_addStaff_Click(object sender, EventArgs e)
        {

            clsstf.Insertdata();
            Staff_Load(sender, e);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            clsstf.Email = textBox1.Text.Trim();
        }

        private void dgv_staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_staff_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_staff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_staff.Rows[e.RowIndex];

                // Populate form fields using data-bound values
                txtBox_Staffname.Text = row.Cells["Staff_Name"].Value?.ToString() ?? "";
                txtBox_StaffNIC.Text = row.Cells["NIC"].Value?.ToString() ?? "";
                txtBox_StaffAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
                txtBox_StaffUsername.Text = row.Cells["Username"].Value?.ToString() ?? "";
                txtBox_StaffPassword.Text = row.Cells["Password"].Value?.ToString() ?? "";
                txtBox_StaffMobile.Text = row.Cells["MobileNum"].Value?.ToString() ?? "";
                textBox1.Text = row.Cells["Email"].Value?.ToString() ?? "";
                comboStaffRole.Text = row.Cells["Role"].Value?.ToString() ?? "";

                // Set staff ID for updates
                clsstf.Staff_Id = Convert.ToInt32(row.Cells["Staff_Id"].Value);
            }
        }

        private void btn_deleteStaff_Click(object sender, EventArgs e)
        {
            if (clsstf.Staff_Id > 0)
            {
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this staff member?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    clsstf.DeleteDate();
                    FirstRun(); // Refresh data
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member to delete.");
            }
        }

        private void btn_updateStaff_Click(object sender, EventArgs e)
        {
            if (clsstf.Staff_Id <= 0)
            {
                MessageBox.Show("Please select a staff member to update.");
                return;
            }

            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtBox_Staffname.Text) ||
                string.IsNullOrWhiteSpace(txtBox_StaffNIC.Text) ||
                string.IsNullOrWhiteSpace(txtBox_StaffUsername.Text) ||
                string.IsNullOrWhiteSpace(txtBox_StaffPassword.Text) ||
                comboStaffRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all required fields (Name, NIC, Username, Password, Role).");
                return;
            }

            // Populate staff object
            clsstf.Staff_Name = txtBox_Staffname.Text.Trim();
            clsstf.NIC = txtBox_StaffNIC.Text.Trim();
            clsstf.Address = txtBox_StaffAddress.Text.Trim();
            clsstf.Username = txtBox_StaffUsername.Text.Trim();
            clsstf.Password = txtBox_StaffPassword.Text.Trim();
            clsstf.MobileNum = txtBox_StaffMobile.Text.Trim();
            clsstf.Email = textBox1.Text.Trim();
            clsstf.staffRoll_Id_fk = Convert.ToInt32(comboStaffRole.SelectedValue);

            // Execute update
            clsstf.UpdateData();
            FirstRun(); // Refresh data
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
