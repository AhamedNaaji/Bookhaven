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
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtbox_Number2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtbox_Number1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtbox_Address = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtbox_DOB = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtbox_NIC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.btn_addCustomer = new System.Windows.Forms.Button();
            this.btn_updateCustomer = new System.Windows.Forms.Button();
            this.btn_deleteCustomer = new System.Windows.Forms.Button();
            this.dgv_cus = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Suppliers = new System.Windows.Forms.Button();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.btn_Book = new System.Windows.Forms.Button();
            this.btn_Supporder = new System.Windows.Forms.Button();
            this.btn_Cusorder = new System.Windows.Forms.Button();
            this.btn_Sales = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cus)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_Email);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.txtbox_Number2);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.txtbox_Number1);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.txtbox_Address);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txtbox_DOB);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtbox_NIC);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtbox_name);
            this.panel2.Location = new System.Drawing.Point(404, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1017, 318);
            this.panel2.TabIndex = 26;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(691, 45);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(233, 37);
            this.txt_Email.TabIndex = 16;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(688, 11);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 36);
            this.label23.TabIndex = 15;
            this.label23.Text = "Email";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(17, 227);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(136, 36);
            this.label22.TabIndex = 14;
            this.label22.Text = "Number 02";
            // 
            // txtbox_Number2
            // 
            this.txtbox_Number2.Location = new System.Drawing.Point(21, 259);
            this.txtbox_Number2.Multiline = true;
            this.txtbox_Number2.Name = "txtbox_Number2";
            this.txtbox_Number2.Size = new System.Drawing.Size(233, 37);
            this.txtbox_Number2.TabIndex = 13;
            this.txtbox_Number2.TextChanged += new System.EventHandler(this.txtbox_Number2_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(690, 117);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(131, 36);
            this.label21.TabIndex = 12;
            this.label21.Text = "Number 01";
            // 
            // txtbox_Number1
            // 
            this.txtbox_Number1.Location = new System.Drawing.Point(694, 149);
            this.txtbox_Number1.Multiline = true;
            this.txtbox_Number1.Name = "txtbox_Number1";
            this.txtbox_Number1.Size = new System.Drawing.Size(233, 37);
            this.txtbox_Number1.TabIndex = 11;
            this.txtbox_Number1.TextChanged += new System.EventHandler(this.txtbox_Number1_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(366, 117);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 36);
            this.label20.TabIndex = 10;
            this.label20.Text = "Address";
            // 
            // txtbox_Address
            // 
            this.txtbox_Address.Location = new System.Drawing.Point(370, 149);
            this.txtbox_Address.Multiline = true;
            this.txtbox_Address.Name = "txtbox_Address";
            this.txtbox_Address.Size = new System.Drawing.Size(233, 37);
            this.txtbox_Address.TabIndex = 9;
            this.txtbox_Address.TextChanged += new System.EventHandler(this.txtbox_Address_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(15, 117);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 36);
            this.label19.TabIndex = 8;
            this.label19.Text = "DOB";
            // 
            // txtbox_DOB
            // 
            this.txtbox_DOB.Location = new System.Drawing.Point(19, 149);
            this.txtbox_DOB.Multiline = true;
            this.txtbox_DOB.Name = "txtbox_DOB";
            this.txtbox_DOB.Size = new System.Drawing.Size(233, 37);
            this.txtbox_DOB.TabIndex = 7;
            this.txtbox_DOB.TextChanged += new System.EventHandler(this.txtbox_DOB_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(366, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 36);
            this.label18.TabIndex = 6;
            this.label18.Text = "NIC";
            // 
            // txtbox_NIC
            // 
            this.txtbox_NIC.Location = new System.Drawing.Point(370, 43);
            this.txtbox_NIC.Multiline = true;
            this.txtbox_NIC.Name = "txtbox_NIC";
            this.txtbox_NIC.Size = new System.Drawing.Size(233, 37);
            this.txtbox_NIC.TabIndex = 5;
            this.txtbox_NIC.TextChanged += new System.EventHandler(this.txtbox_NIC_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 36);
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
            this.btn_addCustomer.BackColor = System.Drawing.Color.Lime;
            this.btn_addCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCustomer.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_addCustomer.Location = new System.Drawing.Point(19, 23);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(247, 67);
            this.btn_addCustomer.TabIndex = 27;
            this.btn_addCustomer.Text = "Add Customer";
            this.btn_addCustomer.UseVisualStyleBackColor = false;
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // btn_updateCustomer
            // 
            this.btn_updateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_updateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateCustomer.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_updateCustomer.Location = new System.Drawing.Point(19, 128);
            this.btn_updateCustomer.Name = "btn_updateCustomer";
            this.btn_updateCustomer.Size = new System.Drawing.Size(247, 67);
            this.btn_updateCustomer.TabIndex = 28;
            this.btn_updateCustomer.Text = "Update Customer";
            this.btn_updateCustomer.UseVisualStyleBackColor = false;
            this.btn_updateCustomer.Click += new System.EventHandler(this.btn_updateCustomer_Click);
            // 
            // btn_deleteCustomer
            // 
            this.btn_deleteCustomer.BackColor = System.Drawing.Color.Red;
            this.btn_deleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteCustomer.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_deleteCustomer.Location = new System.Drawing.Point(19, 232);
            this.btn_deleteCustomer.Name = "btn_deleteCustomer";
            this.btn_deleteCustomer.Size = new System.Drawing.Size(247, 67);
            this.btn_deleteCustomer.TabIndex = 29;
            this.btn_deleteCustomer.Text = "Delete Customer";
            this.btn_deleteCustomer.UseVisualStyleBackColor = false;
            this.btn_deleteCustomer.Click += new System.EventHandler(this.btn_deleteCustomer_Click);
            // 
            // dgv_cus
            // 
            this.dgv_cus.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_cus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cus.Location = new System.Drawing.Point(404, 557);
            this.dgv_cus.Name = "dgv_cus";
            this.dgv_cus.RowHeadersWidth = 51;
            this.dgv_cus.RowTemplate.Height = 24;
            this.dgv_cus.Size = new System.Drawing.Size(1338, 287);
            this.dgv_cus.TabIndex = 30;
            this.dgv_cus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cus_CellContentClick);
            this.dgv_cus.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cus_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(355, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1427, 156);
            this.panel3.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1200, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 58);
            this.label1.TabIndex = 8;
            this.label1.Text = "Book Heaven";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btn_Suppliers);
            this.panel1.Controls.Add(this.btn_Staff);
            this.panel1.Controls.Add(this.btn_Book);
            this.panel1.Controls.Add(this.btn_Supporder);
            this.panel1.Controls.Add(this.btn_Cusorder);
            this.panel1.Controls.Add(this.btn_Sales);
            this.panel1.Controls.Add(this.btn_Customer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 885);
            this.panel1.TabIndex = 31;
            // 
            // btn_Suppliers
            // 
            this.btn_Suppliers.BackColor = System.Drawing.Color.White;
            this.btn_Suppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suppliers.ForeColor = System.Drawing.Color.Black;
            this.btn_Suppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Suppliers.Location = new System.Drawing.Point(52, 581);
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
            this.btn_Staff.Location = new System.Drawing.Point(52, 680);
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
            this.btn_Book.Location = new System.Drawing.Point(52, 473);
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
            this.btn_Supporder.Location = new System.Drawing.Point(52, 367);
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
            this.btn_Cusorder.Location = new System.Drawing.Point(52, 258);
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
            this.btn_Sales.Location = new System.Drawing.Point(52, 150);
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
            this.btn_Customer.Location = new System.Drawing.Point(52, 43);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(243, 63);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "Customer Details";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_deleteCustomer);
            this.panel4.Controls.Add(this.btn_addCustomer);
            this.panel4.Controls.Add(this.btn_updateCustomer);
            this.panel4.Location = new System.Drawing.Point(1460, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 321);
            this.panel4.TabIndex = 33;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(52, 781);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(243, 63);
            this.button4.TabIndex = 8;
            this.button4.Text = "Report";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 885);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_cus);
            this.Controls.Add(this.panel2);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.frm_load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cus)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtbox_DOB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtbox_NIC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtbox_Number2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtbox_Number1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtbox_Address;
        private System.Windows.Forms.Button btn_addCustomer;
        private System.Windows.Forms.Button btn_updateCustomer;
        private System.Windows.Forms.Button btn_deleteCustomer;
        private System.Windows.Forms.DataGridView dgv_cus;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
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