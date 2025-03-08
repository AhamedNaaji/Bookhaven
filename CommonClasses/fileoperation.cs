using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookhaven.CommonClasses
{
    internal class fileoperation
    {
        dbconnection con = new dbconnection();

        double leaves;
        double totalleaves;
    

    public void combobox(string qry, ComboBox cmb_name, string display_member, string value_member)
        {
            if (con.mycon != null && con.mycon.State == ConnectionState.Closed)
            {
                con.mycon.Open();
            }

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(qry, con.mycon);
            da.Fill(dt);
            cmb_name.DisplayMember = display_member;
            cmb_name.ValueMember = value_member;
            cmb_name.DataSource = dt;

            con.mycon.Close();
        }

        public void FillDataGridView(string qry, DataGridView dgv)
        {
            if (con.mycon != null && con.mycon.State == ConnectionState.Closed)
            {
                con.mycon.Open();
            }

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(qry, con.mycon);
            da.Fill(dt);
            dgv.DataSource = dt;
        }

        public SqlDataReader FillWithID(string qry)
        {
            if (con.mycon != null && con.mycon.State == ConnectionState.Closed)
            {
                con.mycon.Open();
            }
            SqlCommand cmd = new SqlCommand(qry, con.mycon);
            SqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }

        public double Completed_leaves(int emp_id)
        {
            try
            {
                if (con.mycon != null || con.mycon.State == ConnectionState.Closed)
                {
                    con.mycon.Open();
                }
                string qry = "SELECT SUM(days) AS TotalLeaves FROM tbl_leave WHERE emp_id = " + emp_id;
                SqlCommand cmd = new SqlCommand(qry, con.mycon);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read() || rdr["TotalLeaves"] == null)
                {
                    leaves = Convert.ToDouble(rdr["TotalLeaves"]);
                }
                else
                {
                    leaves = 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.mycon.Close();
            }
            return leaves;
        }

        public double total_leaves(int emp_id)
        {
            try
            {
                if (con.mycon != null && con.mycon.State == ConnectionState.Closed)
                {
                    con.mycon.Open();
                }
                string qry = "SELECT et.annual_leave AS annual_leave FROM tbl_employee e INNER JOIN tbl_employeetype et ON e.emp_type_id = et.emp_type_id WHERE e.emp_id = " + emp_id;
                SqlCommand cmd = new SqlCommand(qry, con.mycon);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    totalleaves = Convert.ToInt32(rdr["annual_leave"]);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.mycon.Close();
            }

            return totalleaves;
        }

        public double Overtime_rate(int emp_id)
        {
            double overtimeRate = 0;

            try
            {
                if (con.mycon != null && con.mycon.State == ConnectionState.Closed)
                {
                    con.mycon.Open();
                }
                string qry = "SELECT et.overtime_rate_hour AS overtime_rate FROM tbl_employee e INNER JOIN tbl_employeetype et ON e.emp_type_id = et.emp_type_id WHERE e.emp_id = " + emp_id;
                SqlCommand cmd = new SqlCommand(qry, con.mycon);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    overtimeRate = Convert.ToDouble(rdr["overtime_rate"]);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.mycon.Close();
            }

            return overtimeRate;
        }


        public SqlDataReader getBeginDate(string monthyear)
        {
            if (con.mycon != null && con.mycon.State == ConnectionState.Closed)
            {
                con.mycon.Open();
            }
            string qry = $"SELECT * FROM tbl_setting WHERE month_year = '{monthyear}'";
            SqlCommand cmd = new SqlCommand(qry, con.mycon);
            SqlDataReader rdr = cmd.ExecuteReader();


            return rdr;
        }



        public SqlDataReader runReader(string qry)
        {
            if (con.mycon != null && con.mycon.State == ConnectionState.Closed)
            {
                con.mycon.Open();
            }

            SqlCommand cmd = new SqlCommand(qry, con.mycon);
            SqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }



        public DataTable getData(string qry)
        {
            if (con.mycon != null && con.mycon.State == ConnectionState.Closed)
            {
                con.mycon.Open();
            }
            SqlCommand cmd = new SqlCommand(qry, con.mycon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.mycon.Close();
            return dt;

        }

        
    }
}
