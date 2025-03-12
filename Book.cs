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
        }

       
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_Bookname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Genre_Click(object sender, EventArgs e)
        {
            view_genre genre = new view_genre();
            genre.ShowDialog();
        }

        private void btn_addBook_Click(object sender, EventArgs e)
        {
           

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

        }

        private void btn_deleteBook_Click(object sender, EventArgs e)
        {

        }

        private void dgv_book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
