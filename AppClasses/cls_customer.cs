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
        SqlTransaction transaction = conn.BeginTransaction();

        public int Customer_Id { get; set; }

            public string Customer_Name { get; set; }

            public string NIC { get; set; }

            public string DOB { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string Mobile_Number { get; set; }







        public void Insertdata()
            {
            try
            {
                // Step 1: Insert into Customer table
                string customerQuery = "INSERT INTO Customer(Customer_Name, NIC, DOB, Address, Email) " +
                                       "VALUES(@Customer_Name, @NIC, @DOB, @Address, @Email); " +
                                       "SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(customerQuery, conn, transaction);
                cmd.Parameters.AddWithValue("@Customer_Name", Customer_Name);
                cmd.Parameters.AddWithValue("@NIC", NIC);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Email", Email);

                // Retrieve the newly inserted Customer_Id
                int customerId = Convert.ToInt32(cmd.ExecuteScalar());

                // Step 2: Insert into CustomerMobile table
                string mobileQuery = "INSERT INTO CustomerMobile(Mobile_Number, Customer_Id_fk) VALUES(@Mobile_Number, @Customer_Id)";

                SqlCommand mobileCmd = new SqlCommand(mobileQuery, conn, transaction);
                mobileCmd.Parameters.AddWithValue("@Mobile_Number", Mobile_Number);
                mobileCmd.Parameters.AddWithValue("@Customer_Id", customerId);
                mobileCmd.ExecuteNonQuery();

                // Commit the transaction
                transaction.Commit();
                MessageBox.Show("Customer details inserted successfully!", "Success");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Error: " + ex.Message, "Insert Failed");
            }
        }
        


        public void UpdateData()
            {
                string query = "UPDATE Customer SET Customer_Name = '" + Customer_Name + "', NIC = '" + NIC + "', DOB = '" + DOB + "', Address = '" + Address + "', " +
                    "  Email = '" + Email + " WHERE Customer_Id = '" + Customer_Id + "'";

                cmn.messages(query, "update");
            }

            public void DeleteDate()
            {
                string query = "Delete from Customer WHERE Customer_Id = '" + Customer_Id + "'";

                cmn.messages(query, "delete");
            }


        public void Getdata()
        {
            string qry = "SELECT * FROM Customer  WHERE Customer_Id = '" + Customer_Id + "'";
            fileoperation fill = new fileoperation();
            SqlDataReader rd = fill.FillWithID(qry);

            if (rd.Read())
            {
                Customer_Id = Convert.ToInt32(rd["emp_id"].ToString());
                Customer_Name = rd["Customer_Name"].ToString();
                NIC = Convert.ToString(rd["NIC"]);
                DOB = rd["DOB"].ToString();
                Address = rd["Address"].ToString();
                Email = rd["Email"].ToString();
                Mobile_Number = Convert.ToInt32(rd["allowance"]);
                joindate = Convert.ToDateTime(rd["joindate"]);
                jobrole = Convert.ToString(rd["job_role"]);
                gender = rd["gender"].ToString();
            }
        }

    }

}
