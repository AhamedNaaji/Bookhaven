namespace Bookhaven
{
    partial class Staff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.comboStaffRole = new System.Windows.Forms.ComboBox();
            this.txtBox_StaffMobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_StaffPassword = new System.Windows.Forms.TextBox();
            this.txtBox_StaffUsername = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBox_StaffNIC = new System.Windows.Forms.TextBox();
            this.txtBox_StaffAddress = new System.Windows.Forms.TextBox();
            this.txtBox_Staffname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            this.btn_deleteStaff = new System.Windows.Forms.Button();
            this.btn_updateStaff = new System.Windows.Forms.Button();
            this.btn_addStaff = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.Email);
            this.panel3.Controls.Add(this.comboStaffRole);
            this.panel3.Controls.Add(this.txtBox_StaffMobile);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtBox_StaffPassword);
            this.panel3.Controls.Add(this.txtBox_StaffUsername);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txtBox_StaffNIC);
            this.panel3.Controls.Add(this.txtBox_StaffAddress);
            this.panel3.Controls.Add(this.txtBox_Staffname);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(574, 232);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 244);
            this.panel3.TabIndex = 62;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 22);
            this.textBox1.TabIndex = 43;
            this.textBox1.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(273, 165);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(62, 23);
            this.Email.TabIndex = 42;
            this.Email.Text = "Email";
            this.Email.UseMnemonic = false;
            this.Email.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboStaffRole
            // 
            this.comboStaffRole.FormattingEnabled = true;
            this.comboStaffRole.Location = new System.Drawing.Point(554, 121);
            this.comboStaffRole.Name = "comboStaffRole";
            this.comboStaffRole.Size = new System.Drawing.Size(190, 24);
            this.comboStaffRole.TabIndex = 41;
            this.comboStaffRole.SelectedIndexChanged += new System.EventHandler(this.comboStaffRole_SelectedIndexChanged);
            // 
            // txtBox_StaffMobile
            // 
            this.txtBox_StaffMobile.Location = new System.Drawing.Point(20, 200);
            this.txtBox_StaffMobile.Name = "txtBox_StaffMobile";
            this.txtBox_StaffMobile.Size = new System.Drawing.Size(190, 22);
            this.txtBox_StaffMobile.TabIndex = 40;
            this.txtBox_StaffMobile.TextChanged += new System.EventHandler(this.txtBox_StaffMobile_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mobile Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Role";
            // 
            // txtBox_StaffPassword
            // 
            this.txtBox_StaffPassword.Location = new System.Drawing.Point(277, 121);
            this.txtBox_StaffPassword.Name = "txtBox_StaffPassword";
            this.txtBox_StaffPassword.Size = new System.Drawing.Size(190, 22);
            this.txtBox_StaffPassword.TabIndex = 36;
            this.txtBox_StaffPassword.TextChanged += new System.EventHandler(this.txtBox_StaffPassword_TextChanged);
            // 
            // txtBox_StaffUsername
            // 
            this.txtBox_StaffUsername.Location = new System.Drawing.Point(20, 121);
            this.txtBox_StaffUsername.Name = "txtBox_StaffUsername";
            this.txtBox_StaffUsername.Size = new System.Drawing.Size(190, 22);
            this.txtBox_StaffUsername.TabIndex = 35;
            this.txtBox_StaffUsername.TextChanged += new System.EventHandler(this.txtBox_StaffUsername_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 23);
            this.label14.TabIndex = 34;
            this.label14.Text = "Username";
            // 
            // txtBox_StaffNIC
            // 
            this.txtBox_StaffNIC.Location = new System.Drawing.Point(277, 43);
            this.txtBox_StaffNIC.Name = "txtBox_StaffNIC";
            this.txtBox_StaffNIC.Size = new System.Drawing.Size(190, 22);
            this.txtBox_StaffNIC.TabIndex = 33;
            this.txtBox_StaffNIC.TextChanged += new System.EventHandler(this.txtBox_StaffNIC_TextChanged);
            // 
            // txtBox_StaffAddress
            // 
            this.txtBox_StaffAddress.Location = new System.Drawing.Point(554, 41);
            this.txtBox_StaffAddress.Name = "txtBox_StaffAddress";
            this.txtBox_StaffAddress.Size = new System.Drawing.Size(190, 22);
            this.txtBox_StaffAddress.TabIndex = 32;
            this.txtBox_StaffAddress.TextChanged += new System.EventHandler(this.txtBox_StaffAddress_TextChanged);
            // 
            // txtBox_Staffname
            // 
            this.txtBox_Staffname.Location = new System.Drawing.Point(19, 44);
            this.txtBox_Staffname.Name = "txtBox_Staffname";
            this.txtBox_Staffname.Size = new System.Drawing.Size(190, 22);
            this.txtBox_Staffname.TabIndex = 31;
            this.txtBox_Staffname.TextChanged += new System.EventHandler(this.txtBox_Staffname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(550, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "NIC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Staff Name";
            // 
            // dgv_staff
            // 
            this.dgv_staff.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.Location = new System.Drawing.Point(574, 630);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.RowHeadersWidth = 51;
            this.dgv_staff.RowTemplate.Height = 24;
            this.dgv_staff.Size = new System.Drawing.Size(1192, 319);
            this.dgv_staff.TabIndex = 66;
            this.dgv_staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellClick);
            this.dgv_staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellContentClick);
            this.dgv_staff.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellContentDoubleClick);
            this.dgv_staff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellDoubleClick);
            // 
            // btn_deleteStaff
            // 
            this.btn_deleteStaff.Location = new System.Drawing.Point(1519, 468);
            this.btn_deleteStaff.Name = "btn_deleteStaff";
            this.btn_deleteStaff.Size = new System.Drawing.Size(247, 67);
            this.btn_deleteStaff.TabIndex = 65;
            this.btn_deleteStaff.Text = "Delete Staff";
            this.btn_deleteStaff.UseVisualStyleBackColor = true;
            this.btn_deleteStaff.Click += new System.EventHandler(this.btn_deleteStaff_Click);
            // 
            // btn_updateStaff
            // 
            this.btn_updateStaff.Location = new System.Drawing.Point(1519, 362);
            this.btn_updateStaff.Name = "btn_updateStaff";
            this.btn_updateStaff.Size = new System.Drawing.Size(247, 67);
            this.btn_updateStaff.TabIndex = 64;
            this.btn_updateStaff.Text = "Update Staff";
            this.btn_updateStaff.UseVisualStyleBackColor = true;
            this.btn_updateStaff.Click += new System.EventHandler(this.btn_updateStaff_Click);
            // 
            // btn_addStaff
            // 
            this.btn_addStaff.Location = new System.Drawing.Point(1519, 253);
            this.btn_addStaff.Name = "btn_addStaff";
            this.btn_addStaff.Size = new System.Drawing.Size(247, 67);
            this.btn_addStaff.TabIndex = 63;
            this.btn_addStaff.Text = "Add Staff";
            this.btn_addStaff.UseVisualStyleBackColor = true;
            this.btn_addStaff.Click += new System.EventHandler(this.btn_addStaff_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1803, 1055);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgv_staff);
            this.Controls.Add(this.btn_deleteStaff);
            this.Controls.Add(this.btn_updateStaff);
            this.Controls.Add(this.btn_addStaff);
            this.Name = "Staff";
            this.Text = "Staff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBox_StaffPassword;
        private System.Windows.Forms.TextBox txtBox_StaffUsername;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBox_StaffNIC;
        private System.Windows.Forms.TextBox txtBox_StaffAddress;
        private System.Windows.Forms.TextBox txtBox_Staffname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_staff;
        private System.Windows.Forms.Button btn_deleteStaff;
        private System.Windows.Forms.Button btn_updateStaff;
        private System.Windows.Forms.Button btn_addStaff;
        private System.Windows.Forms.TextBox txtBox_StaffMobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboStaffRole;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Email;
    }
}