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
    public partial class Clerk_Book : Form
    {
        filloperation fill = new filloperation();
        cls_book clsBook = new cls_book();

        private string searchTerm = string.Empty;
        public Clerk_Book()
        {
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

            // Populate dgv_books with all books and their stock details
            Clerk_Book_Load();
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
                clsBook.Book_Name = txt_Bookname.Text.Trim();
                clsBook.ISBN = txt_Isbn.Text.Trim();
                clsBook.Price = float.Parse(txt_Price.Text);
                clsBook.Discount = float.Parse(txtbox_discount.Text);
                clsBook.Genre_Id_fk = Convert.ToInt32(cmb_genre.SelectedValue);

                // Add selected authors
                clsBook.Author_Ids.Add(Convert.ToInt32(cmb_author_1.SelectedValue));
                if (cmb_author_2.SelectedIndex != -1 && cmb_author_1.SelectedValue.ToString() != cmb_author_2.SelectedValue.ToString())
                {
                    clsBook.Author_Ids.Add(Convert.ToInt32(cmb_author_2.SelectedValue));
                }

                // Insert data into Book table
                clsBook.Insertdata();

                // Update stock if provided
                int stockQuantity = 0;
                if (!string.IsNullOrEmpty(txt_Stock.Text) && int.TryParse(txt_Stock.Text, out stockQuantity))
                {
                    cls_stock stock = new cls_stock
                    {
                        Stock_Quantity = stockQuantity,
                        Book_Id_fk = clsBook.Book_Id, // Use the newly inserted book's ID
                        Stock_QuantityPrice = clsBook.Price
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

        private void btn_updateBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected in the DataGridView
                if (clsBook.Book_Id <= 0)
                {
                    MessageBox.Show("Please select a book to update.", "No Selection");
                    return;
                }

                // Assign properties
                clsBook.Book_Name = txt_Bookname.Text.Trim();
                clsBook.ISBN = txt_Isbn.Text.Trim();
                clsBook.Price = float.Parse(txt_Price.Text);
                clsBook.Discount = float.Parse(txtbox_discount.Text);
                clsBook.Genre_Id_fk = Convert.ToInt32(cmb_genre.SelectedValue);

                // Add selected authors
                clsBook.Author_Ids.Clear();
                clsBook.Author_Ids.Add(Convert.ToInt32(cmb_author_1.SelectedValue));
                if (cmb_author_2.SelectedIndex != -1 && cmb_author_1.SelectedValue.ToString() != cmb_author_2.SelectedValue.ToString())
                {
                    clsBook.Author_Ids.Add(Convert.ToInt32(cmb_author_2.SelectedValue));
                }

                // Update book data
                clsBook.UpdateData();

                // Update stock if provided
                int stockQuantity = 0;
                if (!string.IsNullOrEmpty(txt_Stock.Text) && int.TryParse(txt_Stock.Text, out stockQuantity))
                {
                    cls_stock stock = new cls_stock
                    {
                        Stock_Quantity = stockQuantity,
                        Book_Id_fk = clsBook.Book_Id,
                        Stock_QuantityPrice = clsBook.Price
                    };

                    // Check if stock exists for this book
                    string checkQuery = "SELECT COUNT(*) FROM Stock WHERE Book_Id_fk = @Book_Id";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, clsBook.conn);
                    checkCmd.Parameters.AddWithValue("@Book_Id", clsBook.Book_Id);
                    clsBook.conn.Open();
                    int count = (int)checkCmd.ExecuteScalar();
                    clsBook.conn.Close();

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

        private void btn_Genre_Click(object sender, EventArgs e)
        {
            view_genre genre = new view_genre();
            genre.ShowDialog();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            view_stock stc = new view_stock();
            stc.ShowDialog();
        }

        private void btn_ViewAuthors_Click(object sender, EventArgs e)
        {
            view_author aut = new view_author();
            aut.ShowDialog();
        }

        private void btn_deleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected in the DataGridView
                if (clsBook.Book_Id <= 0)
                {
                    MessageBox.Show("Please select a book to delete.", "No Selection");
                    return;
                }

                // Delete book data
                clsBook.DeleteDate();

                // Refresh the form
                FirstRun();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Delete Failed");
            }
        }

        private void dgv_books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    clsBook.Book_Id = bookId;
                    clsBook.Getdata();

                    // Populate form fields
                    txt_Bookname.Text = clsBook.Book_Name;
                    txt_Isbn.Text = clsBook.ISBN;
                    txt_Price.Text = clsBook.Price.ToString();
                    txtbox_discount.Text = clsBook.Discount.ToString();
                    cmb_genre.SelectedValue = clsBook.Genre_Id_fk;

                    // Populate authors
                    cmb_author_1.SelectedValue = clsBook.Author_Ids.Count > 0 ? clsBook.Author_Ids[0] : -1;
                    cmb_author_2.SelectedValue = clsBook.Author_Ids.Count > 1 ? clsBook.Author_Ids[1] : -1;

                    // Populate stock
                    string stockQuery = "SELECT Stock_Quantity FROM Stock WHERE Book_Id_fk = @Book_Id";
                    SqlCommand stockCmd = new SqlCommand(stockQuery, clsBook.conn);
                    stockCmd.Parameters.AddWithValue("@Book_Id", bookId);
                    clsBook.conn.Open();
                    object stockResult = stockCmd.ExecuteScalar();
                    clsBook.conn.Close();
                    txt_Stock.Text = stockResult != null ? stockResult.ToString() : "0";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Fetch Failed");
                }
            }
        }

        private void cmb_genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string genreQuery = "SELECT Genre_Id, genreName FROM Genre";
            fill.combobox(genreQuery, cmb_genre, "genreName", "Genre_Id");
        }

        private void cmb_author_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string authorQuery = "SELECT Author_Id, AuthorName FROM Author";
            fill.combobox(authorQuery, cmb_author_1, "AuthorName", "Author_Id");
        }

        private void cmb_author_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string authorQuery = "SELECT Author_Id, AuthorName FROM Author";
            fill.combobox(authorQuery, cmb_author_1, "AuthorName", "Author_Id");
        }

        private void txt_Stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Bookname_TextChanged(object sender, EventArgs e)
        {
            clsBook.Book_Name = txt_Bookname.Text.Trim();
        }

        private void txtbox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            // Clear the search box
            txtbox_search.Text = "";

            // Reset the searchTerm variable
            searchTerm = string.Empty;

            // Reload all books
            Clerk_Book_Load();
        }

        private void Clerk_Book_Load()
        {
            try
            {
                string bookQuery;

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    // Filter books by name (case-insensitive)
                    bookQuery = @"
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
                WHERE b.Book_Name LIKE @SearchTerm
                GROUP BY b.Book_Id, b.Book_Name, b.ISBN, b.Price, b.Discount, g.genreName, s.Stock_Quantity";
                }
                else
                {
                    // Load all books
                    bookQuery = @"
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
                }

                SqlCommand cmd = new SqlCommand(bookQuery, clsBook.conn);

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);

                dgv_books.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Fetch Failed");
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            // Capture the search term from the text box
            searchTerm = txtbox_search.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a book name to search.", "Validation Error");
                return;
            }

            // Load books matching the search term
            Clerk_Book_Load();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Customer_Clerk customer = new Customer_Clerk();
            customer.ShowDialog();
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            Clerk_Sales sales = new Clerk_Sales();
            sales.ShowDialog();
        }

        private void btn_Cusorder_Click(object sender, EventArgs e)
        {
            Clerk_CustomerOrder clerk_CustomerOrder = new Clerk_CustomerOrder();
            clerk_CustomerOrder.ShowDialog();
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            Clerk_Book book = new Clerk_Book();
            book.ShowDialog();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            // Display a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // Clear session data or reset user-specific information
                //Program.CurrentUser = null;

                // Close the current Dashboard form
                this.Close();

                // Show the LoginForm
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard_Clerk dasclerk = new Dashboard_Clerk();
            dasclerk.ShowDialog();
        }
    }
}
