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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1692, 1243);
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
            this.panel2.Location = new System.Drawing.Point(406, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 277);
            this.panel2.TabIndex = 48;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtbox_discount
            // 
            this.txtbox_discount.Location = new System.Drawing.Point(19, 210);
            this.txtbox_discount.Multiline = true;
            this.txtbox_discount.Name = "txtbox_discount";
            this.txtbox_discount.Size = new System.Drawing.Size(214, 37);
            this.txtbox_discount.TabIndex = 43;
            this.txtbox_discount.TextChanged += new System.EventHandler(this.txtbox_discount_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(15, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 36);
            this.label16.TabIndex = 42;
            this.label16.Text = "Discount";
            // 
            // cmb_author_2
            // 
            this.cmb_author_2.FormattingEnabled = true;
            this.cmb_author_2.Location = new System.Drawing.Point(512, 130);
            this.cmb_author_2.Name = "cmb_author_2";
            this.cmb_author_2.Size = new System.Drawing.Size(190, 24);
            this.cmb_author_2.TabIndex = 41;
            this.cmb_author_2.SelectedIndexChanged += new System.EventHandler(this.cmb_author_2_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(506, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 36);
            this.label15.TabIndex = 40;
            this.label15.Text = "Author 2";
            // 
            // cmb_author_1
            // 
            this.cmb_author_1.FormattingEnabled = true;
            this.cmb_author_1.Location = new System.Drawing.Point(274, 130);
            this.cmb_author_1.Name = "cmb_author_1";
            this.cmb_author_1.Size = new System.Drawing.Size(190, 24);
            this.cmb_author_1.TabIndex = 39;
            this.cmb_author_1.SelectedIndexChanged += new System.EventHandler(this.cmb_author_SelectedIndexChanged);
            // 
            // cmb_genre
            // 
            this.cmb_genre.FormattingEnabled = true;
            this.cmb_genre.Location = new System.Drawing.Point(19, 130);
            this.cmb_genre.Name = "cmb_genre";
            this.cmb_genre.Size = new System.Drawing.Size(214, 24);
            this.cmb_genre.TabIndex = 38;
            this.cmb_genre.SelectedIndexChanged += new System.EventHandler(this.cmb_genre_SelectedIndexChanged);
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(274, 210);
            this.txt_Stock.Multiline = true;
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(190, 37);
            this.txt_Stock.TabIndex = 37;
            this.txt_Stock.TextChanged += new System.EventHandler(this.txt_Stock_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(13, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 36);
            this.label14.TabIndex = 34;
            this.label14.Text = "Genre";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(274, 44);
            this.txt_Price.Multiline = true;
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(190, 44);
            this.txt_Price.TabIndex = 33;
            this.txt_Price.TextChanged += new System.EventHandler(this.txt_Price_TextChanged);
            // 
            // txt_Isbn
            // 
            this.txt_Isbn.Location = new System.Drawing.Point(512, 44);
            this.txt_Isbn.Multiline = true;
            this.txt_Isbn.Name = "txt_Isbn";
            this.txt_Isbn.Size = new System.Drawing.Size(190, 44);
            this.txt_Isbn.TabIndex = 32;
            this.txt_Isbn.TextChanged += new System.EventHandler(this.txt_Isbn_TextChanged);
            // 
            // txt_Bookname
            // 
            this.txt_Bookname.Location = new System.Drawing.Point(19, 44);
            this.txt_Bookname.Multiline = true;
            this.txt_Bookname.Name = "txt_Bookname";
            this.txt_Bookname.Size = new System.Drawing.Size(214, 44);
            this.txt_Bookname.TabIndex = 31;
            this.txt_Bookname.TextChanged += new System.EventHandler(this.txt_Bookname_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(268, 91);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(103, 36);
            this.label26.TabIndex = 28;
            this.label26.Text = "Author 1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(268, 171);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 36);
            this.label22.TabIndex = 14;
            this.label22.Text = "Stock";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(506, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 36);
            this.label19.TabIndex = 8;
            this.label19.Text = "ISBN";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(268, 9);
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
            // dgv_books
            // 
            this.dgv_books.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Location = new System.Drawing.Point(406, 520);
            this.dgv_books.MultiSelect = false;
            this.dgv_books.Name = "dgv_books";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_books.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_books.RowHeadersWidth = 51;
            this.dgv_books.RowTemplate.Height = 24;
            this.dgv_books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_books.Size = new System.Drawing.Size(826, 324);
            this.dgv_books.TabIndex = 52;
            this.dgv_books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_book_CellContentClick);
            this.dgv_books.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_books_CellContentDoubleClick);
            this.dgv_books.SelectionChanged += new System.EventHandler(this.dgv_books_SelectionChanged);
            // 
            // btn_deleteBook
            // 
            this.btn_deleteBook.BackColor = System.Drawing.Color.Red;
            this.btn_deleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteBook.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_deleteBook.Location = new System.Drawing.Point(19, 107);
            this.btn_deleteBook.Name = "btn_deleteBook";
            this.btn_deleteBook.Size = new System.Drawing.Size(237, 67);
            this.btn_deleteBook.TabIndex = 51;
            this.btn_deleteBook.Text = "Delete Book";
            this.btn_deleteBook.UseVisualStyleBackColor = false;
            this.btn_deleteBook.Click += new System.EventHandler(this.btn_deleteBook_Click);
            // 
            // btn_updateBook
            // 
            this.btn_updateBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_updateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateBook.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_updateBook.Location = new System.Drawing.Point(19, 20);
            this.btn_updateBook.Name = "btn_updateBook";
            this.btn_updateBook.Size = new System.Drawing.Size(237, 67);
            this.btn_updateBook.TabIndex = 50;
            this.btn_updateBook.Text = "Update Book";
            this.btn_updateBook.UseVisualStyleBackColor = false;
            this.btn_updateBook.Click += new System.EventHandler(this.btn_updateBook_Click);
            // 
            // btn_addBook
            // 
            this.btn_addBook.BackColor = System.Drawing.Color.Lime;
            this.btn_addBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addBook.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_addBook.Location = new System.Drawing.Point(19, 187);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(237, 67);
            this.btn_addBook.TabIndex = 49;
            this.btn_addBook.Text = "Add Book";
            this.btn_addBook.UseVisualStyleBackColor = false;
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // btn_Genre
            // 
            this.btn_Genre.BackColor = System.Drawing.Color.Black;
            this.btn_Genre.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_Genre.ForeColor = System.Drawing.Color.White;
            this.btn_Genre.Location = new System.Drawing.Point(21, 121);
            this.btn_Genre.Name = "btn_Genre";
            this.btn_Genre.Size = new System.Drawing.Size(237, 70);
            this.btn_Genre.TabIndex = 34;
            this.btn_Genre.Text = "View Genre";
            this.btn_Genre.UseVisualStyleBackColor = false;
            this.btn_Genre.Click += new System.EventHandler(this.btn_Genre_Click);
            // 
            // btn_ViewAuthors
            // 
            this.btn_ViewAuthors.BackColor = System.Drawing.Color.Black;
            this.btn_ViewAuthors.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_ViewAuthors.ForeColor = System.Drawing.Color.White;
            this.btn_ViewAuthors.Location = new System.Drawing.Point(21, 226);
            this.btn_ViewAuthors.Name = "btn_ViewAuthors";
            this.btn_ViewAuthors.Size = new System.Drawing.Size(237, 70);
            this.btn_ViewAuthors.TabIndex = 53;
            this.btn_ViewAuthors.Text = "View Authors";
            this.btn_ViewAuthors.UseVisualStyleBackColor = false;
            this.btn_ViewAuthors.Click += new System.EventHandler(this.btn_ViewAuthors_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.BackColor = System.Drawing.Color.Black;
            this.btn_stock.Font = new System.Drawing.Font("Poppins Medium", 13.8F);
            this.btn_stock.ForeColor = System.Drawing.Color.White;
            this.btn_stock.Location = new System.Drawing.Point(21, 26);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(237, 70);
            this.btn_stock.TabIndex = 54;
            this.btn_stock.Text = "View Stocks";
            this.btn_stock.UseVisualStyleBackColor = false;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
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
            this.panel3.Location = new System.Drawing.Point(355, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1231, 133);
            this.panel3.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1002, 34);
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
            this.label1.Location = new System.Drawing.Point(41, 39);
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
            this.panel1.Size = new System.Drawing.Size(355, 896);
            this.panel1.TabIndex = 55;
            // 
            // btn_Suppliers
            // 
            this.btn_Suppliers.BackColor = System.Drawing.Color.White;
            this.btn_Suppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suppliers.ForeColor = System.Drawing.Color.Black;
            this.btn_Suppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Suppliers.Location = new System.Drawing.Point(50, 577);
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
            this.btn_Staff.Location = new System.Drawing.Point(50, 676);
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
            this.btn_Book.Location = new System.Drawing.Point(50, 469);
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
            this.btn_Supporder.Location = new System.Drawing.Point(50, 363);
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
            this.btn_Cusorder.Location = new System.Drawing.Point(50, 254);
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
            this.btn_Sales.Location = new System.Drawing.Point(50, 146);
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
            this.btn_Customer.Location = new System.Drawing.Point(50, 39);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(243, 63);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "Customer Details";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_stock);
            this.panel4.Controls.Add(this.btn_ViewAuthors);
            this.panel4.Controls.Add(this.btn_Genre);
            this.panel4.Location = new System.Drawing.Point(1269, 520);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 324);
            this.panel4.TabIndex = 57;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_deleteBook);
            this.panel5.Controls.Add(this.btn_updateBook);
            this.panel5.Controls.Add(this.btn_addBook);
            this.panel5.Location = new System.Drawing.Point(1271, 194);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(273, 277);
            this.panel5.TabIndex = 58;
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
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 896);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_books);
            this.Controls.Add(this.chart1);
            this.Name = "Book";
            this.Text = "Book";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
    }
}