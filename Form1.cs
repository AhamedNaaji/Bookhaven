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
        public SqlConnection mycon = new SqlConnection("Data Source=MMSALMANFARIS;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");

        public string user;

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

                    // Corrected SQL query
                    string qry = @"
                SELECT s.Staff_Id, s.Username, sr.roleName 
                FROM Staff s
                INNER JOIN staffRole sr ON s.staffRoll_Id_fk = sr.rollId
                WHERE s.Username = @username AND s.Password = @password";

                    SqlCommand cmd = new SqlCommand(qry, mycon);
                    cmd.Parameters.AddWithValue("@username", txt_Username.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txt_Password.Text.Trim());

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        int staffId = Convert.ToInt32(rdr["Staff_Id"]);
                        string roleName = rdr["roleName"].ToString();

                        // Open the appropriate dashboard based on role
                        if (roleName == "Admin")
                        {
                            Sales salse = new Sales(staffId); // Pass staffId to the dashboard
                            salse.ShowDialog();
                            this.Hide();
                        }
                        else
                        {
                            Clerk_Sales sales_clerk = new Clerk_Sales(staffId); // Pass staffId to the dashboard
                            sales_clerk.ShowDialog();
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
        
        void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
