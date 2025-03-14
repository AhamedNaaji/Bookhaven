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

        public int Customer_Id { get; set; }
        public string Customer_Name { get; set; }
        public string NIC { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
       
       
       public List<string> Mobile_Numbers { get; set; } = new List<string>();

        // Keep the rest of the properties (Customer_Id, Customer_Name, etc.)





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
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Email", Email);

                int customerId = Convert.ToInt32(cmd.ExecuteScalar());

                // Insert all mobile numbers
                foreach (string number in Mobile_Numbers)
                {
                    string mobileQuery = @"
                INSERT INTO CustomerMobile (Mobile_Number, Customer_Id_fk) 
                VALUES (@Mobile_Number, @Customer_Id)";

                    SqlCommand mobileCmd = new SqlCommand(mobileQuery, conn, transaction);
                    mobileCmd.Parameters.AddWithValue("@Mobile_Number", number);
                    mobileCmd.Parameters.AddWithValue("@Customer_Id", customerId);
                    mobileCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Customer details inserted successfully!", "Success");
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show("Error: " + ex.Message, "Insert Failed");
            }
            finally
            {
                conn.Close();
            }
        }
        public void UpdateData()
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // Step 1: Update Customer table
                string updateCustomerQuery = @"
            UPDATE Customer 
            SET Customer_Name = @Customer_Name, 
                NIC = @NIC, 
                DOB = @DOB, 
                Address = @Address, 
                Email = @Email 
            WHERE Customer_Id = @Customer_Id";

                SqlCommand cmd = new SqlCommand(updateCustomerQuery, conn, transaction);
                cmd.Parameters.AddWithValue("@Customer_Name", Customer_Name);
                cmd.Parameters.AddWithValue("@NIC", NIC);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Customer_Id", Customer_Id);
                cmd.ExecuteNonQuery();

                // Step 2: Delete existing mobile numbers
                string deleteMobileQuery = @"
            DELETE FROM CustomerMobile 
            WHERE Customer_Id_fk = @Customer_Id";

                SqlCommand deleteCmd = new SqlCommand(deleteMobileQuery, conn, transaction);
                deleteCmd.Parameters.AddWithValue("@Customer_Id", Customer_Id);
                deleteCmd.ExecuteNonQuery();

                // Step 3: Insert new mobile numbers
                foreach (string number in Mobile_Numbers)
                {
                    string insertMobileQuery = @"
                INSERT INTO CustomerMobile (Mobile_Number, Customer_Id_fk) 
                VALUES (@Mobile_Number, @Customer_Id)";

                    SqlCommand insertCmd = new SqlCommand(insertMobileQuery, conn, transaction);
                    insertCmd.Parameters.AddWithValue("@Mobile_Number", number);
                    insertCmd.Parameters.AddWithValue("@Customer_Id", Customer_Id);
                    insertCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Customer details updated successfully!", "Success");
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show("Error: " + ex.Message, "Update Failed");
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteDate()
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // Step 1: Delete related mobile numbers (due to foreign key)
                string deleteMobileQuery = "DELETE FROM CustomerMobile WHERE Customer_Id_fk = @Customer_Id";
                SqlCommand mobileCmd = new SqlCommand(deleteMobileQuery, conn, transaction);
                mobileCmd.Parameters.AddWithValue("@Customer_Id", Customer_Id);
                mobileCmd.ExecuteNonQuery();

                // Step 2: Delete the customer
                string deleteCustomerQuery = "DELETE FROM Customer WHERE Customer_Id = @Customer_Id";
                SqlCommand customerCmd = new SqlCommand(deleteCustomerQuery, conn, transaction);
                customerCmd.Parameters.AddWithValue("@Customer_Id", Customer_Id);
                customerCmd.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Customer deleted successfully!", "Success");
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show("Error: " + ex.Message, "Delete Failed");
            }
            finally
            {
                conn.Close();
            }
        }



        public void Getdata()
        {
            try
            {
                conn.Open();
                string qry = @"
            SELECT c.Customer_Id, c.Customer_Name, c.NIC, c.DOB, c.Address, c.Email, cm.Mobile_Number 
            FROM Customer c 
            LEFT JOIN CustomerMobile cm ON c.Customer_Id = cm.Customer_Id_fk 
            WHERE c.Customer_Id = @Customer_Id";

                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@Customer_Id", Customer_Id);
                SqlDataReader rd = cmd.ExecuteReader();

                // Clear existing numbers
                Mobile_Numbers.Clear();

                while (rd.Read())
                {
                    Customer_Id = Convert.ToInt32(rd["Customer_Id"]);
                    Customer_Name = rd["Customer_Name"].ToString();
                    NIC = rd["NIC"].ToString();
                    DOB = rd["DOB"].ToString();
                    Address = rd["Address"].ToString();
                    Email = rd["Email"].ToString();

                    // Add mobile number to the list (if not null)
                    if (rd["Mobile_Number"] != DBNull.Value)
                        Mobile_Numbers.Add(rd["Mobile_Number"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fetch Failed");
            }
            finally
            {
                conn.Close();
            }
        }
    }
    

}
