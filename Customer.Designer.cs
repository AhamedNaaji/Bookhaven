namespace Bookhaven
{
    partial class Customer
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtbox_Number2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtbox_Number1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtbox_Address = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtbox_NIC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.btn_addCustomer = new System.Windows.Forms.Button();
            this.btn_updateCustomer = new System.Windows.Forms.Button();
            this.btn_deleteCustomer = new System.Windows.Forms.Button();
            this.dgv_cus = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Suppliers = new System.Windows.Forms.Button();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.btn_Book = new System.Windows.Forms.Button();
            this.btn_Supporder = new System.Windows.Forms.Button();
            this.btn_Cusorder = new System.Windows.Forms.Button();
            this.btn_Sales = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_overview = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cusorderRecieve_panel = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.outofstock_panel = new System.Windows.Forms.Panel();
            this.lbl_Outofstock = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Totalcustomer_panel = new System.Windows.Forms.Panel();
            this.lbl_TotalCustomer = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Totalsales_panel = new System.Windows.Forms.Panel();
            this.lbl_Totalsales = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Report = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cus)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.cusorderRecieve_panel.SuspendLayout();
            this.outofstock_panel.SuspendLayout();
            this.Totalcustomer_panel.SuspendLayout();
            this.Totalsales_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Dtp_DOB);
            this.panel2.Controls.Add(this.txt_Email);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.txtbox_Number2);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.txtbox_Number1);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.txtbox_Address);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtbox_NIC);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtbox_name);
            this.panel2.Location = new System.Drawing.Point(46, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 320);
            this.panel2.TabIndex = 26;
            // 
            // Dtp_DOB
            // 
            this.Dtp_DOB.Location = new System.Drawing.Point(283, 153);
            this.Dtp_DOB.Name = "Dtp_DOB";
            this.Dtp_DOB.Size = new System.Drawing.Size(200, 22);
            this.Dtp_DOB.TabIndex = 17;
            this.Dtp_DOB.ValueChanged += new System.EventHandler(this.Dtp_Dob_ValueChanged);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(506, 246);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(233, 37);
            this.txt_Email.TabIndex = 16;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(502, 206);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 20);
            this.label23.TabIndex = 15;
            this.label23.Text = "Email";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(502, 111);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(126, 20);
            this.label22.TabIndex = 14;
            this.label22.Text = "Number 02";
            // 
            // txtbox_Number2
            // 
            this.txtbox_Number2.Location = new System.Drawing.Point(506, 138);
            this.txtbox_Number2.Multiline = true;
            this.txtbox_Number2.Name = "txtbox_Number2";
            this.txtbox_Number2.Size = new System.Drawing.Size(233, 37);
            this.txtbox_Number2.TabIndex = 13;
            this.txtbox_Number2.TextChanged += new System.EventHandler(this.txtbox_Number2_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(502, 11);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(126, 20);
            this.label21.TabIndex = 12;
            this.label21.Text = "Number 01";
            // 
            // txtbox_Number1
            // 
            this.txtbox_Number1.Location = new System.Drawing.Point(506, 43);
            this.txtbox_Number1.Multiline = true;
            this.txtbox_Number1.Name = "txtbox_Number1";
            this.txtbox_Number1.Size = new System.Drawing.Size(233, 37);
            this.txtbox_Number1.TabIndex = 11;
            this.txtbox_Number1.TextChanged += new System.EventHandler(this.txtbox_Number1_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(15, 206);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 20);
            this.label20.TabIndex = 10;
            this.label20.Text = "Address";
            // 
            // txtbox_Address
            // 
            this.txtbox_Address.Location = new System.Drawing.Point(19, 246);
            this.txtbox_Address.Multiline = true;
            this.txtbox_Address.Name = "txtbox_Address";
            this.txtbox_Address.Size = new System.Drawing.Size(233, 37);
            this.txtbox_Address.TabIndex = 9;
            this.txtbox_Address.TextChanged += new System.EventHandler(this.txtbox_Address_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(343, 111);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 20);
            this.label19.TabIndex = 8;
            this.label19.Text = "DOB";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(15, 111);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 20);
            this.label18.TabIndex = 6;
            this.label18.Text = "NIC";
            // 
            // txtbox_NIC
            // 
            this.txtbox_NIC.Location = new System.Drawing.Point(19, 138);
            this.txtbox_NIC.Multiline = true;
            this.txtbox_NIC.Name = "txtbox_NIC";
            this.txtbox_NIC.Size = new System.Drawing.Size(233, 37);
            this.txtbox_NIC.TabIndex = 5;
            this.txtbox_NIC.TextChanged += new System.EventHandler(this.txtbox_NIC_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(19, 43);
            this.txtbox_name.Multiline = true;
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(233, 37);
            this.txtbox_name.TabIndex = 0;
            this.txtbox_name.TextChanged += new System.EventHandler(this.txtbox_name_TextChanged);
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_addCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_addCustomer.Location = new System.Drawing.Point(863, 136);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(247, 67);
            this.btn_addCustomer.TabIndex = 27;
            this.btn_addCustomer.Text = "Add Customer";
            this.btn_addCustomer.UseVisualStyleBackColor = true;
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // btn_updateCustomer
            // 
            this.btn_updateCustomer.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_updateCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_updateCustomer.Location = new System.Drawing.Point(863, 244);
            this.btn_updateCustomer.Name = "btn_updateCustomer";
            this.btn_updateCustomer.Size = new System.Drawing.Size(247, 67);
            this.btn_updateCustomer.TabIndex = 28;
            this.btn_updateCustomer.Text = "Update Customer";
            this.btn_updateCustomer.UseVisualStyleBackColor = true;
            this.btn_updateCustomer.Click += new System.EventHandler(this.btn_updateCustomer_Click);
            // 
            // btn_deleteCustomer
            // 
            this.btn_deleteCustomer.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_deleteCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_deleteCustomer.Location = new System.Drawing.Point(863, 360);
            this.btn_deleteCustomer.Name = "btn_deleteCustomer";
            this.btn_deleteCustomer.Size = new System.Drawing.Size(247, 67);
            this.btn_deleteCustomer.TabIndex = 29;
            this.btn_deleteCustomer.Text = "Delete Customer";
            this.btn_deleteCustomer.UseVisualStyleBackColor = true;
            this.btn_deleteCustomer.Click += new System.EventHandler(this.btn_deleteCustomer_Click);
            // 
            // dgv_cus
            // 
            this.dgv_cus.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_cus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cus.Location = new System.Drawing.Point(46, 483);
            this.dgv_cus.Name = "dgv_cus";
            this.dgv_cus.RowHeadersWidth = 51;
            this.dgv_cus.RowTemplate.Height = 24;
            this.dgv_cus.Size = new System.Drawing.Size(1064, 362);
            this.dgv_cus.TabIndex = 30;
            this.dgv_cus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cus_CellContentClick);
            this.dgv_cus.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cus_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(69)))), ((int)(((byte)(89)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Report);
            this.panel1.Controls.Add(this.btn_Suppliers);
            this.panel1.Controls.Add(this.btn_Staff);
            this.panel1.Controls.Add(this.btn_Book);
            this.panel1.Controls.Add(this.btn_Supporder);
            this.panel1.Controls.Add(this.btn_Cusorder);
            this.panel1.Controls.Add(this.btn_Sales);
            this.panel1.Controls.Add(this.btn_Customer);
            this.panel1.Controls.Add(this.btn_overview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.panel1.Location = new System.Drawing.Point(1153, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 857);
            this.panel1.TabIndex = 31;
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
            this.btn_Customer.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Customer.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Customer.Location = new System.Drawing.Point(32, 217);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(219, 53);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.91514F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.05092F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.cusorderRecieve_panel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.outofstock_panel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Totalcustomer_panel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Totalsales_panel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1153, 130);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // cusorderRecieve_panel
            // 
            this.cusorderRecieve_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(131)))), ((int)(((byte)(146)))));
            this.cusorderRecieve_panel.Controls.Add(this.label16);
            this.cusorderRecieve_panel.Controls.Add(this.label17);
            this.cusorderRecieve_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cusorderRecieve_panel.Location = new System.Drawing.Point(863, 0);
            this.cusorderRecieve_panel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.cusorderRecieve_panel.Name = "cusorderRecieve_panel";
            this.cusorderRecieve_panel.Size = new System.Drawing.Size(290, 120);
            this.cusorderRecieve_panel.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(72, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 23);
            this.label16.TabIndex = 1;
            this.label16.Text = "2500";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(73, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(278, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "Rec Orders";
            // 
            // outofstock_panel
            // 
            this.outofstock_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(131)))), ((int)(((byte)(146)))));
            this.outofstock_panel.Controls.Add(this.lbl_Outofstock);
            this.outofstock_panel.Controls.Add(this.label13);
            this.outofstock_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outofstock_panel.Location = new System.Drawing.Point(575, 0);
            this.outofstock_panel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.outofstock_panel.Name = "outofstock_panel";
            this.outofstock_panel.Size = new System.Drawing.Size(278, 120);
            this.outofstock_panel.TabIndex = 2;
            // 
            // lbl_Outofstock
            // 
            this.lbl_Outofstock.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Outofstock.Location = new System.Drawing.Point(74, 57);
            this.lbl_Outofstock.Name = "lbl_Outofstock";
            this.lbl_Outofstock.Size = new System.Drawing.Size(67, 23);
            this.lbl_Outofstock.TabIndex = 1;
            this.lbl_Outofstock.Text = "200";
            this.lbl_Outofstock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(27, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Existing Customer";
            // 
            // Totalcustomer_panel
            // 
            this.Totalcustomer_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(131)))), ((int)(((byte)(146)))));
            this.Totalcustomer_panel.Controls.Add(this.lbl_TotalCustomer);
            this.Totalcustomer_panel.Controls.Add(this.label9);
            this.Totalcustomer_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Totalcustomer_panel.Location = new System.Drawing.Point(288, 0);
            this.Totalcustomer_panel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.Totalcustomer_panel.Name = "Totalcustomer_panel";
            this.Totalcustomer_panel.Size = new System.Drawing.Size(277, 120);
            this.Totalcustomer_panel.TabIndex = 1;
            // 
            // lbl_TotalCustomer
            // 
            this.lbl_TotalCustomer.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_TotalCustomer.Location = new System.Drawing.Point(61, 57);
            this.lbl_TotalCustomer.Name = "lbl_TotalCustomer";
            this.lbl_TotalCustomer.Size = new System.Drawing.Size(67, 23);
            this.lbl_TotalCustomer.TabIndex = 1;
            this.lbl_TotalCustomer.Text = "50";
            this.lbl_TotalCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(33, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Today Customers";
            // 
            // Totalsales_panel
            // 
            this.Totalsales_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(131)))), ((int)(((byte)(146)))));
            this.Totalsales_panel.Controls.Add(this.lbl_Totalsales);
            this.Totalsales_panel.Controls.Add(this.label2);
            this.Totalsales_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Totalsales_panel.Location = new System.Drawing.Point(0, 0);
            this.Totalsales_panel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.Totalsales_panel.Name = "Totalsales_panel";
            this.Totalsales_panel.Size = new System.Drawing.Size(278, 120);
            this.Totalsales_panel.TabIndex = 0;
            // 
            // lbl_Totalsales
            // 
            this.lbl_Totalsales.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Totalsales.Location = new System.Drawing.Point(61, 57);
            this.lbl_Totalsales.Name = "lbl_Totalsales";
            this.lbl_Totalsales.Size = new System.Drawing.Size(71, 23);
            this.lbl_Totalsales.TabIndex = 1;
            this.lbl_Totalsales.Text = "5000";
            this.lbl_Totalsales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(42, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Customer";
            // 
            // btn_Report
            // 
            this.btn_Report.BackColor = System.Drawing.Color.White;
            this.btn_Report.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Report.Location = new System.Drawing.Point(32, 788);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(219, 56);
            this.btn_Report.TabIndex = 9;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 857);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_cus);
            this.Controls.Add(this.btn_deleteCustomer);
            this.Controls.Add(this.btn_updateCustomer);
            this.Controls.Add(this.btn_addCustomer);
            this.Controls.Add(this.panel2);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.frm_load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.cusorderRecieve_panel.ResumeLayout(false);
            this.outofstock_panel.ResumeLayout(false);
            this.outofstock_panel.PerformLayout();
            this.Totalcustomer_panel.ResumeLayout(false);
            this.Totalcustomer_panel.PerformLayout();
            this.Totalsales_panel.ResumeLayout(false);
            this.Totalsales_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtbox_NIC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtbox_Number2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtbox_Address;
        private System.Windows.Forms.Button btn_addCustomer;
        private System.Windows.Forms.Button btn_updateCustomer;
        private System.Windows.Forms.Button btn_deleteCustomer;
        private System.Windows.Forms.DataGridView dgv_cus;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Suppliers;
        private System.Windows.Forms.Button btn_Staff;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.Button btn_Supporder;
        private System.Windows.Forms.Button btn_Cusorder;
        private System.Windows.Forms.Button btn_Sales;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_overview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel cusorderRecieve_panel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel outofstock_panel;
        private System.Windows.Forms.Label lbl_Outofstock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel Totalcustomer_panel;
        private System.Windows.Forms.Label lbl_TotalCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel Totalsales_panel;
        private System.Windows.Forms.Label lbl_Totalsales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_Number1;
        private System.Windows.Forms.DateTimePicker Dtp_DOB;
        private System.Windows.Forms.Button btn_Report;
    }
}