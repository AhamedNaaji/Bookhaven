namespace Bookhaven
{
    partial class SupplierOrder
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierOrder));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_expectedamount = new System.Windows.Forms.Label();
            this.nup_Quantity = new System.Windows.Forms.NumericUpDown();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.dtp_supplier = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.cmb_staff = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lbl_Finalamount = new System.Windows.Forms.Label();
            this.cmb_book_suporder = new System.Windows.Forms.ComboBox();
            this.cmb_Suporder = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_suporder = new System.Windows.Forms.DataGridView();
            this.btn_deleteOrder = new System.Windows.Forms.Button();
            this.btn_updateorder = new System.Windows.Forms.Button();
            this.btn_makeOrder = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.nup_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suporder)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea12.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chart1.Legends.Add(legend12);
            this.chart1.Location = new System.Drawing.Point(1707, 1264);
            this.chart1.Name = "chart1";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(2095, 733);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_expectedamount);
            this.panel2.Controls.Add(this.nup_Quantity);
            this.panel2.Controls.Add(this.cmb_Status);
            this.panel2.Controls.Add(this.dtp_supplier);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.cmb_staff);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.lbl_Finalamount);
            this.panel2.Controls.Add(this.cmb_book_suporder);
            this.panel2.Controls.Add(this.cmb_Suporder);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(583, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 282);
            this.panel2.TabIndex = 43;
            // 
            // lbl_expectedamount
            // 
            this.lbl_expectedamount.AutoSize = true;
            this.lbl_expectedamount.Location = new System.Drawing.Point(312, 132);
            this.lbl_expectedamount.Name = "lbl_expectedamount";
            this.lbl_expectedamount.Size = new System.Drawing.Size(67, 20);
            this.lbl_expectedamount.TabIndex = 54;
            this.lbl_expectedamount.Text = "1800.00";
            // 
            // nup_Quantity
            // 
            this.nup_Quantity.Location = new System.Drawing.Point(611, 45);
            this.nup_Quantity.Name = "nup_Quantity";
            this.nup_Quantity.Size = new System.Drawing.Size(84, 27);
            this.nup_Quantity.TabIndex = 53;
            this.nup_Quantity.ValueChanged += new System.EventHandler(this.nup_Quantity_ValueChanged);
            // 
            // cmb_Status
            // 
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Location = new System.Drawing.Point(19, 124);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(197, 28);
            this.cmb_Status.TabIndex = 51;
            // 
            // dtp_supplier
            // 
            this.dtp_supplier.Location = new System.Drawing.Point(306, 190);
            this.dtp_supplier.Name = "dtp_supplier";
            this.dtp_supplier.Size = new System.Drawing.Size(200, 27);
            this.dtp_supplier.TabIndex = 50;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(15, 169);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 23);
            this.label23.TabIndex = 49;
            this.label23.Text = "Staff";
            // 
            // cmb_staff
            // 
            this.cmb_staff.FormattingEnabled = true;
            this.cmb_staff.Location = new System.Drawing.Point(19, 198);
            this.cmb_staff.Name = "cmb_staff";
            this.cmb_staff.Size = new System.Drawing.Size(232, 28);
            this.cmb_staff.TabIndex = 48;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(302, 91);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(185, 23);
            this.label26.TabIndex = 28;
            this.label26.Text = "Expected Amount";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(15, 91);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(66, 23);
            this.label27.TabIndex = 23;
            this.label27.Text = "Status";
            // 
            // lbl_Finalamount
            // 
            this.lbl_Finalamount.AutoSize = true;
            this.lbl_Finalamount.Location = new System.Drawing.Point(608, 134);
            this.lbl_Finalamount.Name = "lbl_Finalamount";
            this.lbl_Finalamount.Size = new System.Drawing.Size(67, 20);
            this.lbl_Finalamount.TabIndex = 18;
            this.lbl_Finalamount.Text = "1800.00";
            // 
            // cmb_book_suporder
            // 
            this.cmb_book_suporder.FormattingEnabled = true;
            this.cmb_book_suporder.Location = new System.Drawing.Point(306, 43);
            this.cmb_book_suporder.Name = "cmb_book_suporder";
            this.cmb_book_suporder.Size = new System.Drawing.Size(232, 28);
            this.cmb_book_suporder.TabIndex = 16;
            this.cmb_book_suporder.SelectedIndexChanged += new System.EventHandler(this.cmb_book_suporder_SelectedIndexChanged);
            // 
            // cmb_Suporder
            // 
            this.cmb_Suporder.FormattingEnabled = true;
            this.cmb_Suporder.Location = new System.Drawing.Point(19, 43);
            this.cmb_Suporder.Name = "cmb_Suporder";
            this.cmb_Suporder.Size = new System.Drawing.Size(197, 28);
            this.cmb_Suporder.TabIndex = 15;
            this.cmb_Suporder.SelectedIndexChanged += new System.EventHandler(this.cmb_Suporder_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(607, 91);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(147, 23);
            this.label22.TabIndex = 14;
            this.label22.Text = "Final Payment";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(607, 11);
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
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Supplier";
            // 
            // dgv_suporder
            // 
            this.dgv_suporder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_suporder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_suporder.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_suporder.Location = new System.Drawing.Point(583, 555);
            this.dgv_suporder.Name = "dgv_suporder";
            this.dgv_suporder.RowHeadersWidth = 51;
            this.dgv_suporder.RowTemplate.Height = 24;
            this.dgv_suporder.Size = new System.Drawing.Size(1192, 428);
            this.dgv_suporder.TabIndex = 47;
            this.dgv_suporder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_suporder_CellContentClick);
            this.dgv_suporder.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_suporder_CellContentDoubleClick);
            // 
            // btn_deleteOrder
            // 
            this.btn_deleteOrder.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_deleteOrder.Location = new System.Drawing.Point(1137, 470);
            this.btn_deleteOrder.Name = "btn_deleteOrder";
            this.btn_deleteOrder.Size = new System.Drawing.Size(247, 67);
            this.btn_deleteOrder.TabIndex = 46;
            this.btn_deleteOrder.Text = "Delete Order";
            this.btn_deleteOrder.UseVisualStyleBackColor = true;
            this.btn_deleteOrder.Click += new System.EventHandler(this.btn_deleteOrder_Click);
            // 
            // btn_updateorder
            // 
            this.btn_updateorder.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_updateorder.Location = new System.Drawing.Point(863, 470);
            this.btn_updateorder.Name = "btn_updateorder";
            this.btn_updateorder.Size = new System.Drawing.Size(247, 67);
            this.btn_updateorder.TabIndex = 45;
            this.btn_updateorder.Text = "Update Order";
            this.btn_updateorder.UseVisualStyleBackColor = true;
            this.btn_updateorder.Click += new System.EventHandler(this.btn_updateorder_Click);
            // 
            // btn_makeOrder
            // 
            this.btn_makeOrder.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_makeOrder.Location = new System.Drawing.Point(583, 470);
            this.btn_makeOrder.Name = "btn_makeOrder";
            this.btn_makeOrder.Size = new System.Drawing.Size(247, 67);
            this.btn_makeOrder.TabIndex = 44;
            this.btn_makeOrder.Text = "Make Order";
            this.btn_makeOrder.UseVisualStyleBackColor = true;
            this.btn_makeOrder.Click += new System.EventHandler(this.btn_makeOrder_Click);
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
            this.panel3.Size = new System.Drawing.Size(1456, 97);
            this.panel3.TabIndex = 49;
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
            this.panel1.Size = new System.Drawing.Size(458, 1018);
            this.panel1.TabIndex = 48;
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
            this.btn_SupplierOrders.BackColor = System.Drawing.Color.Silver;
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
            this.btn_Sales.BackColor = System.Drawing.Color.White;
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
            // SupplierOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(1914, 1018);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_suporder);
            this.Controls.Add(this.btn_deleteOrder);
            this.Controls.Add(this.btn_updateorder);
            this.Controls.Add(this.btn_makeOrder);
            this.Controls.Add(this.chart1);
            this.Name = "SupplierOrder";
            this.Text = "SupplierOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suporder)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lbl_Finalamount;
        private System.Windows.Forms.ComboBox cmb_book_suporder;
        private System.Windows.Forms.ComboBox cmb_Suporder;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_suporder;
        private System.Windows.Forms.Button btn_deleteOrder;
        private System.Windows.Forms.Button btn_updateorder;
        private System.Windows.Forms.Button btn_makeOrder;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cmb_staff;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtp_supplier;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.NumericUpDown nup_Quantity;
        private System.Windows.Forms.Label lbl_expectedamount;
        private System.Windows.Forms.Label label22;
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