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
    public partial class view_author : Form
    {
        cls_Author clsauthor = new cls_Author();
      
        public view_author()
        {
            InitializeComponent();
        }

        private void txtbox_author_TextChanged(object sender, EventArgs e)
        {
            clsauthor.AuthorName = txtbox_author.Text.Trim();
        }

        private void btn_add_author_Click(object sender, EventArgs e)
        {
            clsauthor.AuthorName = txtbox_author.Text.Trim();
            clsauthor.Insertdata();
            RefreshDataGridView();
        }

        private void btn_update_author_Click(object sender, EventArgs e)
        {
          
            clsauthor.AuthorName = txtbox_author.Text.Trim();
            clsauthor.UpdateData();
            RefreshDataGridView();

        }

        private void btn_delete_author_Click(object sender, EventArgs e)
        {
            
            clsauthor.DeleteData();
            RefreshDataGridView();
        }

        private void dgv_author_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int authorId = Convert.ToInt32(dgv_author.Rows[e.RowIndex].Cells["Author_Id"].Value);
                clsauthor.Author_Id = authorId;
                clsauthor.GetAuthorById();


                txtbox_author.Text = clsauthor.AuthorName;
            }

        }
        private void RefreshDataGridView()
        {

            txtbox_author.Text = "";
            string query = "SELECT Author_Id, AuthorName FROM Author";
            filloperation fill = new filloperation();
            fill.FillDataGridView(query, dgv_author);
            dgv_author.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
           

        private void view_author_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
