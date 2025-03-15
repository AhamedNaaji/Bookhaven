namespace Bookhaven
{
    partial class Clerk_Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clerk_Sales));
            this.dgv_sales = new System.Windows.Forms.DataGridView();
            this.btn_deleteSales = new System.Windows.Forms.Button();
            this.btn_updateSales = new System.Windows.Forms.Button();
            this.btn_addSales = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.comboBook = new System.Windows.Forms.ComboBox();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.label_TotalAmount = new System.Windows.Forms.Label();
            this.labelFinalPayment = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.comboStaff = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Book = new System.Windows.Forms.Button();
            this.btn_Cusorder = new System.Windows.Forms.Button();
            this.btn_Sales = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_overview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_sales
            // 
            this.dgv_sales.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sales.Location = new System.Drawing.Point(19, 473);
            this.dgv_sales.Name = "dgv_sales";
            this.dgv_sales.RowHeadersWidth = 51;
            this.dgv_sales.RowTemplate.Height = 24;
            this.dgv_sales.Size = new System.Drawing.Size(1130, 221);
            this.dgv_sales.TabIndex = 88;
            this.dgv_sales.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sales_CellContentDoubleClick);
            // 
            // btn_deleteSales
            // 
            this.btn_deleteSales.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_deleteSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_deleteSales.Location = new System.Drawing.Point(902, 361);
            this.btn_deleteSales.Name = "btn_deleteSales";
            this.btn_deleteSales.Size = new System.Drawing.Size(247, 67);
            this.btn_deleteSales.TabIndex = 87;
            this.btn_deleteSales.Text = "Delete Sales";
            this.btn_deleteSales.UseVisualStyleBackColor = true;
            this.btn_deleteSales.Click += new System.EventHandler(this.btn_deleteSales_Click);
            // 
            // btn_updateSales
            // 
            this.btn_updateSales.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_updateSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_updateSales.Location = new System.Drawing.Point(902, 243);
            this.btn_updateSales.Name = "btn_updateSales";
            this.btn_updateSales.Size = new System.Drawing.Size(247, 67);
            this.btn_updateSales.TabIndex = 86;
            this.btn_updateSales.Text = "Update Sales";
            this.btn_updateSales.UseVisualStyleBackColor = true;
            this.btn_updateSales.Click += new System.EventHandler(this.btn_updateSales_Click);
            // 
            // btn_addSales
            // 
            this.btn_addSales.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_addSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_addSales.Location = new System.Drawing.Point(902, 140);
            this.btn_addSales.Name = "btn_addSales";
            this.btn_addSales.Size = new System.Drawing.Size(247, 67);
            this.btn_addSales.TabIndex = 85;
            this.btn_addSales.Text = "Make Sales";
            this.btn_addSales.UseVisualStyleBackColor = true;
            this.btn_addSales.Click += new System.EventHandler(this.btn_addSales_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.comboStaff);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.dateTimePickerDate);
            this.panel2.Controls.Add(this.labelDiscount);
            this.panel2.Controls.Add(this.labelFinalPayment);
            this.panel2.Controls.Add(this.label_TotalAmount);
            this.panel2.Controls.Add(this.numericQuantity);
            this.panel2.Controls.Add(this.comboBook);
            this.panel2.Controls.Add(this.comboCustomer);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(19, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 288);
            this.panel2.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(312, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 24);
            this.label18.TabIndex = 6;
            this.label18.Text = "Book";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(15, 129);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 24);
            this.label19.TabIndex = 8;
            this.label19.Text = "Quantity";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(312, 125);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(128, 24);
            this.label20.TabIndex = 10;
            this.label20.Text = "Total Amount";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(15, 217);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 24);
            this.label21.TabIndex = 12;
            this.label21.Text = "Discount";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(312, 217);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(133, 24);
            this.label22.TabIndex = 14;
            this.label22.Text = "Final Payment";
            // 
            // comboCustomer
            // 
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.Location = new System.Drawing.Point(19, 43);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(197, 24);
            this.comboCustomer.TabIndex = 15;
            this.comboCustomer.SelectedIndexChanged += new System.EventHandler(this.comboCustomer_SelectedIndexChanged);
            // 
            // comboBook
            // 
            this.comboBook.FormattingEnabled = true;
            this.comboBook.Location = new System.Drawing.Point(306, 43);
            this.comboBook.Name = "comboBook";
            this.comboBook.Size = new System.Drawing.Size(232, 24);
            this.comboBook.TabIndex = 16;
            this.comboBook.SelectedIndexChanged += new System.EventHandler(this.comboBook_SelectedIndexChanged);
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(128, 130);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(51, 22);
            this.numericQuantity.TabIndex = 17;
            this.numericQuantity.ValueChanged += new System.EventHandler(this.numericQuantity_ValueChanged);
            // 
            // label_TotalAmount
            // 
            this.label_TotalAmount.AutoSize = true;
            this.label_TotalAmount.Location = new System.Drawing.Point(511, 131);
            this.label_TotalAmount.Name = "label_TotalAmount";
            this.label_TotalAmount.Size = new System.Drawing.Size(0, 16);
            this.label_TotalAmount.TabIndex = 18;
            // 
            // labelFinalPayment
            // 
            this.labelFinalPayment.AutoSize = true;
            this.labelFinalPayment.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.labelFinalPayment.Location = new System.Drawing.Point(517, 217);
            this.labelFinalPayment.Name = "labelFinalPayment";
            this.labelFinalPayment.Size = new System.Drawing.Size(67, 24);
            this.labelFinalPayment.TabIndex = 19;
            this.labelFinalPayment.Text = "950.00";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.labelDiscount.Location = new System.Drawing.Point(127, 223);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(47, 24);
            this.labelDiscount.TabIndex = 20;
            this.labelDiscount.Text = "10%";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerDate.Location = new System.Drawing.Point(592, 43);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(211, 32);
            this.dateTimePickerDate.TabIndex = 21;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(599, 11);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 24);
            this.label23.TabIndex = 22;
            this.label23.Text = "Date";
            // 
            // comboStaff
            // 
            this.comboStaff.FormattingEnabled = true;
            this.comboStaff.Location = new System.Drawing.Point(603, 152);
            this.comboStaff.Name = "comboStaff";
            this.comboStaff.Size = new System.Drawing.Size(200, 24);
            this.comboStaff.TabIndex = 23;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(599, 124);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 24);
            this.label24.TabIndex = 24;
            this.label24.Text = "Staff";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(131)))), ((int)(((byte)(146)))));
            this.panel3.Controls.Add(this.btn_logout);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1183, 88);
            this.panel3.TabIndex = 104;
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
            this.pictureBox1.Location = new System.Drawing.Point(1085, 3);
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
            this.panel1.Location = new System.Drawing.Point(1183, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 727);
            this.panel1.TabIndex = 103;
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
            // Clerk_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 727);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_sales);
            this.Controls.Add(this.btn_deleteSales);
            this.Controls.Add(this.btn_updateSales);
            this.Controls.Add(this.btn_addSales);
            this.Controls.Add(this.panel2);
            this.Name = "Clerk_Sales";
            this.Text = "Clerk_Sales";
            this.Load += new System.EventHandler(this.Clerk_Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_sales;
        private System.Windows.Forms.Button btn_deleteSales;
        private System.Windows.Forms.Button btn_updateSales;
        private System.Windows.Forms.Button btn_addSales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox comboStaff;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelFinalPayment;
        private System.Windows.Forms.Label label_TotalAmount;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.ComboBox comboBook;
        private System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
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