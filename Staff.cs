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

            fill.FillDataGridView("SELECT * FROM Staff", dgv_staff);
            dgv_staff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            //if (e.RowIndex >= 0)
            //{
            //    // Get selected customer ID
            //    int Staff_Id = Convert.ToInt32(dgv_staff.Rows[e.RowIndex].Cells["Staff_Id"].Value);

            //    // Load customer data
            //    clsstf.Staff_Id = Staff_Id;
            //    clsstf.Getdata();

            //    // Populate form fields
            //    txtbox_Suppliername.Text = clssup.Supplier_Name;
            //    txtbox_NIC.Text = clssup.NIC;

            //    txtbox_Address.Text = clssup.Address;
            //    txtbox_Email.Text = clssup.Email;

            //    // Populate mobile numbers (handle up to 2 numbers)
            //    txtbox_Contact1.Text = clssup.SupMobNumbers.Count > 0 ? clssup.SupMobNumbers[0] : "";
            //    txtbox_Contact2.Text = clssup.SupMobNumbers.Count > 1 ? clssup.SupMobNumbers[1] : "";
            //}
        }
    }
}
