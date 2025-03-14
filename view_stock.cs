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
    public partial class view_stock : Form
    {
        cls_Stock clsstock = new cls_Stock();
        filloperation fill = new filloperation();
        public view_stock()
        {
            InitializeComponent();
            FirstRun();
        }
        void FirstRun()
        {
            // Clear form fields
            txt_quantity.Text = "0";
            txt_price.Text = "0.0";

            // Populate cmb_book (Books)
            string bookQuery = "SELECT Book_Id, Book_Name FROM Book";
            fill.combobox(bookQuery, cmb_book, "Book_Name", "Book_Id");

            // Populate DataGridView (Stock details)
            string stockQuery = @"
        SELECT 
            s.Stock_Id,
            b.Book_Name AS Book,
            s.Stock_Quantity,
            s.Stock_QuantityPrice
        FROM Stock s
        INNER JOIN Book b ON s.Book_Id_fk = b.Book_Id";

            fill.FillDataGridView(stockQuery, dgv_stock);
            dgv_stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Rename columns for clarity
            dgv_stock.Columns[0].HeaderText = "ID";
            dgv_stock.Columns[1].HeaderText = "Book Name";
            dgv_stock.Columns[2].HeaderText = "Quantity";
            dgv_stock.Columns[3].HeaderText = "Price";
        }

        private void btn_add_stock_Click(object sender, EventArgs e)
        {
            cls_Stock clsstock = new cls_Stock();

            // Assign properties
            clsstock.Stock_Quantity = int.Parse(txt_quantity.Text);
            clsstock.Book_Id_fk = Convert.ToInt32(cmb_book.SelectedValue); // Selected book ID
            clsstock.Stock_QuantityPrice = float.Parse(txt_price.Text);

            // Insert data
            clsstock.Insertdata();
            FirstRun(); // Refresh the form
        }

        private void btn_update_stock_Click(object sender, EventArgs e)
        {
            cls_Stock clsstock = new cls_Stock();

            // Assign properties
            //clsstock.Stock_Id = Convert.ToInt32(txt_stock_id.Text); // Hidden field for Stock_Id
            clsstock.Stock_Quantity = int.Parse(txt_quantity.Text);
            clsstock.Book_Id_fk = Convert.ToInt32(cmb_book.SelectedValue); // Selected book ID
            clsstock.Stock_QuantityPrice = float.Parse(txt_price.Text);

            // Update data
            clsstock.UpdateData();
            FirstRun(); // Refresh the form
        }

        private void dgv_stock_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Get selected stock ID
                    int stockId = Convert.ToInt32(dgv_stock.Rows[e.RowIndex].Cells["Stock_Id"].Value);

                    // Load stock data
                    cls_Stock clsstock = new cls_Stock();
                    clsstock.Stock_Id = stockId;
                    clsstock.GetStockById();

                    // Populate form fields
                    //txt_stock_id.Text = clsstock.Stock_Id.ToString();
                    txt_quantity.Text = clsstock.Stock_Quantity.ToString();
                    txt_price.Text = clsstock.Stock_QuantityPrice.ToString();
                    cmb_book.SelectedValue = clsstock.Book_Id_fk; // Set selected book
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error");
                }
            }
        }

        private void view_stock_Load(object sender, EventArgs e)
        {
            FirstRun();
        }
    }
}
