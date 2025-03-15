namespace Bookhaven
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbox_discount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_author_2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_author_1 = new System.Windows.Forms.ComboBox();
            this.cmb_genre = new System.Windows.Forms.ComboBox();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Isbn = new System.Windows.Forms.TextBox();
            this.txt_Bookname = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.btn_deleteBook = new System.Windows.Forms.Button();
            this.btn_updateBook = new System.Windows.Forms.Button();
            this.btn_addBook = new System.Windows.Forms.Button();
            this.btn_Genre = new System.Windows.Forms.Button();
            this.btn_ViewAuthors = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea10.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart1.Legends.Add(legend10);
            this.chart1.Location = new System.Drawing.Point(1692, 1243);
            this.chart1.Name = "chart1";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(2095, 733);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtbox_discount);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.cmb_author_2);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.cmb_author_1);
            this.panel2.Controls.Add(this.cmb_genre);
            this.panel2.Controls.Add(this.txt_Stock);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txt_Price);
            this.panel2.Controls.Add(this.txt_Isbn);
            this.panel2.Controls.Add(this.txt_Bookname);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(522, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 246);
            this.panel2.TabIndex = 48;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtbox_discount
            // 
            this.txtbox_discount.Location = new System.Drawing.Point(19, 199);
            this.txtbox_discount.Name = "txtbox_discount";
            this.txtbox_discount.Size = new System.Drawing.Size(190, 27);
            this.txtbox_discount.TabIndex = 43;
            this.txtbox_discount.TextChanged += new System.EventHandler(this.txtbox_discount_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 23);
            this.label16.TabIndex = 42;
            this.label16.Text = "Discount";
            // 
            // cmb_author_2
            // 
            this.cmb_author_2.FormattingEnabled = true;
            this.cmb_author_2.Location = new System.Drawing.Point(380, 130);
            this.cmb_author_2.Name = "cmb_author_2";
            this.cmb_author_2.Size = new System.Drawing.Size(121, 28);
            this.cmb_author_2.TabIndex = 41;
            this.cmb_author_2.SelectedIndexChanged += new System.EventHandler(this.cmb_author_2_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(376, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 23);
            this.label15.TabIndex = 40;
            this.label15.Text = "Author 2";
            // 
            // cmb_author_1
            // 
            this.cmb_author_1.FormattingEnabled = true;
            this.cmb_author_1.Location = new System.Drawing.Point(233, 130);
            this.cmb_author_1.Name = "cmb_author_1";
            this.cmb_author_1.Size = new System.Drawing.Size(121, 28);
            this.cmb_author_1.TabIndex = 39;
            this.cmb_author_1.SelectedIndexChanged += new System.EventHandler(this.cmb_author_SelectedIndexChanged);
            // 
            // cmb_genre
            // 
            this.cmb_genre.FormattingEnabled = true;
            this.cmb_genre.Location = new System.Drawing.Point(19, 130);
            this.cmb_genre.Name = "cmb_genre";
            this.cmb_genre.Size = new System.Drawing.Size(121, 28);
            this.cmb_genre.TabIndex = 38;
            this.cmb_genre.SelectedIndexChanged += new System.EventHandler(this.cmb_genre_SelectedIndexChanged);
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(551, 132);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(190, 27);
            this.txt_Stock.TabIndex = 37;
            this.txt_Stock.TextChanged += new System.EventHandler(this.txt_Stock_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 23);
            this.label14.TabIndex = 34;
            this.label14.Text = "Genre";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(277, 43);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(190, 27);
            this.txt_Price.TabIndex = 33;
            this.txt_Price.TextChanged += new System.EventHandler(this.txt_Price_TextChanged);
            // 
            // txt_Isbn
            // 
            this.txt_Isbn.Location = new System.Drawing.Point(554, 41);
            this.txt_Isbn.Name = "txt_Isbn";
            this.txt_Isbn.Size = new System.Drawing.Size(190, 27);
            this.txt_Isbn.TabIndex = 32;
            this.txt_Isbn.TextChanged += new System.EventHandler(this.txt_Isbn_TextChanged);
            // 
            // txt_Bookname
            // 
            this.txt_Bookname.Location = new System.Drawing.Point(19, 44);
            this.txt_Bookname.Name = "txt_Bookname";
            this.txt_Bookname.Size = new System.Drawing.Size(190, 27);
            this.txt_Bookname.TabIndex = 31;
            this.txt_Bookname.TextChanged += new System.EventHandler(this.txt_Bookname_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(229, 91);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(91, 23);
            this.label26.TabIndex = 28;
            this.label26.Text = "Author 1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(550, 91);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 23);
            this.label22.TabIndex = 14;
            this.label22.Text = "Stock";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(550, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 23);
            this.label19.TabIndex = 8;
            this.label19.Text = "ISBN";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(279, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 23);
            this.label18.TabIndex = 6;
            this.label18.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book Name";
            // 
            // dgv_books
            // 
            this.dgv_books.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Location = new System.Drawing.Point(522, 555);
            this.dgv_books.MultiSelect = false;
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.RowHeadersWidth = 51;
            this.dgv_books.RowTemplate.Height = 24;
            this.dgv_books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_books.Size = new System.Drawing.Size(1402, 275);
            this.dgv_books.TabIndex = 52;
            this.dgv_books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_book_CellContentClick);
            this.dgv_books.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_books_CellContentDoubleClick);
            this.dgv_books.SelectionChanged += new System.EventHandler(this.dgv_books_SelectionChanged);
            // 
            // btn_deleteBook
            // 
            this.btn_deleteBook.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_deleteBook.Location = new System.Drawing.Point(1073, 462);
            this.btn_deleteBook.Name = "btn_deleteBook";
            this.btn_deleteBook.Size = new System.Drawing.Size(247, 67);
            this.btn_deleteBook.TabIndex = 51;
            this.btn_deleteBook.Text = "Delete Book";
            this.btn_deleteBook.UseVisualStyleBackColor = true;
            this.btn_deleteBook.Click += new System.EventHandler(this.btn_deleteBook_Click);
            // 
            // btn_updateBook
            // 
            this.btn_updateBook.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_updateBook.Location = new System.Drawing.Point(799, 462);
            this.btn_updateBook.Name = "btn_updateBook";
            this.btn_updateBook.Size = new System.Drawing.Size(247, 67);
            this.btn_updateBook.TabIndex = 50;
            this.btn_updateBook.Text = "Update Book";
            this.btn_updateBook.UseVisualStyleBackColor = true;
            this.btn_updateBook.Click += new System.EventHandler(this.btn_updateBook_Click);
            // 
            // btn_addBook
            // 
            this.btn_addBook.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_addBook.Location = new System.Drawing.Point(522, 462);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(247, 67);
            this.btn_addBook.TabIndex = 49;
            this.btn_addBook.Text = "Add Book";
            this.btn_addBook.UseVisualStyleBackColor = true;
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // btn_Genre
            // 
            this.btn_Genre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Genre.Location = new System.Drawing.Point(731, 130);
            this.btn_Genre.Name = "btn_Genre";
            this.btn_Genre.Size = new System.Drawing.Size(190, 48);
            this.btn_Genre.TabIndex = 34;
            this.btn_Genre.Text = "View Genre";
            this.btn_Genre.UseVisualStyleBackColor = true;
            this.btn_Genre.Click += new System.EventHandler(this.btn_Genre_Click);
            // 
            // btn_ViewAuthors
            // 
            this.btn_ViewAuthors.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_ViewAuthors.Location = new System.Drawing.Point(946, 130);
            this.btn_ViewAuthors.Name = "btn_ViewAuthors";
            this.btn_ViewAuthors.Size = new System.Drawing.Size(190, 48);
            this.btn_ViewAuthors.TabIndex = 53;
            this.btn_ViewAuthors.Text = "View Authors";
            this.btn_ViewAuthors.UseVisualStyleBackColor = true;
            this.btn_ViewAuthors.Click += new System.EventHandler(this.btn_ViewAuthors_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_stock.Location = new System.Drawing.Point(522, 130);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(178, 48);
            this.btn_stock.TabIndex = 54;
            this.btn_stock.Text = "View Stocks";
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(458, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1466, 97);
            this.panel1.TabIndex = 63;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.panel3.Controls.Add(this.btn_Reports);
            this.panel3.Controls.Add(this.btn_Suppliers);
            this.panel3.Controls.Add(this.btn_Staffs);
            this.panel3.Controls.Add(this.btn_Books);
            this.panel3.Controls.Add(this.btn_SupplierOrders);
            this.panel3.Controls.Add(this.btn_CustomerOrders);
            this.panel3.Controls.Add(this.btn_Sales);
            this.panel3.Controls.Add(this.btn_Customers);
            this.panel3.Controls.Add(this.btn_Dashboard);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 1055);
            this.panel3.TabIndex = 62;
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
            this.btn_Books.BackColor = System.Drawing.Color.Silver;
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
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.btn_ViewAuthors);
            this.Controls.Add(this.btn_Genre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_books);
            this.Controls.Add(this.btn_deleteBook);
            this.Controls.Add(this.btn_updateBook);
            this.Controls.Add(this.btn_addBook);
            this.Controls.Add(this.chart1);
            this.Name = "Book";
            this.Text = "Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_books;
        private System.Windows.Forms.Button btn_deleteBook;
        private System.Windows.Forms.Button btn_updateBook;
        private System.Windows.Forms.Button btn_addBook;
        private System.Windows.Forms.Button btn_Genre;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Isbn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_ViewAuthors;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.ComboBox cmb_author_1;
        private System.Windows.Forms.ComboBox cmb_genre;
        private System.Windows.Forms.ComboBox cmb_author_2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtbox_discount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.TextBox txt_Bookname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
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