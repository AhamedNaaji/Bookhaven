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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_username.Text.Trim() != "" && txt_password.Text.Trim() != "")
                {
                    mycon.Open();
                    string qry = "SELECT * FROM tbl_admin WHERE username = '" + txt_username.Text.Trim() + "' " +
                    "AND password = '" + txt_password.Text.Trim() + "' ";

                    SqlCommand cmd = new SqlCommand(qry, mycon);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        Dashboard dashboard_frm = new Dashboard();
                        dashboard_frm.ShowDialog();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Incorrect Username or Password");
                }
                else
                    MessageBox.Show("Incorrect Username or Password");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { mycon.Close(); }
        }
    }
}
