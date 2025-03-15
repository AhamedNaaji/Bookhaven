namespace Bookhaven
{
    partial class Clerk_CustomerOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clerk_CustomerOrder));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.cmb_staff = new System.Windows.Forms.ComboBox();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.nup_Quantity = new System.Windows.Forms.NumericUpDown();
            this.cmb_Deliverymethod = new System.Windows.Forms.ComboBox();
            this.cmb_Suporder = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lbl_Discount_Cusorder = new System.Windows.Forms.Label();
            this.lbl_Finalpayment_Cusorder = new System.Windows.Forms.Label();
            this.lbl_Totalamount = new System.Windows.Forms.Label();
            this.cmb_Book = new System.Windows.Forms.ComboBox();
            this.cmb_customer = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_cusOrder = new System.Windows.Forms.DataGridView();
            this.btn_deleteorder = new System.Windows.Forms.Button();
            this.btn_updateorder = new System.Windows.Forms.Button();
            this.btn_makeorder = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Book = new System.Windows.Forms.Button();
            this.btn_Cusorder = new System.Windows.Forms.Button();
            this.btn_Sales = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_overview = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cusOrder)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.cmb_staff);
            this.panel2.Controls.Add(this.cmb_Status);
            this.panel2.Controls.Add(this.nup_Quantity);
            this.panel2.Controls.Add(this.cmb_Deliverymethod);
            this.panel2.Controls.Add(this.cmb_Suporder);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.lbl_Discount_Cusorder);
            this.panel2.Controls.Add(this.lbl_Finalpayment_Cusorder);
            this.panel2.Controls.Add(this.lbl_Totalamount);
            this.panel2.Controls.Add(this.cmb_Book);
            this.panel2.Controls.Add(this.cmb_customer);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 309);
            this.panel2.TabIndex = 96;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(567, 11);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 20);
            this.label23.TabIndex = 48;
            this.label23.Text = "Staff";
            // 
            // cmb_staff
            // 
            this.cmb_staff.FormattingEnabled = true;
            this.cmb_staff.Location = new System.Drawing.Point(571, 43);
            this.cmb_staff.Name = "cmb_staff";
            this.cmb_staff.Size = new System.Drawing.Size(232, 24);
            this.cmb_staff.TabIndex = 47;
            // 
            // cmb_Status
            // 
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Location = new System.Drawing.Point(283, 124);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(197, 24);
            this.cmb_Status.TabIndex = 46;
            // 
            // nup_Quantity
            // 
            this.nup_Quantity.Location = new System.Drawing.Point(283, 218);
            this.nup_Quantity.Name = "nup_Quantity";
            this.nup_Quantity.Size = new System.Drawing.Size(84, 22);
            this.nup_Quantity.TabIndex = 45;
            this.nup_Quantity.ValueChanged += new System.EventHandler(this.nup_Quantity_ValueChanged);
            // 
            // cmb_Deliverymethod
            // 
            this.cmb_Deliverymethod.FormattingEnabled = true;
            this.cmb_Deliverymethod.Location = new System.Drawing.Point(19, 215);
            this.cmb_Deliverymethod.Name = "cmb_Deliverymethod";
            this.cmb_Deliverymethod.Size = new System.Drawing.Size(197, 24);
            this.cmb_Deliverymethod.TabIndex = 29;
            // 
            // cmb_Suporder
            // 
            this.cmb_Suporder.FormattingEnabled = true;
            this.cmb_Suporder.Location = new System.Drawing.Point(17, 124);
            this.cmb_Suporder.Name = "cmb_Suporder";
            this.cmb_Suporder.Size = new System.Drawing.Size(197, 24);
            this.cmb_Suporder.TabIndex = 28;
            this.cmb_Suporder.SelectedIndexChanged += new System.EventHandler(this.cmb_Suporder_SelectedIndexChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.label28.Location = new System.Drawing.Point(15, 181);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(204, 20);
            this.label28.TabIndex = 24;
            this.label28.Text = "Delivery Method";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(279, 91);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(87, 20);
            this.label27.TabIndex = 23;
            this.label27.Text = "Status";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(15, 91);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(113, 20);
            this.label26.TabIndex = 22;
            this.label26.Text = "Supplier";
            // 
            // lbl_Discount_Cusorder
            // 
            this.lbl_Discount_Cusorder.AutoSize = true;
            this.lbl_Discount_Cusorder.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Discount_Cusorder.Location = new System.Drawing.Point(822, 124);
            this.lbl_Discount_Cusorder.Name = "lbl_Discount_Cusorder";
            this.lbl_Discount_Cusorder.Size = new System.Drawing.Size(48, 20);
            this.lbl_Discount_Cusorder.TabIndex = 20;
            this.lbl_Discount_Cusorder.Text = "10%";
            // 
            // lbl_Finalpayment_Cusorder
            // 
            this.lbl_Finalpayment_Cusorder.AutoSize = true;
            this.lbl_Finalpayment_Cusorder.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Finalpayment_Cusorder.Location = new System.Drawing.Point(783, 171);
            this.lbl_Finalpayment_Cusorder.Name = "lbl_Finalpayment_Cusorder";
            this.lbl_Finalpayment_Cusorder.Size = new System.Drawing.Size(87, 20);
            this.lbl_Finalpayment_Cusorder.TabIndex = 19;
            this.lbl_Finalpayment_Cusorder.Text = "950.00";
            // 
            // lbl_Totalamount
            // 
            this.lbl_Totalamount.AutoSize = true;
            this.lbl_Totalamount.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Totalamount.Location = new System.Drawing.Point(770, 91);
            this.lbl_Totalamount.Name = "lbl_Totalamount";
            this.lbl_Totalamount.Size = new System.Drawing.Size(100, 20);
            this.lbl_Totalamount.TabIndex = 18;
            this.lbl_Totalamount.Text = "1000.00";
            // 
            // cmb_Book
            // 
            this.cmb_Book.FormattingEnabled = true;
            this.cmb_Book.Location = new System.Drawing.Point(283, 43);
            this.cmb_Book.Name = "cmb_Book";
            this.cmb_Book.Size = new System.Drawing.Size(232, 24);
            this.cmb_Book.TabIndex = 16;
            this.cmb_Book.SelectedIndexChanged += new System.EventHandler(this.cmb_Book_SelectedIndexChanged);
            // 
            // cmb_customer
            // 
            this.cmb_customer.FormattingEnabled = true;
            this.cmb_customer.Location = new System.Drawing.Point(19, 43);
            this.cmb_customer.Name = "cmb_customer";
            this.cmb_customer.Size = new System.Drawing.Size(197, 24);
            this.cmb_customer.TabIndex = 15;
            this.cmb_customer.SelectedIndexChanged += new System.EventHandler(this.cmb_customer_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(567, 171);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(178, 20);
            this.label22.TabIndex = 14;
            this.label22.Text = "Final Payment";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(567, 128);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 20);
            this.label21.TabIndex = 12;
            this.label21.Text = "Discount";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(567, 91);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(165, 20);
            this.label20.TabIndex = 10;
            this.label20.Text = "Total Amount";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(279, 181);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 20);
            this.label19.TabIndex = 8;
            this.label19.Text = "Quantity";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(279, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 20);
            this.label18.TabIndex = 6;
            this.label18.Text = "Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer";
            // 
            // dgv_cusOrder
            // 
            this.dgv_cusOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_cusOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cusOrder.Location = new System.Drawing.Point(12, 444);
            this.dgv_cusOrder.Name = "dgv_cusOrder";
            this.dgv_cusOrder.RowHeadersWidth = 51;
            this.dgv_cusOrder.RowTemplate.Height = 24;
            this.dgv_cusOrder.Size = new System.Drawing.Size(1315, 256);
            this.dgv_cusOrder.TabIndex = 100;
            this.dgv_cusOrder.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cusOrder_CellContentDoubleClick);
            // 
            // btn_deleteorder
            // 
            this.btn_deleteorder.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_deleteorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_deleteorder.Location = new System.Drawing.Point(1080, 353);
            this.btn_deleteorder.Name = "btn_deleteorder";
            this.btn_deleteorder.Size = new System.Drawing.Size(247, 67);
            this.btn_deleteorder.TabIndex = 99;
            this.btn_deleteorder.Text = "Delete Order";
            this.btn_deleteorder.UseVisualStyleBackColor = true;
            this.btn_deleteorder.Click += new System.EventHandler(this.btn_deleteorder_Click);
            // 
            // btn_updateorder
            // 
            this.btn_updateorder.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_updateorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_updateorder.Location = new System.Drawing.Point(1080, 111);
            this.btn_updateorder.Name = "btn_updateorder";
            this.btn_updateorder.Size = new System.Drawing.Size(247, 67);
            this.btn_updateorder.TabIndex = 98;
            this.btn_updateorder.Text = "Update Order";
            this.btn_updateorder.UseVisualStyleBackColor = true;
            this.btn_updateorder.Click += new System.EventHandler(this.btn_updateorder_Click);
            // 
            // btn_makeorder
            // 
            this.btn_makeorder.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_makeorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_makeorder.Location = new System.Drawing.Point(1080, 235);
            this.btn_makeorder.Name = "btn_makeorder";
            this.btn_makeorder.Size = new System.Drawing.Size(247, 67);
            this.btn_makeorder.TabIndex = 97;
            this.btn_makeorder.Text = "Make Order";
            this.btn_makeorder.UseVisualStyleBackColor = true;
            this.btn_makeorder.Click += new System.EventHandler(this.btn_makeorder_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(131)))), ((int)(((byte)(146)))));
            this.panel3.Controls.Add(this.btn_logout);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1369, 88);
            this.panel3.TabIndex = 102;
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
            this.pictureBox1.Location = new System.Drawing.Point(1274, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(69)))), ((int)(((byte)(89)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Book);
            this.panel1.Controls.Add(this.btn_Cusorder);
            this.panel1.Controls.Add(this.btn_Sales);
            this.panel1.Controls.Add(this.btn_Customer);
            this.panel1.Controls.Add(this.btn_overview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.panel1.Location = new System.Drawing.Point(1369, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 736);
            this.panel1.TabIndex = 101;
            // 
            // btn_Book
            // 
            this.btn_Book.BackColor = System.Drawing.Color.White;
            this.btn_Book.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Book.Location = new System.Drawing.Point(23, 636);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(237, 63);
            this.btn_Book.TabIndex = 5;
            this.btn_Book.Text = "Book";
            this.btn_Book.UseVisualStyleBackColor = false;
            // 
            // btn_Cusorder
            // 
            this.btn_Cusorder.BackColor = System.Drawing.Color.White;
            this.btn_Cusorder.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Cusorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Cusorder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cusorder.Location = new System.Drawing.Point(23, 472);
            this.btn_Cusorder.Name = "btn_Cusorder";
            this.btn_Cusorder.Size = new System.Drawing.Size(237, 63);
            this.btn_Cusorder.TabIndex = 3;
            this.btn_Cusorder.Text = "Cus Order";
            this.btn_Cusorder.UseVisualStyleBackColor = false;
            // 
            // btn_Sales
            // 
            this.btn_Sales.BackColor = System.Drawing.Color.White;
            this.btn_Sales.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Sales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Sales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sales.Location = new System.Drawing.Point(23, 160);
            this.btn_Sales.Name = "btn_Sales";
            this.btn_Sales.Size = new System.Drawing.Size(237, 63);
            this.btn_Sales.TabIndex = 2;
            this.btn_Sales.Text = "Sales";
            this.btn_Sales.UseVisualStyleBackColor = false;
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.Color.White;
            this.btn_Customer.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Customer.Location = new System.Drawing.Point(23, 306);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(237, 63);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.UseVisualStyleBackColor = false;
            // 
            // btn_overview
            // 
            this.btn_overview.BackColor = System.Drawing.Color.White;
            this.btn_overview.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_overview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_overview.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_overview.Location = new System.Drawing.Point(23, 24);
            this.btn_overview.Name = "btn_overview";
            this.btn_overview.Size = new System.Drawing.Size(237, 63);
            this.btn_overview.TabIndex = 0;
            this.btn_overview.Text = "Overview";
            this.btn_overview.UseVisualStyleBackColor = false;
            // 
            // Clerk_CustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 736);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_cusOrder);
            this.Controls.Add(this.btn_deleteorder);
            this.Controls.Add(this.btn_updateorder);
            this.Controls.Add(this.btn_makeorder);
            this.Name = "Clerk_CustomerOrder";
            this.Text = "Clerk_CustomerOrder";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cusOrder)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmb_staff;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.NumericUpDown nup_Quantity;
        private System.Windows.Forms.ComboBox cmb_Deliverymethod;
        private System.Windows.Forms.ComboBox cmb_Suporder;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lbl_Discount_Cusorder;
        private System.Windows.Forms.Label lbl_Finalpayment_Cusorder;
        private System.Windows.Forms.Label lbl_Totalamount;
        private System.Windows.Forms.ComboBox cmb_Book;
        private System.Windows.Forms.ComboBox cmb_customer;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_cusOrder;
        private System.Windows.Forms.Button btn_deleteorder;
        private System.Windows.Forms.Button btn_updateorder;
        private System.Windows.Forms.Button btn_makeorder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.Button btn_Cusorder;
        private System.Windows.Forms.Button btn_Sales;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_overview;
    }
}