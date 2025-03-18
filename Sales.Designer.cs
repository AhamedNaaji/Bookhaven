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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.comboStaff = new System.Windows.Forms.ComboBox();
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
            this.dgv_addtocart = new System.Windows.Forms.DataGridView();
            this.btn_addbook = new System.Windows.Forms.Button();
            this.btn_removebook = new System.Windows.Forms.Button();
            this.btn_saveSale = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.cusorderRecieve_panel.SuspendLayout();
            this.outofstock_panel.SuspendLayout();
            this.Totalcustomer_panel.SuspendLayout();
            this.Totalsales_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addtocart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1595, 1244);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(2095, 733);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.comboStaff);
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
            this.panel2.Location = new System.Drawing.Point(723, 451);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 309);
            this.panel2.TabIndex = 30;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(581, 12);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 23);
            this.label24.TabIndex = 24;
            this.label24.Text = "Staff";
            // 
            // comboStaff
            // 
            this.comboStaff.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.comboStaff.FormattingEnabled = true;
            this.comboStaff.Location = new System.Drawing.Point(585, 43);
            this.comboStaff.Name = "comboStaff";
            this.comboStaff.Size = new System.Drawing.Size(200, 28);
            this.comboStaff.TabIndex = 23;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.labelDiscount.Location = new System.Drawing.Point(127, 223);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(48, 20);
            this.labelDiscount.TabIndex = 20;
            this.labelDiscount.Text = "10%";
            // 
            // labelFinalPayment
            // 
            this.labelFinalPayment.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.labelFinalPayment.Location = new System.Drawing.Point(490, 220);
            this.labelFinalPayment.Name = "labelFinalPayment";
            this.labelFinalPayment.Size = new System.Drawing.Size(194, 20);
            this.labelFinalPayment.TabIndex = 19;
            // 
            // label_TotalAmount
            // 
            this.label_TotalAmount.Location = new System.Drawing.Point(491, 129);
            this.label_TotalAmount.Name = "label_TotalAmount";
            this.label_TotalAmount.Size = new System.Drawing.Size(218, 23);
            this.label_TotalAmount.TabIndex = 18;
            // 
            // numericQuantity
            // 
            this.numericQuantity.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.numericQuantity.Location = new System.Drawing.Point(128, 130);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(51, 27);
            this.numericQuantity.TabIndex = 17;
            this.numericQuantity.ValueChanged += new System.EventHandler(this.numericQuantity_ValueChanged_1);
            // 
            // comboBook
            // 
            this.comboBook.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.comboBook.FormattingEnabled = true;
            this.comboBook.Location = new System.Drawing.Point(306, 43);
            this.comboBook.Name = "comboBook";
            this.comboBook.Size = new System.Drawing.Size(232, 28);
            this.comboBook.TabIndex = 16;
            this.comboBook.SelectedIndexChanged += new System.EventHandler(this.comboBook_SelectedIndexChanged_1);
            // 
            // comboCustomer
            // 
            this.comboCustomer.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
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
            this.label18.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(312, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 24);
            this.label18.TabIndex = 6;
            this.label18.Text = "Book";
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
            // btn_deleteSales
            // 
            this.btn_deleteSales.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_deleteSales.Location = new System.Drawing.Point(1305, 782);
            this.btn_deleteSales.Name = "btn_deleteSales";
            this.btn_deleteSales.Size = new System.Drawing.Size(247, 67);
            this.btn_deleteSales.TabIndex = 33;
            this.btn_deleteSales.Text = "Delete Sales";
            this.btn_deleteSales.UseVisualStyleBackColor = true;
            this.btn_deleteSales.Click += new System.EventHandler(this.btn_deleteSales_Click);
            // 
            // btn_updateSales
            // 
            this.btn_updateSales.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_updateSales.Location = new System.Drawing.Point(1014, 782);
            this.btn_updateSales.Name = "btn_updateSales";
            this.btn_updateSales.Size = new System.Drawing.Size(247, 67);
            this.btn_updateSales.TabIndex = 32;
            this.btn_updateSales.Text = "Update Sales";
            this.btn_updateSales.UseVisualStyleBackColor = true;
            this.btn_updateSales.Click += new System.EventHandler(this.btn_updateSales_Click);
            // 
            // btn_addSales
            // 
            this.btn_addSales.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_addSales.Location = new System.Drawing.Point(723, 782);
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
            this.dgv_sales.Location = new System.Drawing.Point(41, 136);
            this.dgv_sales.Name = "dgv_sales";
            this.dgv_sales.RowHeadersWidth = 51;
            this.dgv_sales.RowTemplate.Height = 24;
            this.dgv_sales.Size = new System.Drawing.Size(1511, 309);
            this.dgv_sales.TabIndex = 34;
            this.dgv_sales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sales_CellContentClick);
            this.dgv_sales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sales_CellDoubleClick);
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
            this.panel1.Location = new System.Drawing.Point(1558, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 891);
            this.panel1.TabIndex = 35;
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
            this.btn_Sales.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Sales.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Sales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sales.Location = new System.Drawing.Point(32, 310);
            this.btn_Sales.Name = "btn_Sales";
            this.btn_Sales.Size = new System.Drawing.Size(219, 55);
            this.btn_Sales.TabIndex = 2;
            this.btn_Sales.Text = "Sales";
            this.btn_Sales.UseVisualStyleBackColor = false;
            this.btn_Sales.Click += new System.EventHandler(this.btn_Sales_Click);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1558, 130);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // cusorderRecieve_panel
            // 
            this.cusorderRecieve_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(131)))), ((int)(((byte)(146)))));
            this.cusorderRecieve_panel.Controls.Add(this.label16);
            this.cusorderRecieve_panel.Controls.Add(this.label17);
            this.cusorderRecieve_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cusorderRecieve_panel.Location = new System.Drawing.Point(1167, 0);
            this.cusorderRecieve_panel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.cusorderRecieve_panel.Name = "cusorderRecieve_panel";
            this.cusorderRecieve_panel.Size = new System.Drawing.Size(391, 120);
            this.cusorderRecieve_panel.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(52, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 23);
            this.label16.TabIndex = 1;
            this.label16.Text = "2500";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(52, 22);
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
            this.outofstock_panel.Location = new System.Drawing.Point(777, 0);
            this.outofstock_panel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.outofstock_panel.Name = "outofstock_panel";
            this.outofstock_panel.Size = new System.Drawing.Size(380, 120);
            this.outofstock_panel.TabIndex = 2;
            // 
            // lbl_Outofstock
            // 
            this.lbl_Outofstock.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Outofstock.Location = new System.Drawing.Point(57, 57);
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
            this.label13.Location = new System.Drawing.Point(15, 22);
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
            this.Totalcustomer_panel.Location = new System.Drawing.Point(389, 0);
            this.Totalcustomer_panel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.Totalcustomer_panel.Name = "Totalcustomer_panel";
            this.Totalcustomer_panel.Size = new System.Drawing.Size(378, 120);
            this.Totalcustomer_panel.TabIndex = 1;
            // 
            // lbl_TotalCustomer
            // 
            this.lbl_TotalCustomer.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_TotalCustomer.Location = new System.Drawing.Point(60, 57);
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
            this.label9.Location = new System.Drawing.Point(23, 22);
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
            this.Totalsales_panel.Size = new System.Drawing.Size(379, 120);
            this.Totalsales_panel.TabIndex = 0;
            // 
            // lbl_Totalsales
            // 
            this.lbl_Totalsales.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Totalsales.Location = new System.Drawing.Point(61, 57);
            this.lbl_Totalsales.Name = "lbl_Totalsales";
            this.lbl_Totalsales.Size = new System.Drawing.Size(71, 23);
            this.lbl_Totalsales.TabIndex = 1;
            this.lbl_Totalsales.Text = "50000";
            this.lbl_Totalsales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(61, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Sales";
            // 
            // dgv_addtocart
            // 
            this.dgv_addtocart.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_addtocart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_addtocart.Location = new System.Drawing.Point(12, 463);
            this.dgv_addtocart.Name = "dgv_addtocart";
            this.dgv_addtocart.RowHeadersWidth = 51;
            this.dgv_addtocart.RowTemplate.Height = 24;
            this.dgv_addtocart.Size = new System.Drawing.Size(693, 215);
            this.dgv_addtocart.TabIndex = 37;
            // 
            // btn_addbook
            // 
            this.btn_addbook.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_addbook.Location = new System.Drawing.Point(12, 689);
            this.btn_addbook.Name = "btn_addbook";
            this.btn_addbook.Size = new System.Drawing.Size(221, 67);
            this.btn_addbook.TabIndex = 38;
            this.btn_addbook.Text = "Add Book";
            this.btn_addbook.UseVisualStyleBackColor = true;
            this.btn_addbook.Click += new System.EventHandler(this.btn_addbook_Click);
            // 
            // btn_removebook
            // 
            this.btn_removebook.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_removebook.Location = new System.Drawing.Point(541, 689);
            this.btn_removebook.Name = "btn_removebook";
            this.btn_removebook.Size = new System.Drawing.Size(164, 67);
            this.btn_removebook.TabIndex = 39;
            this.btn_removebook.Text = "Remove Book";
            this.btn_removebook.UseVisualStyleBackColor = true;
            this.btn_removebook.Click += new System.EventHandler(this.btn_removebook_Click);
            // 
            // btn_saveSale
            // 
            this.btn_saveSale.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.btn_saveSale.Location = new System.Drawing.Point(282, 689);
            this.btn_saveSale.Name = "btn_saveSale";
            this.btn_saveSale.Size = new System.Drawing.Size(220, 67);
            this.btn_saveSale.TabIndex = 40;
            this.btn_saveSale.Text = "Save Book";
            this.btn_saveSale.UseVisualStyleBackColor = true;
            this.btn_saveSale.Click += new System.EventHandler(this.btn_saveSale_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.BackColor = System.Drawing.Color.White;
            this.btn_Report.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Report.Location = new System.Drawing.Point(32, 792);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(219, 56);
            this.btn_Report.TabIndex = 41;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = false;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1843, 891);
            this.Controls.Add(this.btn_saveSale);
            this.Controls.Add(this.btn_removebook);
            this.Controls.Add(this.btn_addbook);
            this.Controls.Add(this.dgv_addtocart);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_sales);
            this.Controls.Add(this.btn_deleteSales);
            this.Controls.Add(this.btn_updateSales);
            this.Controls.Add(this.btn_addSales);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chart1);
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.cusorderRecieve_panel.ResumeLayout(false);
            this.outofstock_panel.ResumeLayout(false);
            this.outofstock_panel.PerformLayout();
            this.Totalcustomer_panel.ResumeLayout(false);
            this.Totalcustomer_panel.PerformLayout();
            this.Totalsales_panel.ResumeLayout(false);
            this.Totalsales_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addtocart)).EndInit();
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
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox comboStaff;
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
        private System.Windows.Forms.DataGridView dgv_addtocart;
        private System.Windows.Forms.Button btn_addbook;
        private System.Windows.Forms.Button btn_removebook;
        private System.Windows.Forms.Button btn_saveSale;
        private System.Windows.Forms.Button btn_Report;
    }
}