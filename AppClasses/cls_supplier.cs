using Bookhaven.CommonClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookhaven.AppClasses
{
    internal class cls_Supplier
    {
        Common cmn = new Common();
        SqlConnection conn = new SqlConnection("Data Source=MMSALMANFARIS;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");
        SqlTransaction transaction;

        public int Supplier_Id { get; set; }
        public string Supplier_Name { get; set; }
        public string NIC { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }


        public List<string> supMobNumbers { get; set; } = new List<string>();

        // Keep the rest of the properties (Customer_Id, Customer_Name, etc.)





        public void Insertdata()
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // Insert into Customer table
                string supplierQuery = @"
            INSERT INTO Supplier (Supplier_Name, NIC,  Address, Email) 
            VALUES (@Supplier_Name, @NIC,  @Address, @Email);
            SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(supplierQuery, conn, transaction);
                cmd.Parameters.AddWithValue("@Supplier_Name", Supplier_Name);
                cmd.Parameters.AddWithValue("@NIC", NIC);

                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Email", Email);

                int Supplier_Id = Convert.ToInt32(cmd.ExecuteScalar());

                // Insert all mobile numbers
                foreach (string number in supMobNumbers)
                {
                    string mobileQuery = @"
                INSERT INTO SupplierMobile (SupMobNumber, Supplier_Id_fk) 
                VALUES (@SupMobNumber, @Supplier_Id)";

                    SqlCommand mobileCmd = new SqlCommand(mobileQuery, conn, transaction);
                    mobileCmd.Parameters.AddWithValue("@SupMobNumber", number);
                    mobileCmd.Parameters.AddWithValue("@Supplier_Id", Supplier_Id);
                    mobileCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Supplier details inserted successfully!", "Success");
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
                string updateSupplierQuery = @"
            UPDATE Supplier 
            SET Supplier_Name = @Supplier_Name, 
                NIC = @NIC, 
             
                Address = @Address, 
                Email = @Email 
            WHERE Supplier_Id = @Supplier_Id";

                SqlCommand cmd = new SqlCommand(updateSupplierQuery, conn, transaction);
                cmd.Parameters.AddWithValue("@Supplier_Name", Supplier_Name);
                cmd.Parameters.AddWithValue("@NIC", NIC);

                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Supplier_Id", Supplier_Id);
                cmd.ExecuteNonQuery();

                // Step 2: Delete existing mobile numbers
                string deleteMobileQuery = @"
            DELETE FROM SupplierMobile 
            WHERE Supplier_Id_fk = @Supplier_Id";

                SqlCommand deleteCmd = new SqlCommand(deleteMobileQuery, conn, transaction);
                deleteCmd.Parameters.AddWithValue("@Supplier_Id", Supplier_Id);
                deleteCmd.ExecuteNonQuery();

                // Step 3: Insert new mobile numbers
                foreach (string number in supMobNumbers)
                {
                    string insertMobileQuery = @"
                INSERT INTO SupplierMobile (SupMobNumber, Supplier_Id_fk) 
                VALUES (@SupMobNumber, @Supplier_Id)";

                    SqlCommand insertCmd = new SqlCommand(insertMobileQuery, conn, transaction);
                    insertCmd.Parameters.AddWithValue("@SupMobNumber", number);
                    insertCmd.Parameters.AddWithValue("@Supplier_Id", Supplier_Id);
                    insertCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Supplier details updated successfully!", "Success");
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
                string deleteMobileQuery = "DELETE FROM SupplierMobile WHERE Supplier_Id_fk = @Supplier_Id";
                SqlCommand mobileCmd = new SqlCommand(deleteMobileQuery, conn, transaction);
                mobileCmd.Parameters.AddWithValue("@Supplier_Id", Supplier_Id);
                mobileCmd.ExecuteNonQuery();

                // Step 2: Delete the customer
                string deleteCustomerQuery = "DELETE FROM Supplier WHERE Supplier_Id = @Supplier_Id";
                SqlCommand customerCmd = new SqlCommand(deleteCustomerQuery, conn, transaction);
                customerCmd.Parameters.AddWithValue("@Supplier_Id", Supplier_Id);
                customerCmd.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Supplier deleted successfully!", "Success");
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
            SELECT c.Supplier_Id, c.Supplier_Name, c.NIC, c.Address, c.Email, cm.SupMobNumber 
            FROM Supplier c 
            LEFT JOIN SupplierMobile cm ON c.Supplier_Id = cm.Supplier_Id_fk 
            WHERE c.Supplier_Id = @Supplier_Id";

                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@Supplier_Id", Supplier_Id);
                SqlDataReader rd = cmd.ExecuteReader();

                // Clear existing numbers
                supMobNumbers.Clear();

                while (rd.Read())
                {
                    Supplier_Id = Convert.ToInt32(rd["Supplier_Id"]);
                    Supplier_Name = rd["Supplier_Name"].ToString();
                    NIC = rd["NIC"].ToString();

                    Address = rd["Address"].ToString();
                    Email = rd["Email"].ToString();

                    // Add mobile number to the list (if not null)
                    while (rd.Read())
                    {
                        // ...
                        if (rd["SupMobNumber"] != DBNull.Value) // Use SupMobNumber instead of SupMobNumber
                            supMobNumbers.Add(rd["SupMobNumber"].ToString());
                    }
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
