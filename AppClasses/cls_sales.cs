using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookhaven.AppClasses
{
    internal class cls_sales
    {
        private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3UAK82;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");
        private SqlTransaction transaction;

        public int Sales_Id { get; set; }
        public int Staff_Id_fk { get; set; }
        public int Customer_Id_fk { get; set; }
        public DateTime Date { get; set; }
        public float Total_Payment { get; set; }

        public List<SalesDetail> SalesDetailsList { get; set; } = new List<SalesDetail>();

        public class SalesDetail
        {
            public int Book_Id_fk { get; set; }
            public float Price { get; set; }
            public int Quantity { get; set; }
            public float Discount { get; set; }
            public float Total_Amount { get; set; }
        }


        public void Insertdata()
        {
            SqlTransaction transaction = null;
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // Insert into Sales table
                string salesQuery = @"
            INSERT INTO Sales (Staff_Id_fk, Customer_Id_fk, Date, Total_Payment)
            VALUES (@Staff_Id_fk, @Customer_Id_fk, @Date, @Total_Payment);
            SELECT SCOPE_IDENTITY();";

                SqlCommand salesCmd = new SqlCommand(salesQuery, conn, transaction);
                salesCmd.Parameters.AddWithValue("@Staff_Id_fk", Staff_Id_fk);
                salesCmd.Parameters.AddWithValue("@Customer_Id_fk", Customer_Id_fk);
                salesCmd.Parameters.AddWithValue("@Date", Date); // Current system date
                salesCmd.Parameters.AddWithValue("@Total_Payment", Total_Payment);

                Sales_Id = Convert.ToInt32(salesCmd.ExecuteScalar());

                // Insert into SalesDetails table
                foreach (var detail in SalesDetailsList)
                {
                    string detailsQuery = @"
                INSERT INTO SalesDetails (Book_Id_fk, Sales_Id_fk, Price, Quantity, Discount, Total_Amount)
                VALUES (@Book_Id_fk, @Sales_Id_fk, @Price, @Quantity, @Discount, @Total_Amount);";

                    SqlCommand detailsCmd = new SqlCommand(detailsQuery, conn, transaction);
                    detailsCmd.Parameters.AddWithValue("@Book_Id_fk", detail.Book_Id_fk);
                    detailsCmd.Parameters.AddWithValue("@Sales_Id_fk", Sales_Id);
                    detailsCmd.Parameters.AddWithValue("@Price", detail.Price);
                    detailsCmd.Parameters.AddWithValue("@Quantity", detail.Quantity);
                    detailsCmd.Parameters.AddWithValue("@Discount", detail.Discount);
                    detailsCmd.Parameters.AddWithValue("@Total_Amount", detail.Total_Amount);

                    detailsCmd.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                throw new Exception($"Insert failed: {ex.Message}");
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

                // Update Sales table
                string updateQuery = @"
                    UPDATE Sales 
                    SET Staff_Id_fk = @Staff_Id_fk,
                        Customer_Id_fk = @Customer_Id_fk,
                        Date = @Date,
                        Total_Payment = @Total_Payment
                    WHERE Sales_Id = @Sales_Id";

                SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction);
                updateCmd.Parameters.AddWithValue("@Staff_Id_fk", Staff_Id_fk);
                updateCmd.Parameters.AddWithValue("@Customer_Id_fk", Customer_Id_fk);
                updateCmd.Parameters.AddWithValue("@Date", Date);
                updateCmd.Parameters.AddWithValue("@Total_Payment", Total_Payment);
                updateCmd.Parameters.AddWithValue("@Sales_Id", Sales_Id);
                updateCmd.ExecuteNonQuery();

                // Delete existing SalesDetails
                string deleteDetailsQuery = "DELETE FROM SalesDetails WHERE Sales_Id_fk = @Sales_Id";
                SqlCommand deleteCmd = new SqlCommand(deleteDetailsQuery, conn, transaction);
                deleteCmd.Parameters.AddWithValue("@Sales_Id", Sales_Id);
                deleteCmd.ExecuteNonQuery();

                // Insert updated SalesDetails
                foreach (var detail in SalesDetailsList)
                {
                    string insertDetailsQuery = @"
                        INSERT INTO SalesDetails (Book_Id_fk, Sales_Id_fk, Price, Quantity, Discount, Total_Amount)
                        VALUES (@Book_Id_fk, @Sales_Id_fk, @Price, @Quantity, @Discount, @Total_Amount);";

                    SqlCommand insertCmd = new SqlCommand(insertDetailsQuery, conn, transaction);
                    insertCmd.Parameters.AddWithValue("@Book_Id_fk", detail.Book_Id_fk);
                    insertCmd.Parameters.AddWithValue("@Sales_Id_fk", Sales_Id);
                    insertCmd.Parameters.AddWithValue("@Price", detail.Price);
                    insertCmd.Parameters.AddWithValue("@Quantity", detail.Quantity);
                    insertCmd.Parameters.AddWithValue("@Discount", detail.Discount);
                    insertCmd.Parameters.AddWithValue("@Total_Amount", detail.Total_Amount);

                    insertCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Sale updated successfully!", "Success");
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

        public void DeleteData()
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // Delete SalesDetails first
                string deleteDetailsQuery = "DELETE FROM SalesDetails WHERE Sales_Id_fk = @Sales_Id";
                SqlCommand deleteDetailsCmd = new SqlCommand(deleteDetailsQuery, conn, transaction);
                deleteDetailsCmd.Parameters.AddWithValue("@Sales_Id", Sales_Id);
                deleteDetailsCmd.ExecuteNonQuery();

                // Delete Sales record
                string deleteQuery = "DELETE FROM Sales WHERE Sales_Id = @Sales_Id";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn, transaction);
                deleteCmd.Parameters.AddWithValue("@Sales_Id", Sales_Id);
                deleteCmd.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Sale deleted successfully!", "Success");
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

        public void Getdata()
        {
            try
            {
                conn.Open();
                string query = @"
                    SELECT s.Sales_Id, s.Staff_Id_fk, s.Customer_Id_fk, s.Date, s.Total_Payment,
                           sd.Book_Id_fk, sd.Price, sd.Quantity, sd.Discount, sd.Total_Amount
                    FROM Sales s
                    INNER JOIN SalesDetails sd ON s.Sales_Id = sd.Sales_Id_fk
                    WHERE s.Sales_Id = @Sales_Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Sales_Id", Sales_Id);

                SqlDataReader reader = cmd.ExecuteReader();

                SalesDetailsList.Clear();
                while (reader.Read())
                {
                    Sales_Id = Convert.ToInt32(reader["Sales_Id"]);
                    Staff_Id_fk = Convert.ToInt32(reader["Staff_Id_fk"]);
                    Customer_Id_fk = Convert.ToInt32(reader["Customer_Id_fk"]);
                    Date = Convert.ToDateTime(reader["Date"]);
                    Total_Payment = Convert.ToSingle(reader["Total_Payment"]);

                    SalesDetailsList.Add(new SalesDetail
                    {
                        Book_Id_fk = Convert.ToInt32(reader["Book_Id_fk"]),
                        Price = Convert.ToSingle(reader["Price"]),
                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        Discount = Convert.ToSingle(reader["Discount"]),
                        Total_Amount = Convert.ToSingle(reader["Total_Amount"])
                    });
                }
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