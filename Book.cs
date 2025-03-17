using Bookhaven.AppClasses;
using Bookhaven.CommonClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookhaven
{

    public partial class Book : Form
    {
        filloperation fill = new filloperation();
        cls_book clsbook = new cls_book();

        private int _staffId;

        public Book( int staffId)
        {
            _staffId = staffId;
            InitializeComponent();
            FirstRun();
        }
        void FirstRun()
        {
            // Clear combo boxes and text fields
            cmb_genre.SelectedIndex = -1;
            cmb_author_1.SelectedIndex = -1;
            cmb_author_2.SelectedIndex = -1;
            txt_Bookname.Text = "";
            txt_Isbn.Text = "";
            txt_Price.Text = "0";
            txtbox_discount.Text = "0";
            txt_Stock.Text = ""; // Clear stock field

            // Populate genre combo box
            string genreQuery = "SELECT Genre_Id, genreName FROM Genre";
            fill.combobox(genreQuery, cmb_genre, "genreName", "Genre_Id");

            // Populate author combo boxes
            string authorQuery = "SELECT Author_Id, AuthorName FROM Author";
            fill.combobox(authorQuery, cmb_author_1, "AuthorName", "Author_Id");
            fill.combobox(authorQuery, cmb_author_2, "AuthorName", "Author_Id");

            // Populate dgv_books with books and their stock details
            string bookQuery = @"
        SELECT 
            b.Book_Id,
            b.Book_Name,
            b.ISBN,
            b.Price,
            b.Discount,
            g.genreName AS Genre,
            STRING_AGG(a.AuthorName, ', ') AS Authors,
            s.Stock_Quantity AS Stock
        FROM Book b
        LEFT JOIN Genre g ON b.Genre_Id_fk = g.Genre_Id
        LEFT JOIN BookAuthor ba ON b.Book_Id = ba.Book_Id_fk
        LEFT JOIN Author a ON ba.Author_Id_fk = a.Author_Id
        LEFT JOIN Stock s ON b.Book_Id = s.Book_Id_fk
        GROUP BY b.Book_Id, b.Book_Name, b.ISBN, b.Price, b.Discount, g.genreName, s.Stock_Quantity";

            fill.FillDataGridView(bookQuery, dgv_books);
            dgv_books.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Rename columns for clarity
            dgv_books.Columns[0].HeaderText = "ID";
            dgv_books.Columns[1].HeaderText = "Book Name";
            dgv_books.Columns[2].HeaderText = "ISBN";
            dgv_books.Columns[3].HeaderText = "Price";
            dgv_books.Columns[4].HeaderText = "Discount";
            dgv_books.Columns[5].HeaderText = "Genre";
            dgv_books.Columns[6].HeaderText = "Authors";
            dgv_books.Columns[7].HeaderText = "Stock";
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_Bookname_TextChanged(object sender, EventArgs e)
        {
            clsbook.Book_Name = txt_Bookname.Text.Trim();
        }

        private void btn_Genre_Click(object sender, EventArgs e)
        {
            view_genre genre = new view_genre();
            genre.ShowDialog();
        }

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrEmpty(txt_Bookname.Text) || string.IsNullOrEmpty(txt_Isbn.Text))
                {
                    MessageBox.Show("Please enter a valid book name and ISBN.", "Validation Error");
                    return;
                }

                if (cmb_genre.SelectedIndex == -1 || cmb_author_1.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a genre and at least one author.", "Validation Error");
                    return;
                }

                // Assign properties
                clsbook.Book_Name = txt_Bookname.Text.Trim();
                clsbook.ISBN = txt_Isbn.Text.Trim();
                clsbook.Price = float.Parse(txt_Price.Text);
                clsbook.Discount = float.Parse(txtbox_discount.Text);
                clsbook.Genre_Id_fk = Convert.ToInt32(cmb_genre.SelectedValue);

                // Add selected authors
                clsbook.authorIds.Add(Convert.ToInt32(cmb_author_1.SelectedValue));
                if (cmb_author_2.SelectedIndex != -1 && cmb_author_1.SelectedValue.ToString() != cmb_author_2.SelectedValue.ToString())
                {
                    clsbook.authorIds.Add(Convert.ToInt32(cmb_author_2.SelectedValue));
                }

                // Insert data into Book table
                clsbook.Insertdata();

                // Update stock if provided
                int stockQuantity = 0;
                if (!string.IsNullOrEmpty(txt_Stock.Text) && int.TryParse(txt_Stock.Text, out stockQuantity))
                {
                    cls_Stock stock = new cls_Stock
                    {
                        Stock_Quantity = stockQuantity,
                        Book_Id_fk = clsbook.Book_Id, // Use the newly inserted book's ID
                        Stock_QuantityPrice = clsbook.Price
                    };
                    stock.Insertdata();
                }

                // Refresh the form
                FirstRun();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Insert Failed");
            }

        }
     


        private void txt_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Isbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Genre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ViewAuthors_Click(object sender, EventArgs e)
        {
            view_author aut = new view_author();
            aut.ShowDialog();
        }

        private void btn_updateBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected in the DataGridView
                if (clsbook.Book_Id <= 0)
                {
                    MessageBox.Show("Please select a book to update.", "No Selection");
                    return;
                }

                // Assign properties
                clsbook.Book_Name = txt_Bookname.Text.Trim();
                clsbook.ISBN = txt_Isbn.Text.Trim();
                clsbook.Price = float.Parse(txt_Price.Text);
                clsbook.Discount = float.Parse(txtbox_discount.Text);
                clsbook.Genre_Id_fk = Convert.ToInt32(cmb_genre.SelectedValue);

                // Add selected authors
                clsbook.authorIds.Clear();
                clsbook.authorIds.Add(Convert.ToInt32(cmb_author_1.SelectedValue));
                if (cmb_author_2.SelectedIndex != -1 && cmb_author_1.SelectedValue.ToString() != cmb_author_2.SelectedValue.ToString())
                {
                    clsbook.authorIds.Add(Convert.ToInt32(cmb_author_2.SelectedValue));
                }

                // Update book data
                clsbook.UpdateData();

                // Update stock if provided
                int stockQuantity = 0;
                if (!string.IsNullOrEmpty(txt_Stock.Text) && int.TryParse(txt_Stock.Text, out stockQuantity))
                {
                    cls_Stock stock = new cls_Stock
                    {
                        Stock_Quantity = stockQuantity,
                        Book_Id_fk = clsbook.Book_Id,
                        Stock_QuantityPrice = clsbook.Price
                    };

                    // Check if stock exists for this book
                    string checkQuery = "SELECT COUNT(*) FROM Stock WHERE Book_Id_fk = @Book_Id";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, clsbook.conn);
                    checkCmd.Parameters.AddWithValue("@Book_Id", clsbook.Book_Id);
                    clsbook.conn.Open();
                    int count = (int)checkCmd.ExecuteScalar();
                    clsbook.conn.Close();

                    if (count > 0)
                    {
                        // Update existing stock
                        stock.UpdateData();
                    }
                    else
                    {
                        // Insert new stock
                        stock.Insertdata();
                    }
                }

                // Refresh the form
                FirstRun();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Update Failed");
            }
        }

        private void btn_deleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected in the DataGridView
                if (clsbook.Book_Id <= 0)
                {
                    MessageBox.Show("Please select a book to delete.", "No Selection");
                    return;
                }

                // Delete book data
                clsbook.DeleteDate();

                // Refresh the form
                FirstRun();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Delete Failed");
            }
        }

        private void dgv_book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cmb_genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string genreQuery = "SELECT Genre_Id, genreName FROM Genre";
            fill.combobox(genreQuery, cmb_genre, "genreName", "Genre_Id");
       
        }

        private void cmb_author_SelectedIndexChanged(object sender, EventArgs e)
        {
            string authorQuery = "SELECT Author_Id, AuthorName FROM Author";
            fill.combobox(authorQuery, cmb_author_1, "AuthorName", "Author_Id");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbox_discount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            view_stock stc = new view_stock();
            stc.ShowDialog();
        }

        private void dgv_books_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Get selected book ID
                    int bookId = Convert.ToInt32(dgv_books.Rows[e.RowIndex].Cells["Book_Id"].Value);

                    // Load book data
                    clsbook.Book_Id = bookId;
                    clsbook.Getdata();

                    // Populate form fields
                    txt_Bookname.Text = clsbook.Book_Name;
                    txt_Isbn.Text = clsbook.ISBN;
                    txt_Price.Text = clsbook.Price.ToString();
                    txtbox_discount.Text = clsbook.Discount.ToString();
                    cmb_genre.SelectedValue = clsbook.Genre_Id_fk;

                    // Populate authors
                    cmb_author_1.SelectedValue = clsbook.authorIds.Count > 0 ? clsbook.authorIds[0] : -1;
                    cmb_author_2.SelectedValue = clsbook.authorIds.Count > 1 ? clsbook.authorIds[1] : -1;

                    // Populate stock
                    string stockQuery = "SELECT Stock_Quantity FROM Stock WHERE Book_Id_fk = @Book_Id";
                    SqlCommand stockCmd = new SqlCommand(stockQuery, clsbook.conn);
                    stockCmd.Parameters.AddWithValue("@Book_Id", bookId);
                    clsbook.conn.Open();
                    object stockResult = stockCmd.ExecuteScalar();
                    clsbook.conn.Close();
                    txt_Stock.Text = stockResult != null ? stockResult.ToString() : "0";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Fetch Failed");
                }
            }
        }

        private void cmb_author_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string authorQuery = "SELECT Author_Id, AuthorName FROM Author";
            fill.combobox(authorQuery, cmb_author_1, "AuthorName", "Author_Id");
        }

        private void dgv_books_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Customer cstmr = new Customer(_staffId);
            cstmr.ShowDialog();
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales(_staffId);
            sale.ShowDialog();
        }

        private void btn_Cusorder_Click(object sender, EventArgs e)
        {
            Customer cusorder = new Customer(_staffId);
            cusorder.ShowDialog();
        }

        private void btn_Supporder_Click(object sender, EventArgs e)
        {
            SupplierOrder supplierOrder = new SupplierOrder(_staffId);
            supplierOrder.ShowDialog();
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            Book book = new Book(_staffId);
            book.ShowDialog();
        }

        private void btn_Suppliers_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers(_staffId);
            suppliers.ShowDialog();
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff(_staffId);
            staff.ShowDialog();
        }
    }
}
