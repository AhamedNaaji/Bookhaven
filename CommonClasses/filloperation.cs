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
    internal class filloperation
    {
        dbConnection con = new dbConnection();


        public void combobox(string qry, ComboBox cmb_name, string display_member, string value_member)
        {
            try
            {
                if (con.mycon.State != ConnectionState.Open)
                    con.mycon.Open();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, con.mycon);
                da.Fill(dt);
                cmb_name.DisplayMember = display_member;
                cmb_name.ValueMember = value_member;
                cmb_name.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Combo Load Error: {ex.Message}");
            }
            finally
            {
                if (con.mycon.State == ConnectionState.Open)
                    con.mycon.Close();
            }
        }

        public void FillDataGridView(string qry, DataGridView dgv)
        {
            try
            {
                if (con.mycon.State != ConnectionState.Open)
                    con.mycon.Open();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, con.mycon);
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Data Loading Error: {ex.Message}");
            }
            finally
            {
                if (con.mycon.State == ConnectionState.Open)
                    con.mycon.Close();
            }
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
