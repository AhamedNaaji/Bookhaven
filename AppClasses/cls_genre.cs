using Bookhaven.CommonClasses;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookhaven.AppClasses
{
    internal class cls_Genre
    {
        Common cmn = new Common();
        SqlConnection conn = new SqlConnection("Data Source=MMSALMANFARIS;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");
        SqlTransaction transaction;


        public int Genre_Id { get; set; }
        public string genreName { get; set; }

        public void Insertdata()
        {
            if (string.IsNullOrEmpty(genreName))
            {
                MessageBox.Show("Genre name cannot be empty");
                return;
            }

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                string query = @"
                    INSERT INTO Genre (genreName) 
                    VALUES (@genreName);
                    SELECT SCOPE_IDENTITY()";

                SqlCommand cmd = new SqlCommand(query, conn, transaction);
                cmd.Parameters.AddWithValue("@genreName", genreName);

                // Get inserted Genre_Id
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    Genre_Id = Convert.ToInt32(result);
                }

                transaction.Commit();
                MessageBox.Show("Genre added successfully!", "Success");
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
            if (Genre_Id <= 0)
            {
                MessageBox.Show("Invalid genre ID");
                return;
            }

            if (string.IsNullOrEmpty(genreName))
            {
                MessageBox.Show("Genre name cannot be empty");
                return;
            }

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                string query = @"
                    UPDATE Genre 
                    SET genreName = @genreName
                    WHERE Genre_Id = @Genre_Id";

                SqlCommand cmd = new SqlCommand(query, conn, transaction);
                cmd.Parameters.AddWithValue("@genreName", genreName);
                cmd.Parameters.AddWithValue("@Genre_Id", Genre_Id);

                int rowsAffected = cmd.ExecuteNonQuery();
                transaction.Commit();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Genre updated successfully!", "Success");
                }
                else
                {
                    MessageBox.Show("Genre not found", "Warning");
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
            if (Genre_Id <= 0)
            {
                MessageBox.Show("Invalid genre ID");
                return;
            }

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                string query = "DELETE FROM Genre WHERE Genre_Id = @Genre_Id";
                SqlCommand cmd = new SqlCommand(query, conn, transaction);
                cmd.Parameters.AddWithValue("@Genre_Id", Genre_Id);

                int rowsAffected = cmd.ExecuteNonQuery();
                transaction.Commit();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Genre deleted successfully!", "Success");
                }
                else
                {
                    MessageBox.Show("Genre not found", "Warning");
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

        public void GetGenreById()
        {
            if (Genre_Id <= 0)
            {
                MessageBox.Show("Invalid genre ID");
                return;
            }

            try
            {
                conn.Open();
                string query = "SELECT * FROM Genre WHERE Genre_Id = @Genre_Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Genre_Id", Genre_Id);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    // Ensure Genre_Id is assigned (though it's already set)
                    Genre_Id = Convert.ToInt32(dr["Genre_Id"]);
                    genreName = dr["genreName"].ToString();
                }
                else
                {
                    MessageBox.Show("Genre not found", "Warning");
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