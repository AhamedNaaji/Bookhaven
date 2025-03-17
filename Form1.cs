using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookhaven
{
    public partial class Form1 : Form
    {
        public SqlConnection mycon = new SqlConnection("Data Source=AFRIDI;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");
        public static int CurrentStaffId { get; set; } // Static property to store the current staff ID

        public Form1()
        {
            InitializeComponent();
            // Set the AcceptButton property to btn_Login
            this.AcceptButton = btn_Login;
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
    SELECT s.*, sr.roleName 
    FROM Staff s
    INNER JOIN staffRole sr ON s.staffRoll_Id_fk = sr.rollId
    WHERE s.Username = @username AND s.Password = @password";
                    SqlCommand cmd = new SqlCommand(qry, mycon);
                    cmd.Parameters.AddWithValue("@username", txt_Username.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txt_Password.Text.Trim());
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        // Check the role name (corrected column name)
                        if (rdr["roleName"].ToString() == "Admin")
                        {
                            // Open Admin Dashboard
                            Dashboard dashboard_frm = new Dashboard();
                            dashboard_frm.FormClosed += (s, args) =>
                            {
                                // When the dashboard form is closed, show the login form again
                                this.Show();
                            };
                            dashboard_frm.ShowDialog();
                            this.Hide();
                        }
                        else
                        {
                            // Store the current staff ID
                            CurrentStaffId = Convert.ToInt32(rdr["Staff_Id"]);

                            // Open Clerk Dashboard and pass the staff ID
                            Dashboard_Clerk dashboard = new Dashboard_Clerk(CurrentStaffId);
                            dashboard.FormClosed += (s, args) =>
                            {
                                // When the dashboard form is closed, show the login form again
                                this.Show();
                            };
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
    }
}