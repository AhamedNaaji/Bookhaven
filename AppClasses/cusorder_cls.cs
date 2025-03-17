using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookhaven.AppClasses
{
    internal class cusorder_cls
    {
        public SqlConnection Connection => conn;
        SqlConnection conn = new SqlConnection("Data Source=AFRIDI;Initial Catalog=Bookheaven;Integrated Security=True;Encrypt=False");
        SqlTransaction transaction;

        // Properties for CusOrder
        public int CustOrder_Id { get; set; }
        public int Staff_Id_fk { get; set; }
        public int Customer_Id_fk { get; set; }
        public int Supplier_Id_fk { get; set; } // New property for supplier
        public DateTime Date { get; set; }
        public int Status_Id_fk { get; set; }
        public float Total_Payment { get; set; }

        // List to store order details
        public List<CusOrderDetail> OrderDetails { get; set; } = new List<CusOrderDetail>();

        // Nested class for order details
        public class CusOrderDetail
        {
            public int Book_Id_fk { get; set; }
            public int Quantity { get; set; }
            public string DeliveryMethod { get; set; }
            public float Discount { get; set; }
            public float Final_Amount { get; set; }
        }

        // Insert data into CusOrder and CusOrderDetails tables
        public void Insertdata()
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // Step 1: Insert into CusOrder table
                string insertOrderQuery = @"
            INSERT INTO CusOrder (Staff_Id_fk, Customer_Id_fk, Supplier_Id_fk, Date, Status_Id_fk, Total_Payment)
            VALUES (@Staff_Id_fk, @Customer_Id_fk, @Supplier_Id_fk, @Date, @Status_Id_fk, @Total_Payment);
            SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(insertOrderQuery, conn, transaction);
                cmd.Parameters.AddWithValue("@Staff_Id_fk", Staff_Id_fk);
                cmd.Parameters.AddWithValue("@Customer_Id_fk", Customer_Id_fk);
                cmd.Parameters.AddWithValue("@Supplier_Id_fk", Supplier_Id_fk); // Include Supplier_Id_fk
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@Status_Id_fk", Status_Id_fk);
                cmd.Parameters.AddWithValue("@Total_Payment", Total_Payment);

                int custOrderId = Convert.ToInt32(cmd.ExecuteScalar());

                // Step 2: Insert all order details
                foreach (var detail in OrderDetails)
                {
                    string detailQuery = @"
                INSERT INTO CusOrderDetails (Book_Id_fk, CustOrder_Id_fk, Quantity, DeliveryMethod, Discount, Final_Amount)
                VALUES (@Book_Id_fk, @CustOrder_Id_fk, @Quantity, @DeliveryMethod, @Discount, @Final_Amount)";

                    SqlCommand detailCmd = new SqlCommand(detailQuery, conn, transaction);
                    detailCmd.Parameters.AddWithValue("@Book_Id_fk", detail.Book_Id_fk);
                    detailCmd.Parameters.AddWithValue("@CustOrder_Id_fk", custOrderId);
                    detailCmd.Parameters.AddWithValue("@Quantity", detail.Quantity);
                    detailCmd.Parameters.AddWithValue("@DeliveryMethod", detail.DeliveryMethod);
                    detailCmd.Parameters.AddWithValue("@Discount", detail.Discount);
                    detailCmd.Parameters.AddWithValue("@Final_Amount", detail.Final_Amount);

                    detailCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Order created successfully!", "Success");
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

        // Update data in CusOrder and CusOrderDetails tables
        public void UpdateData()
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // Step 1: Update CusOrder table
                string updateOrderQuery = @"
            UPDATE CusOrder
            SET Staff_Id_fk = @Staff_Id_fk,
                Customer_Id_fk = @Customer_Id_fk,
                Supplier_Id_fk = @Supplier_Id_fk, -- Include Supplier_Id_fk
                Date = @Date,
                Status_Id_fk = @Status_Id_fk,
                Total_Payment = @Total_Payment
            WHERE CustOrder_Id = @CustOrder_Id";

                SqlCommand cmd = new SqlCommand(updateOrderQuery, conn, transaction);
                cmd.Parameters.AddWithValue("@Staff_Id_fk", Staff_Id_fk);
                cmd.Parameters.AddWithValue("@Customer_Id_fk", Customer_Id_fk);
                cmd.Parameters.AddWithValue("@Supplier_Id_fk", Supplier_Id_fk); // Include Supplier_Id_fk
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@Status_Id_fk", Status_Id_fk);
                cmd.Parameters.AddWithValue("@Total_Payment", Total_Payment);
                cmd.Parameters.AddWithValue("@CustOrder_Id", CustOrder_Id);

                cmd.ExecuteNonQuery();

                // Step 2: Delete existing order details
                string deleteDetailsQuery = "DELETE FROM CusOrderDetails WHERE CustOrder_Id_fk = @CustOrder_Id";
                SqlCommand deleteCmd = new SqlCommand(deleteDetailsQuery, conn, transaction);
                deleteCmd.Parameters.AddWithValue("@CustOrder_Id", CustOrder_Id);
                deleteCmd.ExecuteNonQuery();

                // Step 3: Insert updated order details
                foreach (var detail in OrderDetails)
                {
                    string insertDetailQuery = @"
                INSERT INTO CusOrderDetails (Book_Id_fk, CustOrder_Id_fk, Quantity, DeliveryMethod, Discount, Final_Amount)
                VALUES (@Book_Id_fk, @CustOrder_Id_fk, @Quantity, @DeliveryMethod, @Discount, @Final_Amount)";

                    SqlCommand detailCmd = new SqlCommand(insertDetailQuery, conn, transaction);
                    detailCmd.Parameters.AddWithValue("@Book_Id_fk", detail.Book_Id_fk);
                    detailCmd.Parameters.AddWithValue("@CustOrder_Id_fk", CustOrder_Id);
                    detailCmd.Parameters.AddWithValue("@Quantity", detail.Quantity);
                    detailCmd.Parameters.AddWithValue("@DeliveryMethod", detail.DeliveryMethod);
                    detailCmd.Parameters.AddWithValue("@Discount", detail.Discount);
                    detailCmd.Parameters.AddWithValue("@Final_Amount", detail.Final_Amount);

                    detailCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Order updated successfully!", "Success");
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

        // Delete data from CusOrder and CusOrderDetails tables
        public void DeleteData()
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                // Step 1: Delete related order details
                string deleteDetailsQuery = "DELETE FROM CusOrderDetails WHERE CustOrder_Id_fk = @CustOrder_Id";
                SqlCommand detailsCmd = new SqlCommand(deleteDetailsQuery, conn, transaction);
                detailsCmd.Parameters.AddWithValue("@CustOrder_Id", CustOrder_Id);
                detailsCmd.ExecuteNonQuery();

                // Step 2: Delete the customer order
                string deleteOrderQuery = "DELETE FROM CusOrder WHERE CustOrder_Id = @CustOrder_Id";
                SqlCommand orderCmd = new SqlCommand(deleteOrderQuery, conn, transaction);
                orderCmd.Parameters.AddWithValue("@CustOrder_Id", CustOrder_Id);
                orderCmd.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Customer order deleted successfully!", "Success");
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
        public (float Price, float Discount) GetBookDetails(int bookId)
        {
            try
            {
                conn.Open();
                string query = @"
                SELECT Price, Discount 
                FROM Book 
                WHERE Book_Id = @Book_Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Book_Id", bookId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    float price = Convert.ToSingle(reader["Price"]);
                    float discount = Convert.ToSingle(reader["Discount"]);
                    return (price, discount);
                }

                throw new Exception("Book not found.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching book details: {ex.Message}");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        // Fetch data for a specific customer order
        public void Getdata()
        {
            try
            {
                conn.Open();

                // Step 1: Fetch main order details
                string orderQuery = @"
                    SELECT * 
                    FROM CusOrder 
                    WHERE CustOrder_Id = @CustOrder_Id";

                SqlCommand orderCmd = new SqlCommand(orderQuery, conn);
                orderCmd.Parameters.AddWithValue("@CustOrder_Id", CustOrder_Id);

                SqlDataReader orderReader = orderCmd.ExecuteReader();
                if (orderReader.Read())
                {
                    CustOrder_Id = Convert.ToInt32(orderReader["CustOrder_Id"]);
                    Staff_Id_fk = Convert.ToInt32(orderReader["Staff_Id_fk"]);
                    Customer_Id_fk = Convert.ToInt32(orderReader["Customer_Id_fk"]);
                    Supplier_Id_fk = Convert.ToInt32(orderReader["Supplier_Id_fk"]); // Include supplier
                    Date = Convert.ToDateTime(orderReader["Date"]);
                    Status_Id_fk = Convert.ToInt32(orderReader["Status_Id_fk"]);
                    Total_Payment = Convert.ToSingle(orderReader["Total_Payment"]);
                }
                orderReader.Close();

                // Step 2: Fetch order details
                string detailsQuery = @"
                    SELECT * 
                    FROM CusOrderDetails 
                    WHERE CustOrder_Id_fk = @CustOrder_Id";

                SqlCommand detailsCmd = new SqlCommand(detailsQuery, conn);
                detailsCmd.Parameters.AddWithValue("@CustOrder_Id", CustOrder_Id);

                SqlDataReader detailsReader = detailsCmd.ExecuteReader();
                OrderDetails.Clear();
                while (detailsReader.Read())
                {
                    OrderDetails.Add(new CusOrderDetail
                    {
                        Book_Id_fk = Convert.ToInt32(detailsReader["Book_Id_fk"]),
                        Quantity = Convert.ToInt32(detailsReader["Quantity"]),
                        DeliveryMethod = detailsReader["DeliveryMethod"].ToString(),
                        Discount = Convert.ToSingle(detailsReader["Discount"]),
                        Final_Amount = Convert.ToSingle(detailsReader["Final_Amount"])
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