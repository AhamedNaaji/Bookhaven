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
