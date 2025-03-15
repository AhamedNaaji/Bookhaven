using Bookhaven.CommonClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookhaven.AppClasses
{
    internal class cls_customer
    {
        Common cmn = new Common();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3UAK82;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");
        SqlTransaction transaction;

        // Properties
        public int Customer_Id { get; set; }
        public string Customer_Name { get; set; }
        public string NIC { get; set; }
        public DateTime DOB { get; set; } // Changed from string to DateTime
        public string Address { get; set; }
        public string Email { get; set; }
        public List<string> Mobile_Numbers { get; set; } = new List<string>();

        // Insert Data
        public void Insertdata()
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // Insert into Customer table
                string customerQuery = @"
                    INSERT INTO Customer (Customer_Name, NIC, DOB, Address, Email)
                    VALUES (@Customer_Name, @NIC, @DOB, @Address, @Email);
                    SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(customerQuery, conn, transaction);
                cmd.Parameters.AddWithValue("@Customer_Name", Customer_Name);
                cmd.Parameters.AddWithValue("@NIC", NIC);
                cmd.Parameters.AddWithValue("@DOB", DOB); // Use DateTime parameter
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Email", Email);

                Customer_Id = Convert.ToInt32(cmd.ExecuteScalar());

                // Insert mobile numbers
                foreach (string number in Mobile_Numbers)
                {
                    string mobileQuery = @"
                        INSERT INTO CustomerMobile (Customer_Id_fk, Mobile_Number)
                        VALUES (@Customer_Id_fk, @Mobile_Number);";

                    SqlCommand mobileCmd = new SqlCommand(mobileQuery, conn, transaction);
                    mobileCmd.Parameters.AddWithValue("@Customer_Id_fk", Customer_Id);
                    mobileCmd.Parameters.AddWithValue("@Mobile_Number", number);
                    mobileCmd.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show($"Error: {ex.Message}", "Insert Failed");
            }
            finally
            {
                conn.Close();
            }
        }

        // Update Data
        public void UpdateData()
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // Update Customer table
                string updateQuery = @"
                    UPDATE Customer
                    SET Customer_Name = @Customer_Name,
                        NIC = @NIC,
                        DOB = @DOB,
                        Address = @Address,
                        Email = @Email
                    WHERE Customer_Id = @Customer_Id;";

                SqlCommand cmd = new SqlCommand(updateQuery, conn, transaction);
                cmd.Parameters.AddWithValue("@Customer_Name", Customer_Name);
                cmd.Parameters.AddWithValue("@NIC", NIC);
                cmd.Parameters.AddWithValue("@DOB", DOB); // Use DateTime parameter
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Customer_Id", Customer_Id);

                cmd.ExecuteNonQuery();

                // Delete existing mobile numbers
                string deleteMobileQuery = @"
                    DELETE FROM CustomerMobile
                    WHERE Customer_Id_fk = @Customer_Id;";

                SqlCommand deleteCmd = new SqlCommand(deleteMobileQuery, conn, transaction);
                deleteCmd.Parameters.AddWithValue("@Customer_Id", Customer_Id);
                deleteCmd.ExecuteNonQuery();

                // Insert new mobile numbers
                foreach (string number in Mobile_Numbers)
                {
                    string insertMobileQuery = @"
                        INSERT INTO CustomerMobile (Customer_Id_fk, Mobile_Number)
                        VALUES (@Customer_Id_fk, @Mobile_Number);";

                    SqlCommand insertCmd = new SqlCommand(insertMobileQuery, conn, transaction);
                    insertCmd.Parameters.AddWithValue("@Customer_Id_fk", Customer_Id);
                    insertCmd.Parameters.AddWithValue("@Mobile_Number", number);
                    insertCmd.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show($"Error: {ex.Message}", "Update Failed");
            }
            finally
            {
                conn.Close();
            }
        }

        // Delete Data
        public void DeleteDate()
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // Delete mobile numbers
                string deleteMobileQuery = @"
                    DELETE FROM CustomerMobile
                    WHERE Customer_Id_fk = @Customer_Id;";

                SqlCommand deleteMobileCmd = new SqlCommand(deleteMobileQuery, conn, transaction);
                deleteMobileCmd.Parameters.AddWithValue("@Customer_Id", Customer_Id);
                deleteMobileCmd.ExecuteNonQuery();

                // Delete customer
                string deleteQuery = @"
                    DELETE FROM Customer
                    WHERE Customer_Id = @Customer_Id;";

                SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn, transaction);
                deleteCmd.Parameters.AddWithValue("@Customer_Id", Customer_Id);
                deleteCmd.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show($"Error: {ex.Message}", "Delete Failed");
            }
            finally
            {
                conn.Close();
            }
        }

        // Fetch Data
        public void Getdata()
        {
            try
            {
                conn.Open();

                // Fetch customer details
                string query = @"
                    SELECT Customer_Name, NIC, DOB, Address, Email
                    FROM Customer
                    WHERE Customer_Id = @Customer_Id;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Customer_Id", Customer_Id);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Customer_Name = reader["Customer_Name"].ToString();
                    NIC = reader["NIC"].ToString();
                    DOB = Convert.ToDateTime(reader["DOB"]); // Use DateTime conversion
                    Address = reader["Address"].ToString();
                    Email = reader["Email"].ToString();
                }
                reader.Close();

                // Fetch mobile numbers
                string mobileQuery = @"
                    SELECT Mobile_Number
                    FROM CustomerMobile
                    WHERE Customer_Id_fk = @Customer_Id;";

                SqlCommand mobileCmd = new SqlCommand(mobileQuery, conn);
                mobileCmd.Parameters.AddWithValue("@Customer_Id", Customer_Id);

                SqlDataReader mobileReader = mobileCmd.ExecuteReader();
                Mobile_Numbers.Clear();
                while (mobileReader.Read())
                {
                    Mobile_Numbers.Add(mobileReader["Mobile_Number"].ToString());
                }
                mobileReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Fetch Failed");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}