using Bookhaven.AppClasses;
using Bookhaven.CommonClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        cls_book clsBook = new cls_book();


        public Book()
        {
            InitializeComponent();
            FirstRun();
        }
        void FirstRun()
        {
            // Clear form fields
            txt_Bookname.Text = "";
            txt_Isbn.Text = "";
            txt_Price.Text = "0.0";
            txtbox_discount.Text = "0.0";

            // Populate cmb_genre (Genres)
            string genreQuery = "SELECT Genre_Id, genreName FROM Genre";
            fill.combobox(genreQuery, cmb_genre, "genreName", "Genre_Id");

            // Populate cmb_author_1 and cmb_author_2 (Authors)
            string authorQuery = "SELECT Author_Id, AuthorName FROM Author";
            fill.combobox(authorQuery, cmb_author_1, "AuthorName", "Author_Id");
            fill.combobox(authorQuery, cmb_author_2, "AuthorName", "Author_Id");

            // Populate dgv_books (Books with Genre and Authors)
            string bookQuery = @"
        SELECT 
            b.Book_Id,
            b.Book_Name,
            b.ISBN,
            b.Price,
            b.Discount,
            g.genreName AS Genre,
            STRING_AGG(a.AuthorName, ', ') AS Authors
        FROM Book b
        LEFT JOIN Genre g ON b.Genre_Id_fk = g.Genre_Id
        LEFT JOIN BookAuthor ba ON b.Book_Id = ba.Book_Id_fk
        LEFT JOIN Author a ON ba.Author_Id_fk = a.Author_Id
        GROUP BY b.Book_Id, b.Book_Name, b.ISBN, b.Price, b.Discount, g.genreName";

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
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_Bookname_TextChanged(object sender, EventArgs e)
        {
            clsBook.Book_Name = txt_Bookname.Text.Trim();
        }

        private void btn_Genre_Click(object sender, EventArgs e)
        {
            view_genre genre = new view_genre();
            genre.ShowDialog();
        }

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            cls_book clsbook = new cls_book();

            // Assign properties
            clsbook.Book_Name = txt_Bookname.Text.Trim();
            clsbook.ISBN = txt_Isbn.Text.Trim();
            clsbook.Price = float.Parse(txt_Price.Text);
            clsbook.Discount = float.Parse(txtbox_discount.Text);
            clsbook.Genre_Id_fk = Convert.ToInt32(cmb_genre.SelectedValue); // Selected genre ID

            // Add selected authors
            clsbook.Author_Ids.Add(Convert.ToInt32(cmb_author_1.SelectedValue));
            if (cmb_author_2.SelectedIndex != -1 && cmb_author_1.SelectedValue.ToString() != cmb_author_2.SelectedValue.ToString())
            {
                clsbook.Author_Ids.Add(Convert.ToInt32(cmb_author_2.SelectedValue));
            }

            // Insert data
            clsbook.Insertdata();
            FirstRun(); // Refresh the form

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
            // Ensure a row is selected in the DataGridView
            if (dgv_books.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to update.", "No Selection");
                return;
            }

            // Get selected book ID
            int bookId = Convert.ToInt32(dgv_books.SelectedRows[0].Cells["Book_Id"].Value);

            cls_book clsbook = new cls_book();

            // Assign properties
            clsbook.Book_Id = bookId; // Assign Book_Id
            clsbook.Book_Name = txt_Bookname.Text.Trim();
            clsbook.ISBN = txt_Isbn.Text.Trim();
            clsbook.Price = float.Parse(txt_Price.Text);
            clsbook.Discount = float.Parse(txtbox_discount.Text);
            clsbook.Genre_Id_fk = Convert.ToInt32(cmb_genre.SelectedValue); // Selected genre ID

            // Add selected authors
            clsbook.Author_Ids.Add(Convert.ToInt32(cmb_author_1.SelectedValue));
            if (cmb_author_2.SelectedIndex != -1 && cmb_author_1.SelectedValue.ToString() != cmb_author_2.SelectedValue.ToString())
            {
                clsbook.Author_Ids.Add(Convert.ToInt32(cmb_author_2.SelectedValue));
            }

            // Update data
            clsbook.UpdateData();
            FirstRun(); // Refresh the form
        }

        private void btn_deleteBook_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected in the DataGridView
            if (dgv_books.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to delete.", "No Selection");
                return;
            }

            // Get selected book ID
            int bookId = Convert.ToInt32(dgv_books.SelectedRows[0].Cells["Book_Id"].Value);

            cls_book clsbook = new cls_book();

            // Assign Book_Id
            clsbook.Book_Id = bookId; // Assign Book_Id

            // Delete data
            clsbook.DeleteDate();
            FirstRun(); // Refresh the form
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
                    cls_book clsbook = new cls_book();
                    clsbook.Book_Id = bookId; // Assign Book_Id
                    clsbook.Getdata();

                    // Populate form fields
                    txt_Bookname.Text = clsbook.Book_Name;
                    txt_Isbn.Text = clsbook.ISBN;
                    txt_Price.Text = clsbook.Price.ToString();
                    txtbox_discount.Text = clsbook.Discount.ToString();
                    cmb_genre.SelectedValue = clsbook.Genre_Id_fk;

                    // Populate authors
                    cmb_author_1.SelectedValue = clsbook.Author_Ids.Count > 0 ? clsbook.Author_Ids[0] : -1;
                    cmb_author_2.SelectedValue = clsbook.Author_Ids.Count > 1 ? clsbook.Author_Ids[1] : -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error");
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
            if (dgv_books.SelectedRows.Count > 0)
            {
                // Highlight the selected row
                dgv_books.SelectedRows[0].DefaultCellStyle.BackColor = Color.LightBlue;
            }
            
        }
    }
}
