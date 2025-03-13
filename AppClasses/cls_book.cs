using Bookhaven.CommonClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookhaven.AppClasses
{
    internal class cls_book
    {
        Common cmn = new Common();
        internal SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V3UAK82;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");
        SqlTransaction transaction;

        public int Book_Id { get; set; }
        public float Price { get; set; }
        public string ISBN { get; set; }
        public string Book_Name { get; set; }
        public int Genre_Id_fk { get; set; }
        public float Discount { get; set; }
        public List<int> Author_Ids { get; set; } = new List<int>();

        public void Insertdata()
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // Insert into Book table
                string bookQuery = @"
            INSERT INTO Book (Price, ISBN, Book_Name, Genre_Id_fk, Discount) 
            VALUES (@Price, @ISBN, @Book_Name, @Genre_Id_fk, @Discount);
            SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(bookQuery, conn, transaction);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                cmd.Parameters.AddWithValue("@Book_Name", Book_Name);
                cmd.Parameters.AddWithValue("@Genre_Id_fk", Genre_Id_fk);
                cmd.Parameters.AddWithValue("@Discount", Discount);

                int bookId = Convert.ToInt32(cmd.ExecuteScalar());

                // Insert authors
                foreach (int authorId in Author_Ids)
                {
                    string authorQuery = @"
                INSERT INTO BookAuthor (Author_Id_fk, Book_Id_fk) 
                VALUES (@Author_Id, @Book_Id)";

                    SqlCommand authorCmd = new SqlCommand(authorQuery, conn, transaction);
                    authorCmd.Parameters.AddWithValue("@Author_Id", authorId);
                    authorCmd.Parameters.AddWithValue("@Book_Id", bookId);
                    authorCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Book added successfully!", "Success");
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

                // Update Book table
                string updateQuery = @"
            UPDATE Book 
            SET Price = @Price, 
                ISBN = @ISBN, 
                Book_Name = @Book_Name, 
                Genre_Id_fk = @Genre_Id_fk, 
                Discount = @Discount 
            WHERE Book_Id = @Book_Id";

                SqlCommand cmd = new SqlCommand(updateQuery, conn, transaction);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                cmd.Parameters.AddWithValue("@Book_Name", Book_Name);
                cmd.Parameters.AddWithValue("@Genre_Id_fk", Genre_Id_fk);
                cmd.Parameters.AddWithValue("@Discount", Discount);
                cmd.Parameters.AddWithValue("@Book_Id", Book_Id);
                cmd.ExecuteNonQuery();

                // Delete existing authors
                string deleteAuthorsQuery = "DELETE FROM BookAuthor WHERE Book_Id_fk = @Book_Id";
                SqlCommand deleteCmd = new SqlCommand(deleteAuthorsQuery, conn, transaction);
                deleteCmd.Parameters.AddWithValue("@Book_Id", Book_Id);
                deleteCmd.ExecuteNonQuery();

                // Insert new authors
                foreach (int authorId in Author_Ids)
                {
                    string insertAuthorQuery = @"
                INSERT INTO BookAuthor (Author_Id_fk, Book_Id_fk) 
                VALUES (@Author_Id, @Book_Id)";

                    SqlCommand insertCmd = new SqlCommand(insertAuthorQuery, conn, transaction);
                    insertCmd.Parameters.AddWithValue("@Author_Id", authorId);
                    insertCmd.Parameters.AddWithValue("@Book_Id", Book_Id);
                    insertCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Book updated successfully!", "Success");
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

       



        public void DeleteDate()
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // Step 1: Delete related stock entries (due to foreign key)
                string deleteStockQuery = "DELETE FROM Stock WHERE Book_Id_fk = @Book_Id";
                SqlCommand stockCmd = new SqlCommand(deleteStockQuery, conn, transaction);
                stockCmd.Parameters.AddWithValue("@Book_Id", Book_Id);
                stockCmd.ExecuteNonQuery();

                // Step 2: Delete related authors
                string deleteAuthorsQuery = "DELETE FROM BookAuthor WHERE Book_Id_fk = @Book_Id";
                SqlCommand authorsCmd = new SqlCommand(deleteAuthorsQuery, conn, transaction);
                authorsCmd.Parameters.AddWithValue("@Book_Id", Book_Id);
                authorsCmd.ExecuteNonQuery();

                // Step 3: Delete the book
                string deleteBookQuery = "DELETE FROM Book WHERE Book_Id = @Book_Id";
                SqlCommand bookCmd = new SqlCommand(deleteBookQuery, conn, transaction);
                bookCmd.Parameters.AddWithValue("@Book_Id", Book_Id);
                bookCmd.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Book deleted successfully!", "Success");
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

                string qry = @"
                    SELECT b.Book_Id, b.Price, b.ISBN, b.Book_Name, b.Genre_Id_fk, b.Discount, ba.Author_Id_fk 
                    FROM Book b 
                    LEFT JOIN BookAuthor ba ON b.Book_Id = ba.Book_Id_fk 
                    WHERE b.Book_Id = @Book_Id";

                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@Book_Id", Book_Id);

                SqlDataReader rd = cmd.ExecuteReader();
                Author_Ids.Clear();

                while (rd.Read())
                {
                    Book_Id = Convert.ToInt32(rd["Book_Id"]);
                    Price = Convert.ToSingle(rd["Price"]);
                    ISBN = rd["ISBN"].ToString();
                    Book_Name = rd["Book_Name"].ToString();
                    Genre_Id_fk = Convert.ToInt32(rd["Genre_Id_fk"]);
                    Discount = Convert.ToSingle(rd["Discount"]);

                    if (rd["Author_Id_fk"] != DBNull.Value)
                        Author_Ids.Add(Convert.ToInt32(rd["Author_Id_fk"]));
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