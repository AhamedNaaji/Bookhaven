using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookhaven.CommonClasses
{
    internal class Common
    {
        dbconnection dbcon = new dbconnection();

        public void messages(string qry, string key)
        {
            try
            {
                switch (key.ToLower())
                {
                    case "insert":
                        if (MessageBox.Show("Do you want to save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            RunQuery(qry);
                            MessageBox.Show("Saved Successfully", "Saved");
                        }
                        break;
                    case "update":
                        if (MessageBox.Show("Do you want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            RunQuery(qry);
                            MessageBox.Show("Updated Successfully", "Updated");
                        }
                        break;
                    case "delete":
                        if (MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            RunQuery(qry);
                            MessageBox.Show("Deleted Successfully", "Deleted");
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }

        void RunQuery(string qry)
        {
            dbcon.mycon.Open();
            SqlCommand cmd = new SqlCommand(qry, dbcon.mycon);
            cmd.ExecuteNonQuery();
            dbcon.mycon.Close();
        }
    }

}
