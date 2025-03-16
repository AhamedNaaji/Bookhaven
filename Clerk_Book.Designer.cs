namespace Bookhaven
{
    partial class Clerk_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clerk_Book));
            this.btn_ViewAuthors = new System.Windows.Forms.Button();
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
            this.btn_Genre = new System.Windows.Forms.Button();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.btn_deleteBook = new System.Windows.Forms.Button();
            this.btn_updateBook = new System.Windows.Forms.Button();
            this.btn_addBook = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtbox_search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Book = new System.Windows.Forms.Button();
            this.btn_Cusorder = new System.Windows.Forms.Button();
            this.btn_Sales = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ViewAuthors
            // 
            this.btn_ViewAuthors.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_ViewAuthors.Location = new System.Drawing.Point(919, 137);
            this.btn_ViewAuthors.Name = "btn_ViewAuthors";
            this.btn_ViewAuthors.Size = new System.Drawing.Size(190, 48);
            this.btn_ViewAuthors.TabIndex = 64;
            this.btn_ViewAuthors.Text = "View Authors";
            this.btn_ViewAuthors.UseVisualStyleBackColor = true;
            this.btn_ViewAuthors.Click += new System.EventHandler(this.btn_ViewAuthors_Click);
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
            this.panel2.Location = new System.Drawing.Point(530, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 257);
            this.panel2.TabIndex = 59;
            // 
            // txtbox_discount
            // 
            this.txtbox_discount.Location = new System.Drawing.Point(29, 201);
            this.txtbox_discount.Name = "txtbox_discount";
            this.txtbox_discount.Size = new System.Drawing.Size(190, 27);
            this.txtbox_discount.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 167);
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
            this.cmb_author_1.SelectedIndexChanged += new System.EventHandler(this.cmb_author_1_SelectedIndexChanged);
            // 
            // cmb_genre
            // 
            this.cmb_genre.FormattingEnabled = true;
            this.cmb_genre.Location = new System.Drawing.Point(29, 128);
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
            this.label14.Location = new System.Drawing.Point(25, 91);
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
            // 
            // txt_Isbn
            // 
            this.txt_Isbn.Location = new System.Drawing.Point(554, 41);
            this.txt_Isbn.Name = "txt_Isbn";
            this.txt_Isbn.Size = new System.Drawing.Size(190, 27);
            this.txt_Isbn.TabIndex = 32;
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
            // btn_Genre
            // 
            this.btn_Genre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Genre.Location = new System.Drawing.Point(706, 137);
            this.btn_Genre.Name = "btn_Genre";
            this.btn_Genre.Size = new System.Drawing.Size(190, 48);
            this.btn_Genre.TabIndex = 58;
            this.btn_Genre.Text = "View Genre";
            this.btn_Genre.UseVisualStyleBackColor = true;
            this.btn_Genre.Click += new System.EventHandler(this.btn_Genre_Click);
            // 
            // dgv_books
            // 
            this.dgv_books.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Location = new System.Drawing.Point(530, 661);
            this.dgv_books.MultiSelect = false;
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.RowHeadersWidth = 51;
            this.dgv_books.RowTemplate.Height = 24;
            this.dgv_books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_books.Size = new System.Drawing.Size(801, 275);
            this.dgv_books.TabIndex = 63;
            this.dgv_books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_books_CellContentClick);
            this.dgv_books.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_books_CellContentDoubleClick);
            // 
            // btn_deleteBook
            // 
            this.btn_deleteBook.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_deleteBook.Location = new System.Drawing.Point(1081, 548);
            this.btn_deleteBook.Name = "btn_deleteBook";
            this.btn_deleteBook.Size = new System.Drawing.Size(247, 67);
            this.btn_deleteBook.TabIndex = 62;
            this.btn_deleteBook.Text = "Delete Book";
            this.btn_deleteBook.UseVisualStyleBackColor = true;
            this.btn_deleteBook.Click += new System.EventHandler(this.btn_deleteBook_Click);
            // 
            // btn_updateBook
            // 
            this.btn_updateBook.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_updateBook.Location = new System.Drawing.Point(807, 548);
            this.btn_updateBook.Name = "btn_updateBook";
            this.btn_updateBook.Size = new System.Drawing.Size(247, 67);
            this.btn_updateBook.TabIndex = 61;
            this.btn_updateBook.Text = "Update Book";
            this.btn_updateBook.UseVisualStyleBackColor = true;
            this.btn_updateBook.Click += new System.EventHandler(this.btn_updateBook_Click);
            // 
            // btn_addBook
            // 
            this.btn_addBook.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_addBook.Location = new System.Drawing.Point(530, 548);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(247, 67);
            this.btn_addBook.TabIndex = 60;
            this.btn_addBook.Text = "Add Book";
            this.btn_addBook.UseVisualStyleBackColor = true;
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_stock.Location = new System.Drawing.Point(527, 137);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(161, 48);
            this.btn_stock.TabIndex = 65;
            this.btn_stock.Text = "View Stocks";
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1711, 1344);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(2095, 733);
            this.chart1.TabIndex = 57;
            this.chart1.Text = "chart1";
            // 
            // txtbox_search
            // 
            this.txtbox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_search.Location = new System.Drawing.Point(530, 230);
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(190, 27);
            this.txtbox_search.TabIndex = 44;
            this.txtbox_search.TextChanged += new System.EventHandler(this.txtbox_search_TextChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Location = new System.Drawing.Point(737, 221);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(190, 40);
            this.btn_Search.TabIndex = 66;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Reset.Location = new System.Drawing.Point(943, 221);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(190, 40);
            this.btn_Reset.TabIndex = 67;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.panel3.Controls.Add(this.btn_Logout);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(458, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1466, 97);
            this.panel3.TabIndex = 74;
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
            this.label8.Size = new System.Drawing.Size(374, 56);
            this.label8.TabIndex = 23;
            this.label8.Text = "Welcome Clerk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.panel4.Controls.Add(this.btn_Book);
            this.panel4.Controls.Add(this.btn_Cusorder);
            this.panel4.Controls.Add(this.btn_Sales);
            this.panel4.Controls.Add(this.btn_dashboard);
            this.panel4.Controls.Add(this.btn_Customer);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 1025);
            this.panel4.TabIndex = 73;
            // 
            // btn_Book
            // 
            this.btn_Book.BackColor = System.Drawing.Color.Silver;
            this.btn_Book.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Book.Location = new System.Drawing.Point(74, 321);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(259, 63);
            this.btn_Book.TabIndex = 5;
            this.btn_Book.Text = "Books";
            this.btn_Book.UseVisualStyleBackColor = false;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // btn_Cusorder
            // 
            this.btn_Cusorder.BackColor = System.Drawing.Color.White;
            this.btn_Cusorder.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Cusorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Cusorder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cusorder.Location = new System.Drawing.Point(74, 582);
            this.btn_Cusorder.Name = "btn_Cusorder";
            this.btn_Cusorder.Size = new System.Drawing.Size(259, 63);
            this.btn_Cusorder.TabIndex = 3;
            this.btn_Cusorder.Text = "Customer Orders";
            this.btn_Cusorder.UseVisualStyleBackColor = false;
            this.btn_Cusorder.Click += new System.EventHandler(this.btn_Cusorder_Click);
            // 
            // btn_Sales
            // 
            this.btn_Sales.BackColor = System.Drawing.Color.White;
            this.btn_Sales.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Sales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Sales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sales.Location = new System.Drawing.Point(71, 496);
            this.btn_Sales.Name = "btn_Sales";
            this.btn_Sales.Size = new System.Drawing.Size(259, 63);
            this.btn_Sales.TabIndex = 2;
            this.btn_Sales.Text = "Sales";
            this.btn_Sales.UseVisualStyleBackColor = false;
            this.btn_Sales.Click += new System.EventHandler(this.btn_Sales_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.White;
            this.btn_dashboard.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dashboard.Location = new System.Drawing.Point(74, 233);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(256, 63);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.Color.White;
            this.btn_Customer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.btn_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Customer.Location = new System.Drawing.Point(74, 408);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(259, 63);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "Customers";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(93, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 213);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Clerk_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(1924, 1025);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtbox_search);
            this.Controls.Add(this.btn_ViewAuthors);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Genre);
            this.Controls.Add(this.dgv_books);
            this.Controls.Add(this.btn_deleteBook);
            this.Controls.Add(this.btn_updateBook);
            this.Controls.Add(this.btn_addBook);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.chart1);
            this.Name = "Clerk_Book";
            this.Text = "Clerk_Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ViewAuthors;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbox_discount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmb_author_2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb_author_1;
        private System.Windows.Forms.ComboBox cmb_genre;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Isbn;
        private System.Windows.Forms.TextBox txt_Bookname;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Genre;
        private System.Windows.Forms.DataGridView dgv_books;
        private System.Windows.Forms.Button btn_deleteBook;
        private System.Windows.Forms.Button btn_updateBook;
        private System.Windows.Forms.Button btn_addBook;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtbox_search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.Button btn_Cusorder;
        private System.Windows.Forms.Button btn_Sales;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}