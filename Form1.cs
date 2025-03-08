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

     

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\Bookhaven\Bookhaven\Bookhaven.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username='" + txt_Username.Text + "' and Password='" + txt_Password.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Dashboard ss = new Dashboard();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Please Check your Username and Password");
            }

        }
    }
}
