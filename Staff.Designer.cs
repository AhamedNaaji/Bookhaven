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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Suppliers = new System.Windows.Forms.Button();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.btn_Book = new System.Windows.Forms.Button();
            this.btn_Supporder = new System.Windows.Forms.Button();
            this.btn_Cusorder = new System.Windows.Forms.Button();
            this.btn_Sales = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_overview = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel3.Location = new System.Drawing.Point(0, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 244);
            this.panel3.TabIndex = 62;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(277, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 32);
            this.textBox1.TabIndex = 43;
            this.textBox1.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.Email.Location = new System.Drawing.Point(273, 165);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(58, 24);
            this.Email.TabIndex = 42;
            this.Email.Text = "Email";
            this.Email.UseMnemonic = false;
            this.Email.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboStaffRole
            // 
            this.comboStaffRole.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.comboStaffRole.FormattingEnabled = true;
            this.comboStaffRole.Location = new System.Drawing.Point(554, 121);
            this.comboStaffRole.Name = "comboStaffRole";
            this.comboStaffRole.Size = new System.Drawing.Size(190, 32);
            this.comboStaffRole.TabIndex = 41;
            this.comboStaffRole.SelectedIndexChanged += new System.EventHandler(this.comboStaffRole_SelectedIndexChanged);
            // 
            // txtBox_StaffMobile
            // 
            this.txtBox_StaffMobile.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.txtBox_StaffMobile.Location = new System.Drawing.Point(20, 200);
            this.txtBox_StaffMobile.Name = "txtBox_StaffMobile";
            this.txtBox_StaffMobile.Size = new System.Drawing.Size(190, 32);
            this.txtBox_StaffMobile.TabIndex = 40;
            this.txtBox_StaffMobile.TextChanged += new System.EventHandler(this.txtBox_StaffMobile_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mobile Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(550, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Role";
            // 
            // txtBox_StaffPassword
            // 
            this.txtBox_StaffPassword.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.txtBox_StaffPassword.Location = new System.Drawing.Point(277, 121);
            this.txtBox_StaffPassword.Name = "txtBox_StaffPassword";
            this.txtBox_StaffPassword.Size = new System.Drawing.Size(190, 32);
            this.txtBox_StaffPassword.TabIndex = 36;
            this.txtBox_StaffPassword.TextChanged += new System.EventHandler(this.txtBox_StaffPassword_TextChanged);
            // 
            // txtBox_StaffUsername
            // 
            this.txtBox_StaffUsername.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.txtBox_StaffUsername.Location = new System.Drawing.Point(20, 121);
            this.txtBox_StaffUsername.Name = "txtBox_StaffUsername";
            this.txtBox_StaffUsername.Size = new System.Drawing.Size(190, 32);
            this.txtBox_StaffUsername.TabIndex = 35;
            this.txtBox_StaffUsername.TextChanged += new System.EventHandler(this.txtBox_StaffUsername_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(16, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 24);
            this.label14.TabIndex = 34;
            this.label14.Text = "Username";
            // 
            // txtBox_StaffNIC
            // 
            this.txtBox_StaffNIC.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.txtBox_StaffNIC.Location = new System.Drawing.Point(277, 43);
            this.txtBox_StaffNIC.Name = "txtBox_StaffNIC";
            this.txtBox_StaffNIC.Size = new System.Drawing.Size(190, 32);
            this.txtBox_StaffNIC.TabIndex = 33;
            this.txtBox_StaffNIC.TextChanged += new System.EventHandler(this.txtBox_StaffNIC_TextChanged);
            // 
            // txtBox_StaffAddress
            // 
            this.txtBox_StaffAddress.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.txtBox_StaffAddress.Location = new System.Drawing.Point(554, 41);
            this.txtBox_StaffAddress.Name = "txtBox_StaffAddress";
            this.txtBox_StaffAddress.Size = new System.Drawing.Size(190, 32);
            this.txtBox_StaffAddress.TabIndex = 32;
            this.txtBox_StaffAddress.TextChanged += new System.EventHandler(this.txtBox_StaffAddress_TextChanged);
            // 
            // txtBox_Staffname
            // 
            this.txtBox_Staffname.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.txtBox_Staffname.Location = new System.Drawing.Point(19, 44);
            this.txtBox_Staffname.Name = "txtBox_Staffname";
            this.txtBox_Staffname.Size = new System.Drawing.Size(190, 32);
            this.txtBox_Staffname.TabIndex = 31;
            this.txtBox_Staffname.TextChanged += new System.EventHandler(this.txtBox_Staffname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(279, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(550, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(279, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "NIC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(15, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Staff Name";
            // 
            // dgv_staff
            // 
            this.dgv_staff.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.Location = new System.Drawing.Point(0, 371);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.RowHeadersWidth = 51;
            this.dgv_staff.RowTemplate.Height = 24;
            this.dgv_staff.Size = new System.Drawing.Size(801, 475);
            this.dgv_staff.TabIndex = 66;
            this.dgv_staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellClick);
            this.dgv_staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellContentClick);
            this.dgv_staff.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellContentDoubleClick);
            this.dgv_staff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellDoubleClick);
            // 
            // btn_deleteStaff
            // 
            this.btn_deleteStaff.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_deleteStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_deleteStaff.Location = new System.Drawing.Point(820, 583);
            this.btn_deleteStaff.Name = "btn_deleteStaff";
            this.btn_deleteStaff.Size = new System.Drawing.Size(152, 70);
            this.btn_deleteStaff.TabIndex = 65;
            this.btn_deleteStaff.Text = "Delete Staff";
            this.btn_deleteStaff.UseVisualStyleBackColor = true;
            this.btn_deleteStaff.Click += new System.EventHandler(this.btn_deleteStaff_Click);
            // 
            // btn_updateStaff
            // 
            this.btn_updateStaff.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_updateStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_updateStaff.Location = new System.Drawing.Point(820, 326);
            this.btn_updateStaff.Name = "btn_updateStaff";
            this.btn_updateStaff.Size = new System.Drawing.Size(152, 67);
            this.btn_updateStaff.TabIndex = 64;
            this.btn_updateStaff.Text = "Update Staff";
            this.btn_updateStaff.UseVisualStyleBackColor = true;
            this.btn_updateStaff.Click += new System.EventHandler(this.btn_updateStaff_Click);
            // 
            // btn_addStaff
            // 
            this.btn_addStaff.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_addStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_addStaff.Location = new System.Drawing.Point(820, 138);
            this.btn_addStaff.Name = "btn_addStaff";
            this.btn_addStaff.Size = new System.Drawing.Size(152, 67);
            this.btn_addStaff.TabIndex = 63;
            this.btn_addStaff.Text = "Add Staff";
            this.btn_addStaff.UseVisualStyleBackColor = true;
            this.btn_addStaff.Click += new System.EventHandler(this.btn_addStaff_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(131)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 88);
            this.panel1.TabIndex = 68;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Red;
            this.btn_logout.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_logout.Location = new System.Drawing.Point(19, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(174, 52);
            this.btn_logout.TabIndex = 23;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(900, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(69)))), ((int)(((byte)(89)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Report);
            this.panel2.Controls.Add(this.btn_Suppliers);
            this.panel2.Controls.Add(this.btn_Staff);
            this.panel2.Controls.Add(this.btn_Book);
            this.panel2.Controls.Add(this.btn_Supporder);
            this.panel2.Controls.Add(this.btn_Cusorder);
            this.panel2.Controls.Add(this.btn_Sales);
            this.panel2.Controls.Add(this.btn_Customer);
            this.panel2.Controls.Add(this.btn_overview);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.panel2.Location = new System.Drawing.Point(995, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 858);
            this.panel2.TabIndex = 67;
            // 
            // btn_Suppliers
            // 
            this.btn_Suppliers.BackColor = System.Drawing.Color.White;
            this.btn_Suppliers.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Suppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Suppliers.Location = new System.Drawing.Point(32, 589);
            this.btn_Suppliers.Name = "btn_Suppliers";
            this.btn_Suppliers.Size = new System.Drawing.Size(219, 57);
            this.btn_Suppliers.TabIndex = 7;
            this.btn_Suppliers.Text = "Suppliers";
            this.btn_Suppliers.UseVisualStyleBackColor = false;
            // 
            // btn_Staff
            // 
            this.btn_Staff.BackColor = System.Drawing.Color.White;
            this.btn_Staff.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Staff.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Staff.Location = new System.Drawing.Point(32, 497);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(219, 53);
            this.btn_Staff.TabIndex = 6;
            this.btn_Staff.Text = "Staff";
            this.btn_Staff.UseVisualStyleBackColor = false;
            // 
            // btn_Book
            // 
            this.btn_Book.BackColor = System.Drawing.Color.White;
            this.btn_Book.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Book.Location = new System.Drawing.Point(32, 120);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(219, 53);
            this.btn_Book.TabIndex = 5;
            this.btn_Book.Text = "Book";
            this.btn_Book.UseVisualStyleBackColor = false;
            // 
            // btn_Supporder
            // 
            this.btn_Supporder.BackColor = System.Drawing.Color.White;
            this.btn_Supporder.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Supporder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Supporder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Supporder.Location = new System.Drawing.Point(32, 688);
            this.btn_Supporder.Name = "btn_Supporder";
            this.btn_Supporder.Size = new System.Drawing.Size(219, 56);
            this.btn_Supporder.TabIndex = 4;
            this.btn_Supporder.Text = "Supp Order";
            this.btn_Supporder.UseVisualStyleBackColor = false;
            // 
            // btn_Cusorder
            // 
            this.btn_Cusorder.BackColor = System.Drawing.Color.White;
            this.btn_Cusorder.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cusorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Cusorder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cusorder.Location = new System.Drawing.Point(32, 405);
            this.btn_Cusorder.Name = "btn_Cusorder";
            this.btn_Cusorder.Size = new System.Drawing.Size(219, 54);
            this.btn_Cusorder.TabIndex = 3;
            this.btn_Cusorder.Text = "Cus Order";
            this.btn_Cusorder.UseVisualStyleBackColor = false;
            // 
            // btn_Sales
            // 
            this.btn_Sales.BackColor = System.Drawing.Color.White;
            this.btn_Sales.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Sales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sales.Location = new System.Drawing.Point(32, 310);
            this.btn_Sales.Name = "btn_Sales";
            this.btn_Sales.Size = new System.Drawing.Size(219, 55);
            this.btn_Sales.TabIndex = 2;
            this.btn_Sales.Text = "Sales";
            this.btn_Sales.UseVisualStyleBackColor = false;
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.Color.White;
            this.btn_Customer.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Customer.Location = new System.Drawing.Point(32, 217);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(219, 53);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.UseVisualStyleBackColor = false;
            // 
            // btn_overview
            // 
            this.btn_overview.BackColor = System.Drawing.Color.White;
            this.btn_overview.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_overview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_overview.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_overview.Location = new System.Drawing.Point(32, 26);
            this.btn_overview.Name = "btn_overview";
            this.btn_overview.Size = new System.Drawing.Size(219, 56);
            this.btn_overview.TabIndex = 0;
            this.btn_overview.Text = "Overview";
            this.btn_overview.UseVisualStyleBackColor = false;
            // 
            // btn_Report
            // 
            this.btn_Report.BackColor = System.Drawing.Color.White;
            this.btn_Report.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Report.Location = new System.Drawing.Point(32, 789);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(219, 56);
            this.btn_Report.TabIndex = 9;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = false;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 858);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgv_staff);
            this.Controls.Add(this.btn_deleteStaff);
            this.Controls.Add(this.btn_updateStaff);
            this.Controls.Add(this.btn_addStaff);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Suppliers;
        private System.Windows.Forms.Button btn_Staff;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.Button btn_Supporder;
        private System.Windows.Forms.Button btn_Cusorder;
        private System.Windows.Forms.Button btn_Sales;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_overview;
        private System.Windows.Forms.Button btn_Report;
    }
}