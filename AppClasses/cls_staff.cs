using Bookhaven.CommonClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookhaven.AppClasses
{
    internal class cls_staff
    {
        Common cmn = new Common();
        SqlConnection conn = new SqlConnection("Data Source=AFRIDI;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");
        SqlTransaction transaction;

        public int Staff_Id { get; set; }
        public string Staff_Name { get; set; }
        public string NIC { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string MobileNum { get; set; }
        public string Email { get; set; }
        public string roleName { get; set; }
        public int staffRoll_Id_fk { get; set; }





        public void Insertdata()
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // Insert into Staff table
                string staffQuery = @"
            INSERT INTO Staff (Staff_Name, NIC,  Address, Username, Password, MobileNum, Email, staffRoll_Id_fk) 
            VALUES (@Staff_Name, @NIC,  @Address, @Username, @Password, @MobileNum, @Email, @roleName);
            SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(staffQuery, conn, transaction);
                cmd.Parameters.AddWithValue("@Staff_Name", Staff_Name);
                cmd.Parameters.AddWithValue("@NIC", NIC);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@MobileNum", MobileNum);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@roleName", roleName);

                int Staff_Id = Convert.ToInt32(cmd.ExecuteScalar());


                transaction.Commit();
                MessageBox.Show("Staff details inserted successfully!", "Success");
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
        //public void UpdateData()
        //{
        //    try
        //    {
        //        conn.Open();
        //        transaction = conn.BeginTransaction();

        //        // Step 1: Update Customer table
        //        string updateSupplierQuery = @"
        //    UPDATE Supplier 
        //    SET Supplier_Name = @Supplier_Name, 
        //        NIC = @NIC, 

        //        Address = @Address, 
        //        Email = @Email 
        //    WHERE Supplier_Id = @Supplier_Id";

        //        SqlCommand cmd = new SqlCommand(updateSupplierQuery, conn, transaction);
        //        cmd.Parameters.AddWithValue("@Supplier_Name", Supplier_Name);
        //        cmd.Parameters.AddWithValue("@NIC", NIC);

        //        cmd.Parameters.AddWithValue("@Address", Address);
        //        cmd.Parameters.AddWithValue("@Email", Email);
        //        cmd.Parameters.AddWithValue("@Supplier_Id", Supplier_Id);
        //        cmd.ExecuteNonQuery();

        //        // Step 2: Delete existing mobile numbers
        //        string deleteMobileQuery = @"
        //    DELETE FROM SupplierMobile 
        //    WHERE Supplier_Id_fk = @Supplier_Id";

        //        SqlCommand deleteCmd = new SqlCommand(deleteMobileQuery, conn, transaction);
        //        deleteCmd.Parameters.AddWithValue("@Supplier_Id", Supplier_Id);
        //        deleteCmd.ExecuteNonQuery();

        //        // Step 3: Insert new mobile numbers
        //        foreach (string number in SupMobNumbers)
        //        {
        //            string insertMobileQuery = @"
        //        INSERT INTO SupplierMobile (SupMobNumber, Supplier_Id_fk) 
        //        VALUES (@SupMobNumber, @Supplier_Id)";

        //            SqlCommand insertCmd = new SqlCommand(insertMobileQuery, conn, transaction);
        //            insertCmd.Parameters.AddWithValue("@SupMobNumber", number);
        //            insertCmd.Parameters.AddWithValue("@Supplier_Id", Supplier_Id);
        //            insertCmd.ExecuteNonQuery();
        //        }

        //        transaction.Commit();
        //        MessageBox.Show("Supplier details updated successfully!", "Success");
        //    }
        //    catch (Exception ex)
        //    {
        //        transaction?.Rollback();
        //        MessageBox.Show("Error: " + ex.Message, "Update Failed");
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        //public void DeleteDate()
        //{
        //    try
        //    {
        //        conn.Open();
        //        transaction = conn.BeginTransaction();

        //        // Step 1: Delete related mobile numbers (due to foreign key)
        //        string deleteMobileQuery = "DELETE FROM SupplierMobile WHERE Supplier_Id_fk = @Supplier_Id";
        //        SqlCommand mobileCmd = new SqlCommand(deleteMobileQuery, conn, transaction);
        //        mobileCmd.Parameters.AddWithValue("@Supplier_Id", Supplier_Id);
        //        mobileCmd.ExecuteNonQuery();

        //        // Step 2: Delete the customer
        //        string deleteCustomerQuery = "DELETE FROM Supplier WHERE Supplier_Id = @Supplier_Id";
        //        SqlCommand customerCmd = new SqlCommand(deleteCustomerQuery, conn, transaction);
        //        customerCmd.Parameters.AddWithValue("@Supplier_Id", Supplier_Id);
        //        customerCmd.ExecuteNonQuery();

        //        transaction.Commit();
        //        MessageBox.Show("Supplier deleted successfully!", "Success");
        //    }
        //    catch (Exception ex)
        //    {
        //        transaction?.Rollback();
        //        MessageBox.Show("Error: " + ex.Message, "Delete Failed");
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}



        public void Getdata()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string qry = @"
            SELECT 
                s.Staff_Id, 
                s.Staff_Name, 
                s.NIC, 
                s.Address, 
                s.Username, 
                s.Password, 
                s.MobileNum, 
                s.Email,
                s.staffRoll_Id_fk,
                sr.roleName
            FROM Staff s 
            INNER JOIN staffRole sr ON s.staffRoll_Id_fk = sr.rollId
            WHERE s.Staff_Id = @Staff_Id";

                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@Staff_Id", Staff_Id);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    Staff_Id = Convert.ToInt32(rd["Staff_Id"]);
                    Staff_Name = rd["Staff_Name"].ToString();
                    NIC = rd["NIC"].ToString();
                    Address = rd["Address"].ToString();
                    Username = rd["Username"].ToString();
                    Password = rd["Password"].ToString();
                    MobileNum = rd["MobileNum"].ToString();
                    Email = rd["Email"].ToString();
                    staffRoll_Id_fk = Convert.ToInt32(rd["staffRoll_Id_fk"]);
                    roleName = rd["roleName"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Data Retrieval Error: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
