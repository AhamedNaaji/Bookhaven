using Bookhaven.CommonClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookhaven.AppClasses
{
    internal class suporder_cls
    {
        Common cmn = new Common();
        SqlConnection conn = new SqlConnection("Data Source=AFRIDI;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");
        SqlTransaction transaction;

        // Properties for supOrder
        public int supOrder_Id { get; set; }
        public int Staff_Id_fk { get; set; }
        public int Supplier_Id_fk { get; set; }
        public int Book_Id_fk { get; set; }
        public DateTime Date { get; set; }
        public int Status_Id_fk { get; set; }
        public float Total_Payment { get; set; }

        // Nested class for order details
        public class SupOrderDetail
        {
            public int Book_Id_fk { get; set; }
            public int Quantity { get; set; }
            public float Discount { get; set; }
            public float Final_Amount { get; set; }
        }

        public List<SupOrderDetail> OrderDetails = new List<SupOrderDetail>();

        // Insert data into supOrder and supOrderDetails tables
        public void Insertdata()
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // Step 1: Insert into supOrder table
                string insertOrderQuery = @"
                    INSERT INTO supOrder (Staff_Id_fk, Supplier_Id_fk, Book_Id_fk, Date, Status_Id_fk, Total_Payment)
                    VALUES (@Staff_Id_fk, @Supplier_Id_fk, @Book_Id_fk, @Date, @Status_Id_fk, @Total_Payment);
                    SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(insertOrderQuery, conn, transaction);
                cmd.Parameters.AddWithValue("@Staff_Id_fk", Staff_Id_fk);
                cmd.Parameters.AddWithValue("@Supplier_Id_fk", Supplier_Id_fk);
                cmd.Parameters.AddWithValue("@Book_Id_fk", Book_Id_fk);
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@Status_Id_fk", Status_Id_fk);
                cmd.Parameters.AddWithValue("@Total_Payment", Total_Payment);

                int supOrderId = Convert.ToInt32(cmd.ExecuteScalar());

                // Step 2: Insert all order details
                foreach (var detail in OrderDetails)
                {
                    string detailQuery = @"
                        INSERT INTO supOrderDetails (Book_Id_fk, supOrder_Id_fk, Quantity, Discount, Final_Amount)
                        VALUES (@Book_Id_fk, @supOrder_Id_fk, @Quantity, @Discount, @Final_Amount)";

                    SqlCommand detailCmd = new SqlCommand(detailQuery, conn, transaction);
                    detailCmd.Parameters.AddWithValue("@Book_Id_fk", detail.Book_Id_fk);
                    detailCmd.Parameters.AddWithValue("@supOrder_Id_fk", supOrderId);
                    detailCmd.Parameters.AddWithValue("@Quantity", detail.Quantity);
                    detailCmd.Parameters.AddWithValue("@Discount", detail.Discount);
                    detailCmd.Parameters.AddWithValue("@Final_Amount", detail.Final_Amount);

                    detailCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Supplier order inserted successfully!", "Success");
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

        // Update data in supOrder and supOrderDetails tables
        public void UpdateData()
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // Step 1: Update supOrder table
                string updateOrderQuery = @"
                    UPDATE supOrder
                    SET Staff_Id_fk = @Staff_Id_fk,
                        Supplier_Id_fk = @Supplier_Id_fk,
                        Book_Id_fk = @Book_Id_fk,
                        Date = @Date,
                        Status_Id_fk = @Status_Id_fk,
                        Total_Payment = @Total_Payment
                    WHERE supOrder_Id = @supOrder_Id";

                SqlCommand cmd = new SqlCommand(updateOrderQuery, conn, transaction);
                cmd.Parameters.AddWithValue("@Staff_Id_fk", Staff_Id_fk);
                cmd.Parameters.AddWithValue("@Supplier_Id_fk", Supplier_Id_fk);
                cmd.Parameters.AddWithValue("@Book_Id_fk", Book_Id_fk);
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@Status_Id_fk", Status_Id_fk);
                cmd.Parameters.AddWithValue("@Total_Payment", Total_Payment);
                cmd.Parameters.AddWithValue("@supOrder_Id", supOrder_Id);

                cmd.ExecuteNonQuery();

                // Step 2: Delete existing order details
                string deleteDetailsQuery = "DELETE FROM supOrderDetails WHERE supOrder_Id_fk = @supOrder_Id";
                SqlCommand deleteCmd = new SqlCommand(deleteDetailsQuery, conn, transaction);
                deleteCmd.Parameters.AddWithValue("@supOrder_Id", supOrder_Id);
                deleteCmd.ExecuteNonQuery();

                // Step 3: Insert updated order details
                foreach (var detail in OrderDetails)
                {
                    string insertDetailQuery = @"
                        INSERT INTO supOrderDetails (Book_Id_fk, supOrder_Id_fk, Quantity, Discount, Final_Amount)
                        VALUES (@Book_Id_fk, @supOrder_Id_fk, @Quantity, @Discount, @Final_Amount)";

                    SqlCommand insertCmd = new SqlCommand(insertDetailQuery, conn, transaction);
                    insertCmd.Parameters.AddWithValue("@Book_Id_fk", detail.Book_Id_fk);
                    insertCmd.Parameters.AddWithValue("@supOrder_Id_fk", supOrder_Id);
                    insertCmd.Parameters.AddWithValue("@Quantity", detail.Quantity);
                    insertCmd.Parameters.AddWithValue("@Discount", detail.Discount);
                    insertCmd.Parameters.AddWithValue("@Final_Amount", detail.Final_Amount);

                    insertCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Supplier order updated successfully!", "Success");
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

        // Delete data from supOrder and supOrderDetails tables
        public void DeleteData()
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // Step 1: Delete order details
                string deleteDetailsQuery = "DELETE FROM supOrderDetails WHERE supOrder_Id_fk = @supOrder_Id";
                SqlCommand deleteDetailsCmd = new SqlCommand(deleteDetailsQuery, conn, transaction);
                deleteDetailsCmd.Parameters.AddWithValue("@supOrder_Id", supOrder_Id);
                deleteDetailsCmd.ExecuteNonQuery();

                // Step 2: Delete order
                string deleteOrderQuery = "DELETE FROM supOrder WHERE supOrder_Id = @supOrder_Id";
                SqlCommand deleteOrderCmd = new SqlCommand(deleteOrderQuery, conn, transaction);
                deleteOrderCmd.Parameters.AddWithValue("@supOrder_Id", supOrder_Id);
                deleteOrderCmd.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Supplier order deleted successfully!", "Success");
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

        // Fetch data for an existing supplier order
        public void Getdata()
        {
            try
            {
                conn.Open();

                // Step 1: Fetch supOrder data
                string orderQuery = "SELECT * FROM supOrder WHERE supOrder_Id = @supOrder_Id";
                SqlCommand orderCmd = new SqlCommand(orderQuery, conn);
                orderCmd.Parameters.AddWithValue("@supOrder_Id", supOrder_Id);

                SqlDataReader orderReader = orderCmd.ExecuteReader();
                if (orderReader.Read())
                {
                    supOrder_Id = Convert.ToInt32(orderReader["supOrder_Id"]);
                    Staff_Id_fk = Convert.ToInt32(orderReader["Staff_Id_fk"]);
                    Supplier_Id_fk = Convert.ToInt32(orderReader["Supplier_Id_fk"]);
                    Book_Id_fk = Convert.ToInt32(orderReader["Book_Id_fk"]);
                    Date = Convert.ToDateTime(orderReader["Date"]);
                    Status_Id_fk = Convert.ToInt32(orderReader["Status_Id_fk"]);
                    Total_Payment = Convert.ToSingle(orderReader["Total_Payment"]);
                }
                orderReader.Close();

                // Step 2: Fetch supOrderDetails data
                string detailsQuery = "SELECT * FROM supOrderDetails WHERE supOrder_Id_fk = @supOrder_Id";
                SqlCommand detailsCmd = new SqlCommand(detailsQuery, conn);
                detailsCmd.Parameters.AddWithValue("@supOrder_Id", supOrder_Id);

                SqlDataReader detailsReader = detailsCmd.ExecuteReader();
                while (detailsReader.Read())
                {
                    OrderDetails.Add(new SupOrderDetail
                    {
                        Book_Id_fk = Convert.ToInt32(detailsReader["Book_Id_fk"]),
                        Quantity = Convert.ToInt32(detailsReader["Quantity"]),
                        Discount = Convert.ToSingle(detailsReader["Discount"]),
                        Final_Amount = Convert.ToSingle(detailsReader["Final_Amount"])
                    });
                }
                detailsReader.Close();
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