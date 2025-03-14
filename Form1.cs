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
        public SqlConnection mycon = new SqlConnection("Data Source=DESKTOP-V3UAK82;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");


        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_Username.Text.Trim() != "" && txt_Password.Text.Trim() != "")
                {
                    mycon.Open();
                    string qry = "SELECT s.*, sr.Role_Name FROM Staff s " +
                                 "INNER JOIN staffRole sr ON s.staffRoll_Id_fk = sr.staffRoll_Id " +
                                 "WHERE s.Username = @username AND s.Password = @password";

                    SqlCommand cmd = new SqlCommand(qry, mycon);
                    cmd.Parameters.AddWithValue("@username", txt_Username.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txt_Password.Text.Trim());

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        if (rdr["Role_Name"].ToString() == "Admin")
                        {
                            // Assuming frm_dashboard is the correct form name
                            Dashboard dashboard_frm = new Dashboard();
                            dashboard_frm.ShowDialog();
                            this.Hide();
                        }
                        else
                        {
                            Dashboard_Clerk dashboard = new Dashboard_Clerk();
                            dashboard.ShowDialog();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both Username and Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                mycon.Close();
            }
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
