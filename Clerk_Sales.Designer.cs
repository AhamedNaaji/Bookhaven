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
            this.dgv_sales = new System.Windows.Forms.DataGridView();
            this.btn_deleteSales = new System.Windows.Forms.Button();
            this.btn_updateSales = new System.Windows.Forms.Button();
            this.btn_addSales = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelFinalPayment = new System.Windows.Forms.Label();
            this.label_TotalAmount = new System.Windows.Forms.Label();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.comboBook = new System.Windows.Forms.ComboBox();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Book = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cusorder = new System.Windows.Forms.Button();
            this.btn_Sales = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_overview = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_sales
            // 
            this.dgv_sales.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sales.Location = new System.Drawing.Point(389, 553);
            this.dgv_sales.Name = "dgv_sales";
            this.dgv_sales.RowHeadersWidth = 51;
            this.dgv_sales.RowTemplate.Height = 24;
            this.dgv_sales.Size = new System.Drawing.Size(1118, 210);
            this.dgv_sales.TabIndex = 88;
            this.dgv_sales.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sales_CellContentDoubleClick);
            // 
            // btn_deleteSales
            // 
            this.btn_deleteSales.BackColor = System.Drawing.Color.Red;
            this.btn_deleteSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteSales.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_deleteSales.Location = new System.Drawing.Point(20, 219);
            this.btn_deleteSales.Name = "btn_deleteSales";
            this.btn_deleteSales.Size = new System.Drawing.Size(247, 67);
            this.btn_deleteSales.TabIndex = 87;
            this.btn_deleteSales.Text = "Delete Sales";
            this.btn_deleteSales.UseVisualStyleBackColor = false;
            this.btn_deleteSales.Click += new System.EventHandler(this.btn_deleteSales_Click);
            // 
            // btn_updateSales
            // 
            this.btn_updateSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_updateSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateSales.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_updateSales.Location = new System.Drawing.Point(20, 123);
            this.btn_updateSales.Name = "btn_updateSales";
            this.btn_updateSales.Size = new System.Drawing.Size(247, 67);
            this.btn_updateSales.TabIndex = 86;
            this.btn_updateSales.Text = "Update Sales";
            this.btn_updateSales.UseVisualStyleBackColor = false;
            this.btn_updateSales.Click += new System.EventHandler(this.btn_updateSales_Click);
            // 
            // btn_addSales
            // 
            this.btn_addSales.BackColor = System.Drawing.Color.Lime;
            this.btn_addSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addSales.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_addSales.Location = new System.Drawing.Point(20, 28);
            this.btn_addSales.Name = "btn_addSales";
            this.btn_addSales.Size = new System.Drawing.Size(247, 67);
            this.btn_addSales.TabIndex = 85;
            this.btn_addSales.Text = "Make Sales";
            this.btn_addSales.UseVisualStyleBackColor = false;
            this.btn_addSales.Click += new System.EventHandler(this.btn_addSales_Click);
            // 
            // panel2
            // 
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
            this.panel2.Location = new System.Drawing.Point(389, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 309);
            this.panel2.TabIndex = 84;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(599, 11);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 36);
            this.label23.TabIndex = 22;
            this.label23.Text = "Date";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(603, 45);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDate.TabIndex = 21;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(19, 246);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(33, 16);
            this.labelDiscount.TabIndex = 20;
            this.labelDiscount.Text = "10%";
            // 
            // labelFinalPayment
            // 
            this.labelFinalPayment.AutoSize = true;
            this.labelFinalPayment.Location = new System.Drawing.Point(303, 246);
            this.labelFinalPayment.Name = "labelFinalPayment";
            this.labelFinalPayment.Size = new System.Drawing.Size(45, 16);
            this.labelFinalPayment.TabIndex = 19;
            this.labelFinalPayment.Text = "950.00";
            // 
            // label_TotalAmount
            // 
            this.label_TotalAmount.AutoSize = true;
            this.label_TotalAmount.Location = new System.Drawing.Point(511, 131);
            this.label_TotalAmount.Name = "label_TotalAmount";
            this.label_TotalAmount.Size = new System.Drawing.Size(0, 16);
            this.label_TotalAmount.TabIndex = 18;
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(20, 160);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(51, 22);
            this.numericQuantity.TabIndex = 17;
            this.numericQuantity.ValueChanged += new System.EventHandler(this.numericQuantity_ValueChanged);
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
            // comboCustomer
            // 
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.Location = new System.Drawing.Point(19, 43);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(197, 24);
            this.comboCustomer.TabIndex = 15;
            this.comboCustomer.SelectedIndexChanged += new System.EventHandler(this.comboCustomer_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(300, 210);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(171, 36);
            this.label22.TabIndex = 14;
            this.label22.Text = "Final Payment";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(13, 210);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 36);
            this.label21.TabIndex = 12;
            this.label21.Text = "Discount";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(298, 121);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(163, 36);
            this.label20.TabIndex = 10;
            this.label20.Text = "Total Amount";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(14, 121);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 36);
            this.label19.TabIndex = 8;
            this.label19.Text = "Quantity";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(300, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 36);
            this.label18.TabIndex = 6;
            this.label18.Text = "Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(354, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1677, 159);
            this.panel3.TabIndex = 90;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(966, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
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
            this.panel1.Controls.Add(this.btn_Book);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Cusorder);
            this.panel1.Controls.Add(this.btn_Sales);
            this.panel1.Controls.Add(this.btn_Customer);
            this.panel1.Controls.Add(this.btn_overview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 783);
            this.panel1.TabIndex = 89;
            // 
            // btn_Book
            // 
            this.btn_Book.BackColor = System.Drawing.Color.White;
            this.btn_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Book.ForeColor = System.Drawing.Color.Black;
            this.btn_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Book.Location = new System.Drawing.Point(50, 609);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(243, 63);
            this.btn_Book.TabIndex = 5;
            this.btn_Book.Text = "Book Details";
            this.btn_Book.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 58);
            this.label1.TabIndex = 8;
            this.label1.Text = "Book Heaven";
            // 
            // btn_Cusorder
            // 
            this.btn_Cusorder.BackColor = System.Drawing.Color.White;
            this.btn_Cusorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cusorder.ForeColor = System.Drawing.Color.Black;
            this.btn_Cusorder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cusorder.Location = new System.Drawing.Point(50, 502);
            this.btn_Cusorder.Name = "btn_Cusorder";
            this.btn_Cusorder.Size = new System.Drawing.Size(243, 63);
            this.btn_Cusorder.TabIndex = 3;
            this.btn_Cusorder.Text = "Customer Order";
            this.btn_Cusorder.UseVisualStyleBackColor = false;
            // 
            // btn_Sales
            // 
            this.btn_Sales.BackColor = System.Drawing.Color.White;
            this.btn_Sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sales.ForeColor = System.Drawing.Color.Black;
            this.btn_Sales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sales.Location = new System.Drawing.Point(50, 397);
            this.btn_Sales.Name = "btn_Sales";
            this.btn_Sales.Size = new System.Drawing.Size(243, 63);
            this.btn_Sales.TabIndex = 2;
            this.btn_Sales.Text = "Sales Details";
            this.btn_Sales.UseVisualStyleBackColor = false;
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.Color.White;
            this.btn_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.Black;
            this.btn_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Customer.Location = new System.Drawing.Point(50, 288);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(243, 63);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "Customer Details";
            this.btn_Customer.UseVisualStyleBackColor = false;
            // 
            // btn_overview
            // 
            this.btn_overview.BackColor = System.Drawing.Color.White;
            this.btn_overview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_overview.ForeColor = System.Drawing.Color.Black;
            this.btn_overview.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_overview.Location = new System.Drawing.Point(50, 188);
            this.btn_overview.Name = "btn_overview";
            this.btn_overview.Size = new System.Drawing.Size(243, 63);
            this.btn_overview.TabIndex = 0;
            this.btn_overview.Text = "Dashboard";
            this.btn_overview.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_deleteSales);
            this.panel4.Controls.Add(this.btn_updateSales);
            this.panel4.Controls.Add(this.btn_addSales);
            this.panel4.Location = new System.Drawing.Point(1218, 201);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 310);
            this.panel4.TabIndex = 91;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.button4.Location = new System.Drawing.Point(1805, 570);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(246, 69);
            this.button4.TabIndex = 94;
            this.button4.Text = "Remove Book";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.Lime;
            this.btnAddBook.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btnAddBook.Location = new System.Drawing.Point(1531, 570);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(251, 64);
            this.btnAddBook.TabIndex = 93;
            this.btnAddBook.Text = "Add to cart";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // dgv_books
            // 
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Location = new System.Drawing.Point(1531, 201);
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.RowHeadersWidth = 51;
            this.dgv_books.RowTemplate.Height = 24;
            this.dgv_books.Size = new System.Drawing.Size(520, 345);
            this.dgv_books.TabIndex = 92;
            // 
            // Clerk_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2031, 783);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.dgv_books);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_sales);
            this.Controls.Add(this.panel2);
            this.Name = "Clerk_Sales";
            this.Text = "Clerk_Sales";
            this.Load += new System.EventHandler(this.Clerk_Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_sales;
        private System.Windows.Forms.Button btn_deleteSales;
        private System.Windows.Forms.Button btn_updateSales;
        private System.Windows.Forms.Button btn_addSales;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cusorder;
        private System.Windows.Forms.Button btn_Sales;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_overview;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.DataGridView dgv_books;
    }
}