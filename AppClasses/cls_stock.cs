using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookhaven.AppClasses
{
    internal class cls_stock
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3UAK82;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");
        SqlTransaction transaction;

        public int Stock_Id { get; set; }
        public int Stock_Quantity { get; set; }
        public int Book_Id_fk { get; set; }
        public float Stock_QuantityPrice { get; set; }

        public void Insertdata()
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                string query = @"
            INSERT INTO Stock (Stock_Quantity, Book_Id_fk, Stock_QuantityPrice) 
            VALUES (@Stock_Quantity, @Book_Id_fk, @Stock_QuantityPrice);
            SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn, transaction);
                cmd.Parameters.AddWithValue("@Stock_Quantity", Stock_Quantity);
                cmd.Parameters.AddWithValue("@Book_Id_fk", Book_Id_fk);
                cmd.Parameters.AddWithValue("@Stock_QuantityPrice", Stock_QuantityPrice);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    Stock_Id = Convert.ToInt32(result);
                }

                transaction.Commit();
                MessageBox.Show("Stock added successfully!", "Success");
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

        public void UpdateData()
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                string query = @"
            UPDATE Stock 
            SET Stock_Quantity = @Stock_Quantity, 
                Book_Id_fk = @Book_Id_fk, 
                Stock_QuantityPrice = @Stock_QuantityPrice 
            WHERE Stock_Id = @Stock_Id";

                SqlCommand cmd = new SqlCommand(query, conn, transaction);
                cmd.Parameters.AddWithValue("@Stock_Quantity", Stock_Quantity);
                cmd.Parameters.AddWithValue("@Book_Id_fk", Book_Id_fk);
                cmd.Parameters.AddWithValue("@Stock_QuantityPrice", Stock_QuantityPrice);
                cmd.Parameters.AddWithValue("@Stock_Id", Stock_Id);

                int rowsAffected = cmd.ExecuteNonQuery();
                transaction.Commit();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Stock updated successfully!", "Success");
                }
                else
                {
                    MessageBox.Show("Stock not found", "Warning");
                }
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

                string query = "DELETE FROM Stock WHERE Stock_Id = @Stock_Id";
                SqlCommand cmd = new SqlCommand(query, conn, transaction);
                cmd.Parameters.AddWithValue("@Stock_Id", Stock_Id);

                int rowsAffected = cmd.ExecuteNonQuery();
                transaction.Commit();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Stock deleted successfully!", "Success");
                }
                else
                {
                    MessageBox.Show("Stock not found", "Warning");
                }
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

        public void GetStockById()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Stock WHERE Stock_Id = @Stock_Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Stock_Id", Stock_Id);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Stock_Id = Convert.ToInt32(dr["Stock_Id"]);
                    Stock_Quantity = Convert.ToInt32(dr["Stock_Quantity"]);
                    Book_Id_fk = Convert.ToInt32(dr["Book_Id_fk"]);
                    Stock_QuantityPrice = Convert.ToSingle(dr["Stock_QuantityPrice"]);
                }
                else
                {
                    MessageBox.Show("Stock not found", "Warning");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}