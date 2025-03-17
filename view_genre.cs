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
    public partial class view_genre : Form
    {
        genre_cls clsgenre = new genre_cls();
        filloperation fill = new filloperation();
        public view_genre()
        {
            InitializeComponent();
            FirstRun();
        }

        void FirstRun()
        {
            // Clear form fields
            txtbox_genre.Text = "";

            // Define SQL query
            string query = @"
                SELECT 
                    Genre_Id, 
                    genreName 
                FROM Genre";

            // Populate DataGridView
            fill.FillDataGridView(query, dgv_genre);
            dgv_genre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Explicitly set column names
            dgv_genre.Columns[0].HeaderText = "ID"; // Display name
            dgv_genre.Columns[1].HeaderText = "Genre Name";
        }
        private void txtbox_genre_TextChanged(object sender, EventArgs e)
        {
            clsgenre.genreName = txtbox_genre.Text.Trim();

        }

        private void dgv_genre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_add_genre_Click(object sender, EventArgs e)
        {
            clsgenre.Insertdata();
            FirstRun();

        }

        private void btn_update_genre_Click(object sender, EventArgs e)
        {
     
            clsgenre.UpdateData();
            FirstRun();
        }

        private void btn_delete_genre_Click(object sender, EventArgs e)
        {
            clsgenre.DeleteData();
            FirstRun();

        }

        private void dgv_genre_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // Prevent invalid row/column

            try
            {
                // Get genre ID using the correct column name
                int genreId = Convert.ToInt32(dgv_genre.Rows[e.RowIndex].Cells["Genre_Id"].Value);

                // Use the same instance of cls_genre declared at the class level
                clsgenre.Genre_Id = genreId;
                clsgenre.GetGenreById();

                // Populate form field
                txtbox_genre.Text = clsgenre.genreName;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }

        }

        private void view_genre_Load(object sender, EventArgs e)
        {
            FirstRun();
        }
    }
}
