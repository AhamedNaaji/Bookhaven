using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Bookhaven.CommonClasses;

namespace Bookhaven.AppClasses
{
    internal class cls_author
    {
        Common cmn = new Common();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3UAK82;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");
        SqlTransaction transaction;

        public int Author_Id { get; set; }
        public string AuthorName { get; set; }

        public void Insertdata()
        {
            if (string.IsNullOrEmpty(AuthorName))
            {
                MessageBox.Show("Author name cannot be empty");
                return;
            }

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                string query = @"
                    INSERT INTO Author (AuthorName) 
                    VALUES (@AuthorName);
                    SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn, transaction);
                cmd.Parameters.AddWithValue("@AuthorName", AuthorName);

                // Get inserted Author_Id
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    Author_Id = Convert.ToInt32(result);
                }

                transaction.Commit();
                MessageBox.Show("Author added successfully!", "Success");
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
            if (Author_Id <= 0)
            {
                MessageBox.Show("Invalid author ID");
                return;
            }

            if (string.IsNullOrEmpty(AuthorName))
            {
                MessageBox.Show("Author name cannot be empty");
                return;
            }

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                string query = @"
                    UPDATE Author 
                    SET AuthorName = @AuthorName
                    WHERE Author_Id = @Author_Id";

                SqlCommand cmd = new SqlCommand(query, conn, transaction);
                cmd.Parameters.AddWithValue("@AuthorName", AuthorName);
                cmd.Parameters.AddWithValue("@Author_Id", Author_Id);

                int rowsAffected = cmd.ExecuteNonQuery();
                transaction.Commit();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Author updated successfully!", "Success");
                }
                else
                {
                    MessageBox.Show("Author not found", "Warning");
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
            if (Author_Id <= 0)
            {
                MessageBox.Show("Invalid author ID");
                return;
            }

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                string query = "DELETE FROM Author WHERE Author_Id = @Author_Id";
                SqlCommand cmd = new SqlCommand(query, conn, transaction);
                cmd.Parameters.AddWithValue("@Author_Id", Author_Id);

                int rowsAffected = cmd.ExecuteNonQuery();
                transaction.Commit();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Author deleted successfully!", "Success");
                }
                else
                {
                    MessageBox.Show("Author not found", "Warning");
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

        public void GetAuthorById()
        {
            if (Author_Id <= 0)
            {
                MessageBox.Show("Invalid author ID");
                return;
            }

            try
            {
                conn.Open();
                string query = "SELECT * FROM Author WHERE Author_Id = @Author_Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Author_Id", Author_Id);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Author_Id = Convert.ToInt32(dr["Author_Id"]);
                    AuthorName = dr["AuthorName"].ToString();
                }
                else
                {
                    MessageBox.Show("Author not found", "Warning");
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