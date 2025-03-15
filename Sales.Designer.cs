namespace Bookhaven
{
    partial class Sales
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.comboStaff = new System.Windows.Forms.ComboBox();
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
            this.btn_deleteSales = new System.Windows.Forms.Button();
            this.btn_updateSales = new System.Windows.Forms.Button();
            this.btn_addSales = new System.Windows.Forms.Button();
            this.dgv_sales = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Reports = new System.Windows.Forms.Button();
            this.btn_Suppliers = new System.Windows.Forms.Button();
            this.btn_Staffs = new System.Windows.Forms.Button();
            this.btn_Books = new System.Windows.Forms.Button();
            this.btn_SupplierOrders = new System.Windows.Forms.Button();
            this.btn_CustomerOrders = new System.Windows.Forms.Button();
            this.btn_Sales = new System.Windows.Forms.Button();
            this.btn_Customers = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea11.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart1.Legends.Add(legend11);
            this.chart1.Location = new System.Drawing.Point(1595, 1244);
            this.chart1.Name = "chart1";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chart1.Series.Add(series11);
            this.chart1.Size = new System.Drawing.Size(2095, 733);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
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
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(530, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 271);
            this.panel2.TabIndex = 30;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(599, 124);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 23);
            this.label24.TabIndex = 24;
            this.label24.Text = "Staff";
            // 
            // comboStaff
            // 
            this.comboStaff.FormattingEnabled = true;
            this.comboStaff.Location = new System.Drawing.Point(603, 152);
            this.comboStaff.Name = "comboStaff";
            this.comboStaff.Size = new System.Drawing.Size(200, 28);
            this.comboStaff.TabIndex = 23;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(599, 11);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 23);
            this.label23.TabIndex = 22;
            this.label23.Text = "Date";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(603, 45);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerDate.TabIndex = 21;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(127, 223);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(42, 20);
            this.labelDiscount.TabIndex = 20;
            this.labelDiscount.Text = "10%";
            // 
            // labelFinalPayment
            // 
            this.labelFinalPayment.AutoSize = true;
            this.labelFinalPayment.Location = new System.Drawing.Point(517, 217);
            this.labelFinalPayment.Name = "labelFinalPayment";
            this.labelFinalPayment.Size = new System.Drawing.Size(58, 20);
            this.labelFinalPayment.TabIndex = 19;
            this.labelFinalPayment.Text = "950.00";
            // 
            // label_TotalAmount
            // 
            this.label_TotalAmount.AutoSize = true;
            this.label_TotalAmount.Location = new System.Drawing.Point(511, 131);
            this.label_TotalAmount.Name = "label_TotalAmount";
            this.label_TotalAmount.Size = new System.Drawing.Size(0, 20);
            this.label_TotalAmount.TabIndex = 18;
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(128, 130);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(51, 27);
            this.numericQuantity.TabIndex = 17;
            this.numericQuantity.ValueChanged += new System.EventHandler(this.numericQuantity_ValueChanged_1);
            // 
            // comboBook
            // 
            this.comboBook.FormattingEnabled = true;
            this.comboBook.Location = new System.Drawing.Point(306, 43);
            this.comboBook.Name = "comboBook";
            this.comboBook.Size = new System.Drawing.Size(232, 28);
            this.comboBook.TabIndex = 16;
            this.comboBook.SelectedIndexChanged += new System.EventHandler(this.comboBook_SelectedIndexChanged_1);
            // 
            // comboCustomer
            // 
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.Location = new System.Drawing.Point(19, 43);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(197, 28);
            this.comboCustomer.TabIndex = 15;
            this.comboCustomer.SelectedIndexChanged += new System.EventHandler(this.comboCustomer_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(312, 217);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(147, 23);
            this.label22.TabIndex = 14;
            this.label22.Text = "Final Payment";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(15, 217);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 23);
            this.label21.TabIndex = 12;
            this.label21.Text = "Discount";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(312, 125);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(138, 23);
            this.label20.TabIndex = 10;
            this.label20.Text = "Total Amount";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(15, 129);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 23);
            this.label19.TabIndex = 8;
            this.label19.Text = "Quantity";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(312, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 23);
            this.label18.TabIndex = 6;
            this.label18.Text = "Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer";
            // 
            // btn_deleteSales
            // 
            this.btn_deleteSales.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_deleteSales.Location = new System.Drawing.Point(1061, 419);
            this.btn_deleteSales.Name = "btn_deleteSales";
            this.btn_deleteSales.Size = new System.Drawing.Size(247, 67);
            this.btn_deleteSales.TabIndex = 33;
            this.btn_deleteSales.Text = "Delete Sales";
            this.btn_deleteSales.UseVisualStyleBackColor = true;
            this.btn_deleteSales.Click += new System.EventHandler(this.btn_deleteSales_Click);
            // 
            // btn_updateSales
            // 
            this.btn_updateSales.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_updateSales.Location = new System.Drawing.Point(794, 419);
            this.btn_updateSales.Name = "btn_updateSales";
            this.btn_updateSales.Size = new System.Drawing.Size(247, 67);
            this.btn_updateSales.TabIndex = 32;
            this.btn_updateSales.Text = "Update Sales";
            this.btn_updateSales.UseVisualStyleBackColor = true;
            this.btn_updateSales.Click += new System.EventHandler(this.btn_updateSales_Click);
            // 
            // btn_addSales
            // 
            this.btn_addSales.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_addSales.Location = new System.Drawing.Point(530, 419);
            this.btn_addSales.Name = "btn_addSales";
            this.btn_addSales.Size = new System.Drawing.Size(247, 67);
            this.btn_addSales.TabIndex = 31;
            this.btn_addSales.Text = "Make Sales";
            this.btn_addSales.UseVisualStyleBackColor = true;
            this.btn_addSales.Click += new System.EventHandler(this.btn_addSales_Click);
            // 
            // dgv_sales
            // 
            this.dgv_sales.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sales.Location = new System.Drawing.Point(530, 513);
            this.dgv_sales.Name = "dgv_sales";
            this.dgv_sales.RowHeadersWidth = 51;
            this.dgv_sales.RowTemplate.Height = 24;
            this.dgv_sales.Size = new System.Drawing.Size(932, 428);
            this.dgv_sales.TabIndex = 34;
            this.dgv_sales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sales_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.panel3.Controls.Add(this.btn_Logout);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(458, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1466, 97);
            this.panel3.TabIndex = 36;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Red;
            this.btn_Logout.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Logout.Location = new System.Drawing.Point(1411, 24);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(115, 45);
            this.btn_Logout.TabIndex = 24;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(11, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(403, 56);
            this.label8.TabIndex = 23;
            this.label8.Text = "Welcome Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.btn_Reports);
            this.panel1.Controls.Add(this.btn_Suppliers);
            this.panel1.Controls.Add(this.btn_Staffs);
            this.panel1.Controls.Add(this.btn_Books);
            this.panel1.Controls.Add(this.btn_SupplierOrders);
            this.panel1.Controls.Add(this.btn_CustomerOrders);
            this.panel1.Controls.Add(this.btn_Sales);
            this.panel1.Controls.Add(this.btn_Customers);
            this.panel1.Controls.Add(this.btn_Dashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 1000);
            this.panel1.TabIndex = 35;
            // 
            // btn_Reports
            // 
            this.btn_Reports.BackColor = System.Drawing.Color.White;
            this.btn_Reports.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Reports.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reports.Location = new System.Drawing.Point(76, 883);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Size = new System.Drawing.Size(258, 58);
            this.btn_Reports.TabIndex = 8;
            this.btn_Reports.Text = "Reports";
            this.btn_Reports.UseVisualStyleBackColor = false;
            this.btn_Reports.Click += new System.EventHandler(this.btn_Reports_Click);
            // 
            // btn_Suppliers
            // 
            this.btn_Suppliers.BackColor = System.Drawing.Color.White;
            this.btn_Suppliers.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Suppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Suppliers.Location = new System.Drawing.Point(76, 453);
            this.btn_Suppliers.Name = "btn_Suppliers";
            this.btn_Suppliers.Size = new System.Drawing.Size(258, 55);
            this.btn_Suppliers.TabIndex = 7;
            this.btn_Suppliers.Text = "Suppliers";
            this.btn_Suppliers.UseVisualStyleBackColor = false;
            this.btn_Suppliers.Click += new System.EventHandler(this.btn_Suppliers_Click);
            // 
            // btn_Staffs
            // 
            this.btn_Staffs.BackColor = System.Drawing.Color.White;
            this.btn_Staffs.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staffs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Staffs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Staffs.Location = new System.Drawing.Point(76, 284);
            this.btn_Staffs.Name = "btn_Staffs";
            this.btn_Staffs.Size = new System.Drawing.Size(258, 58);
            this.btn_Staffs.TabIndex = 6;
            this.btn_Staffs.Text = "Staffs";
            this.btn_Staffs.UseVisualStyleBackColor = false;
            this.btn_Staffs.Click += new System.EventHandler(this.btn_Staffs_Click);
            // 
            // btn_Books
            // 
            this.btn_Books.BackColor = System.Drawing.Color.White;
            this.btn_Books.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Books.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Books.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Books.Location = new System.Drawing.Point(76, 536);
            this.btn_Books.Name = "btn_Books";
            this.btn_Books.Size = new System.Drawing.Size(258, 58);
            this.btn_Books.TabIndex = 5;
            this.btn_Books.Text = "Books";
            this.btn_Books.UseVisualStyleBackColor = false;
            this.btn_Books.Click += new System.EventHandler(this.btn_Books_Click);
            // 
            // btn_SupplierOrders
            // 
            this.btn_SupplierOrders.BackColor = System.Drawing.Color.White;
            this.btn_SupplierOrders.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SupplierOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_SupplierOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SupplierOrders.Location = new System.Drawing.Point(76, 798);
            this.btn_SupplierOrders.Name = "btn_SupplierOrders";
            this.btn_SupplierOrders.Size = new System.Drawing.Size(258, 58);
            this.btn_SupplierOrders.TabIndex = 4;
            this.btn_SupplierOrders.Text = "Supplier Orders";
            this.btn_SupplierOrders.UseVisualStyleBackColor = false;
            this.btn_SupplierOrders.Click += new System.EventHandler(this.btn_SupplierOrders_Click);
            // 
            // btn_CustomerOrders
            // 
            this.btn_CustomerOrders.BackColor = System.Drawing.Color.White;
            this.btn_CustomerOrders.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_CustomerOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CustomerOrders.Location = new System.Drawing.Point(76, 711);
            this.btn_CustomerOrders.Name = "btn_CustomerOrders";
            this.btn_CustomerOrders.Size = new System.Drawing.Size(258, 58);
            this.btn_CustomerOrders.TabIndex = 3;
            this.btn_CustomerOrders.Text = "Customer Orders";
            this.btn_CustomerOrders.UseVisualStyleBackColor = false;
            this.btn_CustomerOrders.Click += new System.EventHandler(this.btn_CustomerOrders_Click);
            // 
            // btn_Sales
            // 
            this.btn_Sales.BackColor = System.Drawing.Color.Silver;
            this.btn_Sales.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Sales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sales.Location = new System.Drawing.Point(76, 625);
            this.btn_Sales.Name = "btn_Sales";
            this.btn_Sales.Size = new System.Drawing.Size(258, 58);
            this.btn_Sales.TabIndex = 2;
            this.btn_Sales.Text = "Sales";
            this.btn_Sales.UseVisualStyleBackColor = false;
            this.btn_Sales.Click += new System.EventHandler(this.btn_Sales_Click);
            // 
            // btn_Customers
            // 
            this.btn_Customers.BackColor = System.Drawing.Color.White;
            this.btn_Customers.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Customers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Customers.Location = new System.Drawing.Point(76, 367);
            this.btn_Customers.Name = "btn_Customers";
            this.btn_Customers.Size = new System.Drawing.Size(258, 58);
            this.btn_Customers.TabIndex = 1;
            this.btn_Customers.Text = "Customers";
            this.btn_Customers.UseVisualStyleBackColor = false;
            this.btn_Customers.Click += new System.EventHandler(this.btn_Customers_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.White;
            this.btn_Dashboard.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Dashboard.Location = new System.Drawing.Point(76, 201);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(258, 58);
            this.btn_Dashboard.TabIndex = 0;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(1924, 1000);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_sales);
            this.Controls.Add(this.btn_deleteSales);
            this.Controls.Add(this.btn_updateSales);
            this.Controls.Add(this.btn_addSales);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chart1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.Label label_TotalAmount;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.ComboBox comboBook;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelFinalPayment;
        private System.Windows.Forms.Button btn_deleteSales;
        private System.Windows.Forms.Button btn_updateSales;
        private System.Windows.Forms.Button btn_addSales;
        private System.Windows.Forms.DataGridView dgv_sales;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox comboStaff;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Reports;
        private System.Windows.Forms.Button btn_Suppliers;
        private System.Windows.Forms.Button btn_Staffs;
        private System.Windows.Forms.Button btn_Books;
        private System.Windows.Forms.Button btn_SupplierOrders;
        private System.Windows.Forms.Button btn_CustomerOrders;
        private System.Windows.Forms.Button btn_Sales;
        private System.Windows.Forms.Button btn_Customers;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}