namespace Bookhaven
{
    partial class CustomerOrder
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrder));
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_cusOrder = new System.Windows.Forms.DataGridView();
            this.btn_deleteorder = new System.Windows.Forms.Button();
            this.btn_updateorder = new System.Windows.Forms.Button();
            this.btn_makeorder = new System.Windows.Forms.Button();
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cusOrder)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(547, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 272);
            this.panel2.TabIndex = 38;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(747, 11);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 23);
            this.label23.TabIndex = 48;
            this.label23.Text = "Staff";
            // 
            // cmb_staff
            // 
            this.cmb_staff.FormattingEnabled = true;
            this.cmb_staff.Location = new System.Drawing.Point(751, 41);
            this.cmb_staff.Name = "cmb_staff";
            this.cmb_staff.Size = new System.Drawing.Size(232, 28);
            this.cmb_staff.TabIndex = 47;
            // 
            // cmb_Status
            // 
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Location = new System.Drawing.Point(306, 124);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(197, 28);
            this.cmb_Status.TabIndex = 46;
            // 
            // nup_Quantity
            // 
            this.nup_Quantity.Location = new System.Drawing.Point(611, 43);
            this.nup_Quantity.Name = "nup_Quantity";
            this.nup_Quantity.Size = new System.Drawing.Size(84, 27);
            this.nup_Quantity.TabIndex = 45;
            this.nup_Quantity.ValueChanged += new System.EventHandler(this.nup_Quantity_ValueChanged);
            // 
            // cmb_Deliverymethod
            // 
            this.cmb_Deliverymethod.FormattingEnabled = true;
            this.cmb_Deliverymethod.Location = new System.Drawing.Point(19, 215);
            this.cmb_Deliverymethod.Name = "cmb_Deliverymethod";
            this.cmb_Deliverymethod.Size = new System.Drawing.Size(197, 28);
            this.cmb_Deliverymethod.TabIndex = 29;
            // 
            // cmb_Suporder
            // 
            this.cmb_Suporder.FormattingEnabled = true;
            this.cmb_Suporder.Location = new System.Drawing.Point(17, 124);
            this.cmb_Suporder.Name = "cmb_Suporder";
            this.cmb_Suporder.Size = new System.Drawing.Size(197, 28);
            this.cmb_Suporder.TabIndex = 28;
            this.cmb_Suporder.SelectedIndexChanged += new System.EventHandler(this.cmb_Suporder_SelectedIndexChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(15, 181);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(170, 23);
            this.label28.TabIndex = 24;
            this.label28.Text = "Delivery Method";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(306, 91);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(66, 23);
            this.label27.TabIndex = 23;
            this.label27.Text = "Status";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(15, 91);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 23);
            this.label26.TabIndex = 22;
            this.label26.Text = "Supplier";
            // 
            // lbl_Discount_Cusorder
            // 
            this.lbl_Discount_Cusorder.AutoSize = true;
            this.lbl_Discount_Cusorder.Location = new System.Drawing.Point(326, 215);
            this.lbl_Discount_Cusorder.Name = "lbl_Discount_Cusorder";
            this.lbl_Discount_Cusorder.Size = new System.Drawing.Size(42, 20);
            this.lbl_Discount_Cusorder.TabIndex = 20;
            this.lbl_Discount_Cusorder.Text = "10%";
            // 
            // lbl_Finalpayment_Cusorder
            // 
            this.lbl_Finalpayment_Cusorder.AutoSize = true;
            this.lbl_Finalpayment_Cusorder.Location = new System.Drawing.Point(614, 209);
            this.lbl_Finalpayment_Cusorder.Name = "lbl_Finalpayment_Cusorder";
            this.lbl_Finalpayment_Cusorder.Size = new System.Drawing.Size(58, 20);
            this.lbl_Finalpayment_Cusorder.TabIndex = 19;
            this.lbl_Finalpayment_Cusorder.Text = "950.00";
            this.lbl_Finalpayment_Cusorder.Click += new System.EventHandler(this.label23_Click);
            // 
            // lbl_Totalamount
            // 
            this.lbl_Totalamount.AutoSize = true;
            this.lbl_Totalamount.Location = new System.Drawing.Point(608, 134);
            this.lbl_Totalamount.Name = "lbl_Totalamount";
            this.lbl_Totalamount.Size = new System.Drawing.Size(67, 20);
            this.lbl_Totalamount.TabIndex = 18;
            this.lbl_Totalamount.Text = "1000.00";
            // 
            // cmb_Book
            // 
            this.cmb_Book.FormattingEnabled = true;
            this.cmb_Book.Location = new System.Drawing.Point(306, 43);
            this.cmb_Book.Name = "cmb_Book";
            this.cmb_Book.Size = new System.Drawing.Size(232, 28);
            this.cmb_Book.TabIndex = 16;
            this.cmb_Book.SelectedIndexChanged += new System.EventHandler(this.cmb_Book_SelectedIndexChanged);
            // 
            // cmb_customer
            // 
            this.cmb_customer.FormattingEnabled = true;
            this.cmb_customer.Location = new System.Drawing.Point(19, 43);
            this.cmb_customer.Name = "cmb_customer";
            this.cmb_customer.Size = new System.Drawing.Size(197, 28);
            this.cmb_customer.TabIndex = 15;
            this.cmb_customer.SelectedIndexChanged += new System.EventHandler(this.cmb_customer_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(613, 172);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(147, 23);
            this.label22.TabIndex = 14;
            this.label22.Text = "Final Payment";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(302, 181);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 23);
            this.label21.TabIndex = 12;
            this.label21.Text = "Discount";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(607, 91);
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
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer";
            // 
            // chart1
            // 
            chartArea10.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart1.Legends.Add(legend10);
            this.chart1.Location = new System.Drawing.Point(1612, 1249);
            this.chart1.Name = "chart1";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(2095, 733);
            this.chart1.TabIndex = 37;
            this.chart1.Text = "chart1";
            // 
            // dgv_cusOrder
            // 
            this.dgv_cusOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_cusOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cusOrder.Location = new System.Drawing.Point(547, 518);
            this.dgv_cusOrder.Name = "dgv_cusOrder";
            this.dgv_cusOrder.RowHeadersWidth = 51;
            this.dgv_cusOrder.RowTemplate.Height = 24;
            this.dgv_cusOrder.Size = new System.Drawing.Size(1317, 428);
            this.dgv_cusOrder.TabIndex = 42;
            this.dgv_cusOrder.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cusOrder_CellContentDoubleClick);
            // 
            // btn_deleteorder
            // 
            this.btn_deleteorder.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_deleteorder.Location = new System.Drawing.Point(1158, 426);
            this.btn_deleteorder.Name = "btn_deleteorder";
            this.btn_deleteorder.Size = new System.Drawing.Size(247, 67);
            this.btn_deleteorder.TabIndex = 41;
            this.btn_deleteorder.Text = "Delete Order";
            this.btn_deleteorder.UseVisualStyleBackColor = true;
            this.btn_deleteorder.Click += new System.EventHandler(this.btn_deleteorder_Click);
            // 
            // btn_updateorder
            // 
            this.btn_updateorder.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_updateorder.Location = new System.Drawing.Point(853, 426);
            this.btn_updateorder.Name = "btn_updateorder";
            this.btn_updateorder.Size = new System.Drawing.Size(247, 67);
            this.btn_updateorder.TabIndex = 40;
            this.btn_updateorder.Text = "Update Order";
            this.btn_updateorder.UseVisualStyleBackColor = true;
            this.btn_updateorder.Click += new System.EventHandler(this.btn_updateorder_Click);
            // 
            // btn_makeorder
            // 
            this.btn_makeorder.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_makeorder.Location = new System.Drawing.Point(547, 426);
            this.btn_makeorder.Name = "btn_makeorder";
            this.btn_makeorder.Size = new System.Drawing.Size(247, 67);
            this.btn_makeorder.TabIndex = 39;
            this.btn_makeorder.Text = "Make Order";
            this.btn_makeorder.UseVisualStyleBackColor = true;
            this.btn_makeorder.Click += new System.EventHandler(this.btn_makeorder_Click);
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
            this.panel3.Size = new System.Drawing.Size(1449, 97);
            this.panel3.TabIndex = 44;
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
            this.panel1.Size = new System.Drawing.Size(458, 996);
            this.panel1.TabIndex = 43;
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
            this.btn_CustomerOrders.BackColor = System.Drawing.Color.Silver;
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
            // CustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1907, 996);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgv_cusOrder);
            this.Controls.Add(this.btn_deleteorder);
            this.Controls.Add(this.btn_updateorder);
            this.Controls.Add(this.btn_makeorder);
            this.Name = "CustomerOrder";
            this.Text = "CustomerOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cusOrder)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dgv_cusOrder;
        private System.Windows.Forms.Button btn_deleteorder;
        private System.Windows.Forms.Button btn_updateorder;
        private System.Windows.Forms.Button btn_makeorder;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cmb_Suporder;
        private System.Windows.Forms.ComboBox cmb_Deliverymethod;
        private System.Windows.Forms.NumericUpDown nup_Quantity;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmb_staff;
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