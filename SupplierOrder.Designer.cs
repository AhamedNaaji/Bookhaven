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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suporder)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(1707, 1264);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart1.Series.Add(series9);
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
            this.panel2.Location = new System.Drawing.Point(472, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 320);
            this.panel2.TabIndex = 43;
            // 
            // lbl_expectedamount
            // 
            this.lbl_expectedamount.AutoSize = true;
            this.lbl_expectedamount.Location = new System.Drawing.Point(312, 132);
            this.lbl_expectedamount.Name = "lbl_expectedamount";
            this.lbl_expectedamount.Size = new System.Drawing.Size(52, 16);
            this.lbl_expectedamount.TabIndex = 54;
            this.lbl_expectedamount.Text = "1800.00";
            // 
            // nup_Quantity
            // 
            this.nup_Quantity.Location = new System.Drawing.Point(611, 45);
            this.nup_Quantity.Name = "nup_Quantity";
            this.nup_Quantity.Size = new System.Drawing.Size(84, 22);
            this.nup_Quantity.TabIndex = 53;
            this.nup_Quantity.ValueChanged += new System.EventHandler(this.nup_Quantity_ValueChanged);
            // 
            // cmb_Status
            // 
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Location = new System.Drawing.Point(19, 124);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(197, 24);
            this.cmb_Status.TabIndex = 51;
            // 
            // dtp_supplier
            // 
            this.dtp_supplier.Location = new System.Drawing.Point(306, 190);
            this.dtp_supplier.Name = "dtp_supplier";
            this.dtp_supplier.Size = new System.Drawing.Size(200, 22);
            this.dtp_supplier.TabIndex = 50;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(15, 169);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 36);
            this.label23.TabIndex = 49;
            this.label23.Text = "Staff";
            // 
            // cmb_staff
            // 
            this.cmb_staff.FormattingEnabled = true;
            this.cmb_staff.Location = new System.Drawing.Point(19, 198);
            this.cmb_staff.Name = "cmb_staff";
            this.cmb_staff.Size = new System.Drawing.Size(232, 24);
            this.cmb_staff.TabIndex = 48;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(302, 91);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(207, 36);
            this.label26.TabIndex = 28;
            this.label26.Text = "Expected Amount";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(15, 91);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(85, 36);
            this.label27.TabIndex = 23;
            this.label27.Text = "Status";
            // 
            // lbl_Finalamount
            // 
            this.lbl_Finalamount.AutoSize = true;
            this.lbl_Finalamount.Location = new System.Drawing.Point(608, 134);
            this.lbl_Finalamount.Name = "lbl_Finalamount";
            this.lbl_Finalamount.Size = new System.Drawing.Size(52, 16);
            this.lbl_Finalamount.TabIndex = 18;
            this.lbl_Finalamount.Text = "1800.00";
            // 
            // cmb_book_suporder
            // 
            this.cmb_book_suporder.FormattingEnabled = true;
            this.cmb_book_suporder.Location = new System.Drawing.Point(306, 43);
            this.cmb_book_suporder.Name = "cmb_book_suporder";
            this.cmb_book_suporder.Size = new System.Drawing.Size(232, 24);
            this.cmb_book_suporder.TabIndex = 16;
            this.cmb_book_suporder.SelectedIndexChanged += new System.EventHandler(this.cmb_book_suporder_SelectedIndexChanged);
            // 
            // cmb_Suporder
            // 
            this.cmb_Suporder.FormattingEnabled = true;
            this.cmb_Suporder.Location = new System.Drawing.Point(19, 43);
            this.cmb_Suporder.Name = "cmb_Suporder";
            this.cmb_Suporder.Size = new System.Drawing.Size(197, 24);
            this.cmb_Suporder.TabIndex = 15;
            this.cmb_Suporder.SelectedIndexChanged += new System.EventHandler(this.cmb_Suporder_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(607, 91);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(171, 36);
            this.label22.TabIndex = 14;
            this.label22.Text = "Final Payment";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(607, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 36);
            this.label19.TabIndex = 8;
            this.label19.Text = "Quantity";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(312, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 36);
            this.label18.TabIndex = 6;
            this.label18.Text = "Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Supplier";
            // 
            // dgv_suporder
            // 
            this.dgv_suporder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_suporder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_suporder.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_suporder.Location = new System.Drawing.Point(472, 525);
            this.dgv_suporder.Name = "dgv_suporder";
            this.dgv_suporder.RowHeadersWidth = 51;
            this.dgv_suporder.RowTemplate.Height = 24;
            this.dgv_suporder.Size = new System.Drawing.Size(1120, 319);
            this.dgv_suporder.TabIndex = 47;
            this.dgv_suporder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_suporder_CellContentClick);
            this.dgv_suporder.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_suporder_CellContentDoubleClick);
            // 
            // btn_deleteOrder
            // 
            this.btn_deleteOrder.BackColor = System.Drawing.Color.Red;
            this.btn_deleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteOrder.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_deleteOrder.Location = new System.Drawing.Point(21, 232);
            this.btn_deleteOrder.Name = "btn_deleteOrder";
            this.btn_deleteOrder.Size = new System.Drawing.Size(247, 67);
            this.btn_deleteOrder.TabIndex = 46;
            this.btn_deleteOrder.Text = "Delete Order";
            this.btn_deleteOrder.UseVisualStyleBackColor = false;
            this.btn_deleteOrder.Click += new System.EventHandler(this.btn_deleteOrder_Click);
            // 
            // btn_updateorder
            // 
            this.btn_updateorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_updateorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateorder.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_updateorder.Location = new System.Drawing.Point(21, 126);
            this.btn_updateorder.Name = "btn_updateorder";
            this.btn_updateorder.Size = new System.Drawing.Size(247, 67);
            this.btn_updateorder.TabIndex = 45;
            this.btn_updateorder.Text = "Update Order";
            this.btn_updateorder.UseVisualStyleBackColor = false;
            this.btn_updateorder.Click += new System.EventHandler(this.btn_updateorder_Click);
            // 
            // btn_makeOrder
            // 
            this.btn_makeOrder.BackColor = System.Drawing.Color.Lime;
            this.btn_makeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_makeOrder.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_makeOrder.Location = new System.Drawing.Point(21, 17);
            this.btn_makeOrder.Name = "btn_makeOrder";
            this.btn_makeOrder.Size = new System.Drawing.Size(247, 67);
            this.btn_makeOrder.TabIndex = 44;
            this.btn_makeOrder.Text = "Make Order";
            this.btn_makeOrder.UseVisualStyleBackColor = false;
            this.btn_makeOrder.Click += new System.EventHandler(this.btn_makeOrder_Click);
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
            this.panel3.Location = new System.Drawing.Point(356, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1282, 143);
            this.panel3.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(961, 37);
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
            this.panel1.Size = new System.Drawing.Size(356, 884);
            this.panel1.TabIndex = 48;
            // 
            // btn_Suppliers
            // 
            this.btn_Suppliers.BackColor = System.Drawing.Color.White;
            this.btn_Suppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suppliers.ForeColor = System.Drawing.Color.Black;
            this.btn_Suppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Suppliers.Location = new System.Drawing.Point(50, 583);
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
            this.btn_Staff.Location = new System.Drawing.Point(50, 682);
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
            this.btn_Book.Location = new System.Drawing.Point(50, 475);
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
            this.btn_Supporder.Location = new System.Drawing.Point(50, 369);
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
            this.btn_Cusorder.Location = new System.Drawing.Point(50, 260);
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
            this.btn_Sales.Location = new System.Drawing.Point(50, 152);
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
            this.btn_Customer.Location = new System.Drawing.Point(50, 45);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(243, 63);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "Customer Details";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_deleteOrder);
            this.panel4.Controls.Add(this.btn_updateorder);
            this.panel4.Controls.Add(this.btn_makeOrder);
            this.panel4.Location = new System.Drawing.Point(1302, 184);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 320);
            this.panel4.TabIndex = 50;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(50, 781);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(243, 63);
            this.button4.TabIndex = 8;
            this.button4.Text = "Report";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SupplierOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 884);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_suporder);
            this.Controls.Add(this.chart1);
            this.Name = "SupplierOrder";
            this.Text = "SupplierOrder";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suporder)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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