using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bookhaven.CommonClasses
{
    internal class Common
    {
        private readonly dbconnection _dbcon = new dbconnection();

        /// <summary>
        /// Executes a SQL query.
        /// </summary>
        /// <param name="query">The SQL query to execute.</param>
        public void RunQuery(string query)
        {
            try
            {
                using (SqlConnection connection = _dbcon.mycon)
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to execute query: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Executes a parameterized SQL query.
        /// </summary>
        /// <param name="query">The SQL query to execute.</param>
        /// <param name="parameters">The parameters for the query.</param>
        public void RunParameterizedQuery(string query, SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = _dbcon.mycon)
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to execute parameterized query: " + ex.Message, ex);
            }
        }
    }
}