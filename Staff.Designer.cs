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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Suppliers = new System.Windows.Forms.Button();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.btn_Book = new System.Windows.Forms.Button();
            this.btn_Supporder = new System.Windows.Forms.Button();
            this.btn_Cusorder = new System.Windows.Forms.Button();
            this.btn_Sales = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel3.Location = new System.Drawing.Point(404, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 313);
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
            this.Email.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.Email.Location = new System.Drawing.Point(273, 165);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(75, 36);
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
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 36);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mobile Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(550, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 36);
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
            this.label14.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(16, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 36);
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
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(279, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(550, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(279, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "NIC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(15, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 36);
            this.label6.TabIndex = 4;
            this.label6.Text = "Staff Name";
            // 
            // dgv_staff
            // 
            this.dgv_staff.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.Location = new System.Drawing.Point(404, 574);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.RowHeadersWidth = 51;
            this.dgv_staff.RowTemplate.Height = 24;
            this.dgv_staff.Size = new System.Drawing.Size(1167, 270);
            this.dgv_staff.TabIndex = 66;
            this.dgv_staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellClick);
            this.dgv_staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellContentClick);
            this.dgv_staff.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellContentDoubleClick);
            this.dgv_staff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellDoubleClick);
            // 
            // btn_deleteStaff
            // 
            this.btn_deleteStaff.BackColor = System.Drawing.Color.Red;
            this.btn_deleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteStaff.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_deleteStaff.Location = new System.Drawing.Point(1299, 440);
            this.btn_deleteStaff.Name = "btn_deleteStaff";
            this.btn_deleteStaff.Size = new System.Drawing.Size(247, 67);
            this.btn_deleteStaff.TabIndex = 65;
            this.btn_deleteStaff.Text = "Delete Staff";
            this.btn_deleteStaff.UseVisualStyleBackColor = false;
            this.btn_deleteStaff.Click += new System.EventHandler(this.btn_deleteStaff_Click);
            // 
            // btn_updateStaff
            // 
            this.btn_updateStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_updateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateStaff.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_updateStaff.Location = new System.Drawing.Point(31, 125);
            this.btn_updateStaff.Name = "btn_updateStaff";
            this.btn_updateStaff.Size = new System.Drawing.Size(247, 67);
            this.btn_updateStaff.TabIndex = 64;
            this.btn_updateStaff.Text = "Update Staff";
            this.btn_updateStaff.UseVisualStyleBackColor = false;
            this.btn_updateStaff.Click += new System.EventHandler(this.btn_updateStaff_Click);
            // 
            // btn_addStaff
            // 
            this.btn_addStaff.BackColor = System.Drawing.Color.Lime;
            this.btn_addStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addStaff.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_addStaff.Location = new System.Drawing.Point(31, 27);
            this.btn_addStaff.Name = "btn_addStaff";
            this.btn_addStaff.Size = new System.Drawing.Size(247, 67);
            this.btn_addStaff.TabIndex = 63;
            this.btn_addStaff.Text = "Add Staff";
            this.btn_addStaff.UseVisualStyleBackColor = false;
            this.btn_addStaff.Click += new System.EventHandler(this.btn_addStaff_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(355, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1448, 156);
            this.panel1.TabIndex = 68;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1220, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(39, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 58);
            this.label7.TabIndex = 8;
            this.label7.Text = "Book Heaven";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(49, 735);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 60);
            this.button2.TabIndex = 7;
            this.button2.Text = "Suppliers";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(49, 820);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(258, 63);
            this.button3.TabIndex = 6;
            this.button3.Text = "Staff";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(49, 641);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(258, 63);
            this.button6.TabIndex = 5;
            this.button6.Text = "Book";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btn_Suppliers);
            this.panel2.Controls.Add(this.btn_Staff);
            this.panel2.Controls.Add(this.btn_Book);
            this.panel2.Controls.Add(this.btn_Supporder);
            this.panel2.Controls.Add(this.btn_Cusorder);
            this.panel2.Controls.Add(this.btn_Sales);
            this.panel2.Controls.Add(this.btn_Customer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 891);
            this.panel2.TabIndex = 67;
            // 
            // btn_Suppliers
            // 
            this.btn_Suppliers.BackColor = System.Drawing.Color.White;
            this.btn_Suppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suppliers.ForeColor = System.Drawing.Color.Black;
            this.btn_Suppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Suppliers.Location = new System.Drawing.Point(49, 583);
            this.btn_Suppliers.Name = "btn_Suppliers";
            this.btn_Suppliers.Size = new System.Drawing.Size(243, 60);
            this.btn_Suppliers.TabIndex = 7;
            this.btn_Suppliers.Text = "Suppliers Details";
            this.btn_Suppliers.UseVisualStyleBackColor = false;
            this.btn_Suppliers.Click += new System.EventHandler(this.btn_Suppliers_Click);
            // 
            // btn_Staff
            // 
            this.btn_Staff.BackColor = System.Drawing.Color.White;
            this.btn_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff.ForeColor = System.Drawing.Color.Black;
            this.btn_Staff.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Staff.Location = new System.Drawing.Point(49, 682);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(243, 63);
            this.btn_Staff.TabIndex = 6;
            this.btn_Staff.Text = "Staff Details";
            this.btn_Staff.UseVisualStyleBackColor = false;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // btn_Book
            // 
            this.btn_Book.BackColor = System.Drawing.Color.White;
            this.btn_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Book.ForeColor = System.Drawing.Color.Black;
            this.btn_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Book.Location = new System.Drawing.Point(49, 475);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(243, 63);
            this.btn_Book.TabIndex = 5;
            this.btn_Book.Text = "Book Details";
            this.btn_Book.UseVisualStyleBackColor = false;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // btn_Supporder
            // 
            this.btn_Supporder.BackColor = System.Drawing.Color.White;
            this.btn_Supporder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Supporder.ForeColor = System.Drawing.Color.Black;
            this.btn_Supporder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Supporder.Location = new System.Drawing.Point(49, 369);
            this.btn_Supporder.Name = "btn_Supporder";
            this.btn_Supporder.Size = new System.Drawing.Size(243, 63);
            this.btn_Supporder.TabIndex = 4;
            this.btn_Supporder.Text = "Supplier Order";
            this.btn_Supporder.UseVisualStyleBackColor = false;
            this.btn_Supporder.Click += new System.EventHandler(this.btn_Supporder_Click);
            // 
            // btn_Cusorder
            // 
            this.btn_Cusorder.BackColor = System.Drawing.Color.White;
            this.btn_Cusorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cusorder.ForeColor = System.Drawing.Color.Black;
            this.btn_Cusorder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cusorder.Location = new System.Drawing.Point(49, 260);
            this.btn_Cusorder.Name = "btn_Cusorder";
            this.btn_Cusorder.Size = new System.Drawing.Size(243, 63);
            this.btn_Cusorder.TabIndex = 3;
            this.btn_Cusorder.Text = "Customer Order";
            this.btn_Cusorder.UseVisualStyleBackColor = false;
            this.btn_Cusorder.Click += new System.EventHandler(this.btn_Cusorder_Click);
            // 
            // btn_Sales
            // 
            this.btn_Sales.BackColor = System.Drawing.Color.White;
            this.btn_Sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sales.ForeColor = System.Drawing.Color.Black;
            this.btn_Sales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sales.Location = new System.Drawing.Point(49, 152);
            this.btn_Sales.Name = "btn_Sales";
            this.btn_Sales.Size = new System.Drawing.Size(243, 63);
            this.btn_Sales.TabIndex = 2;
            this.btn_Sales.Text = "Sales Details";
            this.btn_Sales.UseVisualStyleBackColor = false;
            this.btn_Sales.Click += new System.EventHandler(this.btn_Sales_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.Color.White;
            this.btn_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.Black;
            this.btn_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Customer.Location = new System.Drawing.Point(49, 45);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(243, 63);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "Customer Details";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_addStaff);
            this.panel4.Controls.Add(this.btn_updateStaff);
            this.panel4.Location = new System.Drawing.Point(1268, 216);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(303, 315);
            this.panel4.TabIndex = 69;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(49, 781);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(243, 63);
            this.button4.TabIndex = 8;
            this.button4.Text = "Report";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1803, 891);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgv_staff);
            this.Controls.Add(this.btn_deleteStaff);
            this.Controls.Add(this.panel4);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Suppliers;
        private System.Windows.Forms.Button btn_Staff;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.Button btn_Supporder;
        private System.Windows.Forms.Button btn_Cusorder;
        private System.Windows.Forms.Button btn_Sales;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
    }
}