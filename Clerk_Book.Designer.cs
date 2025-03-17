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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ViewAuthors
            // 
            this.btn_ViewAuthors.BackColor = System.Drawing.Color.Black;
            this.btn_ViewAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewAuthors.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_ViewAuthors.ForeColor = System.Drawing.Color.White;
            this.btn_ViewAuthors.Location = new System.Drawing.Point(25, 186);
            this.btn_ViewAuthors.Name = "btn_ViewAuthors";
            this.btn_ViewAuthors.Size = new System.Drawing.Size(247, 63);
            this.btn_ViewAuthors.TabIndex = 64;
            this.btn_ViewAuthors.Text = "View Authors";
            this.btn_ViewAuthors.UseVisualStyleBackColor = false;
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
            this.panel2.Location = new System.Drawing.Point(403, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 285);
            this.panel2.TabIndex = 59;
            // 
            // txtbox_discount
            // 
            this.txtbox_discount.Location = new System.Drawing.Point(29, 201);
            this.txtbox_discount.Name = "txtbox_discount";
            this.txtbox_discount.Size = new System.Drawing.Size(190, 22);
            this.txtbox_discount.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(25, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 36);
            this.label16.TabIndex = 42;
            this.label16.Text = "Discount";
            // 
            // cmb_author_2
            // 
            this.cmb_author_2.FormattingEnabled = true;
            this.cmb_author_2.Location = new System.Drawing.Point(506, 132);
            this.cmb_author_2.Name = "cmb_author_2";
            this.cmb_author_2.Size = new System.Drawing.Size(190, 24);
            this.cmb_author_2.TabIndex = 41;
            this.cmb_author_2.SelectedIndexChanged += new System.EventHandler(this.cmb_author_2_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(502, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 36);
            this.label15.TabIndex = 40;
            this.label15.Text = "Author 2";
            // 
            // cmb_author_1
            // 
            this.cmb_author_1.FormattingEnabled = true;
            this.cmb_author_1.Location = new System.Drawing.Point(275, 130);
            this.cmb_author_1.Name = "cmb_author_1";
            this.cmb_author_1.Size = new System.Drawing.Size(190, 24);
            this.cmb_author_1.TabIndex = 39;
            this.cmb_author_1.SelectedIndexChanged += new System.EventHandler(this.cmb_author_1_SelectedIndexChanged);
            // 
            // cmb_genre
            // 
            this.cmb_genre.FormattingEnabled = true;
            this.cmb_genre.Location = new System.Drawing.Point(19, 130);
            this.cmb_genre.Name = "cmb_genre";
            this.cmb_genre.Size = new System.Drawing.Size(190, 24);
            this.cmb_genre.TabIndex = 38;
            this.cmb_genre.SelectedIndexChanged += new System.EventHandler(this.cmb_genre_SelectedIndexChanged);
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(272, 198);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(190, 22);
            this.txt_Stock.TabIndex = 37;
            this.txt_Stock.TextChanged += new System.EventHandler(this.txt_Stock_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(15, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 36);
            this.label14.TabIndex = 34;
            this.label14.Text = "Genre";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(277, 43);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(190, 22);
            this.txt_Price.TabIndex = 33;
            // 
            // txt_Isbn
            // 
            this.txt_Isbn.Location = new System.Drawing.Point(506, 43);
            this.txt_Isbn.Name = "txt_Isbn";
            this.txt_Isbn.Size = new System.Drawing.Size(190, 22);
            this.txt_Isbn.TabIndex = 32;
            // 
            // txt_Bookname
            // 
            this.txt_Bookname.Location = new System.Drawing.Point(19, 44);
            this.txt_Bookname.Name = "txt_Bookname";
            this.txt_Bookname.Size = new System.Drawing.Size(190, 22);
            this.txt_Bookname.TabIndex = 31;
            this.txt_Bookname.TextChanged += new System.EventHandler(this.txt_Bookname_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(269, 93);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(103, 36);
            this.label26.TabIndex = 28;
            this.label26.Text = "Author 1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(271, 157);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 36);
            this.label22.TabIndex = 14;
            this.label22.Text = "Stock";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(502, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 36);
            this.label19.TabIndex = 8;
            this.label19.Text = "ISBN";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(279, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 36);
            this.label18.TabIndex = 6;
            this.label18.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book Name";
            // 
            // btn_Genre
            // 
            this.btn_Genre.BackColor = System.Drawing.Color.Black;
            this.btn_Genre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Genre.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_Genre.ForeColor = System.Drawing.Color.White;
            this.btn_Genre.Location = new System.Drawing.Point(25, 109);
            this.btn_Genre.Name = "btn_Genre";
            this.btn_Genre.Size = new System.Drawing.Size(247, 58);
            this.btn_Genre.TabIndex = 58;
            this.btn_Genre.Text = "View Genre";
            this.btn_Genre.UseVisualStyleBackColor = false;
            this.btn_Genre.Click += new System.EventHandler(this.btn_Genre_Click);
            // 
            // dgv_books
            // 
            this.dgv_books.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Location = new System.Drawing.Point(403, 608);
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
            this.btn_deleteBook.BackColor = System.Drawing.Color.Red;
            this.btn_deleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteBook.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_deleteBook.Location = new System.Drawing.Point(25, 111);
            this.btn_deleteBook.Name = "btn_deleteBook";
            this.btn_deleteBook.Size = new System.Drawing.Size(247, 67);
            this.btn_deleteBook.TabIndex = 62;
            this.btn_deleteBook.Text = "Delete Book";
            this.btn_deleteBook.UseVisualStyleBackColor = false;
            this.btn_deleteBook.Click += new System.EventHandler(this.btn_deleteBook_Click);
            // 
            // btn_updateBook
            // 
            this.btn_updateBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_updateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateBook.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_updateBook.Location = new System.Drawing.Point(25, 23);
            this.btn_updateBook.Name = "btn_updateBook";
            this.btn_updateBook.Size = new System.Drawing.Size(247, 67);
            this.btn_updateBook.TabIndex = 61;
            this.btn_updateBook.Text = "Update Book";
            this.btn_updateBook.UseVisualStyleBackColor = false;
            this.btn_updateBook.Click += new System.EventHandler(this.btn_updateBook_Click);
            // 
            // btn_addBook
            // 
            this.btn_addBook.BackColor = System.Drawing.Color.Lime;
            this.btn_addBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addBook.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_addBook.Location = new System.Drawing.Point(25, 194);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(247, 67);
            this.btn_addBook.TabIndex = 60;
            this.btn_addBook.Text = "Add Book";
            this.btn_addBook.UseVisualStyleBackColor = false;
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.BackColor = System.Drawing.Color.Black;
            this.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_stock.ForeColor = System.Drawing.Color.White;
            this.btn_stock.Location = new System.Drawing.Point(25, 27);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(247, 66);
            this.btn_stock.TabIndex = 65;
            this.btn_stock.Text = "View Stocks";
            this.btn_stock.UseVisualStyleBackColor = false;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(1711, 1344);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(2095, 733);
            this.chart1.TabIndex = 57;
            this.chart1.Text = "chart1";
            // 
            // txtbox_search
            // 
            this.txtbox_search.Location = new System.Drawing.Point(403, 540);
            this.txtbox_search.Multiline = true;
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(363, 45);
            this.txtbox_search.TabIndex = 44;
            this.txtbox_search.TextChanged += new System.EventHandler(this.txtbox_search_TextChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_Search.Location = new System.Drawing.Point(798, 540);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(190, 45);
            this.btn_Search.TabIndex = 66;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_Reset.Location = new System.Drawing.Point(1014, 540);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(190, 45);
            this.btn_Reset.TabIndex = 67;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
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
            this.panel3.Size = new System.Drawing.Size(1455, 159);
            this.panel3.TabIndex = 104;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1178, 45);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 905);
            this.panel1.TabIndex = 103;
            // 
            // btn_Book
            // 
            this.btn_Book.BackColor = System.Drawing.Color.White;
            this.btn_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Book.ForeColor = System.Drawing.Color.Black;
            this.btn_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Book.Location = new System.Drawing.Point(53, 482);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(243, 63);
            this.btn_Book.TabIndex = 5;
            this.btn_Book.Text = "Book Details";
            this.btn_Book.UseVisualStyleBackColor = false;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
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
            this.btn_Cusorder.Location = new System.Drawing.Point(53, 375);
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
            this.btn_Sales.Location = new System.Drawing.Point(53, 270);
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
            this.btn_Customer.Location = new System.Drawing.Point(53, 161);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(243, 63);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "Customer Details";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_deleteBook);
            this.panel4.Controls.Add(this.btn_updateBook);
            this.panel4.Controls.Add(this.btn_addBook);
            this.panel4.Location = new System.Drawing.Point(1232, 211);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(299, 285);
            this.panel4.TabIndex = 105;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_ViewAuthors);
            this.panel5.Controls.Add(this.btn_Genre);
            this.panel5.Controls.Add(this.btn_stock);
            this.panel5.Location = new System.Drawing.Point(1232, 609);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(299, 274);
            this.panel5.TabIndex = 106;
            // 
            // Clerk_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1809, 905);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtbox_search);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_books);
            this.Controls.Add(this.chart1);
            this.Name = "Clerk_Book";
            this.Text = "Clerk_Book";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}