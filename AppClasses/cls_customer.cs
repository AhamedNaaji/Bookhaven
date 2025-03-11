using Bookhaven.CommonClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookhaven.AppClasses
{
    internal class cls_customer
    {
        private readonly Common _cmn = new Common();

        public string Customer_Name { get; set; }
        public string NIC { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string mobileNumber1 { get; set; }

        public string mobileNumber2 { get; set; }

        public void InsertCustomer()
        {
            string query = @"
            INSERT INTO Customer (Customer_Name, NIC, DOB, Address, Email)
            VALUES (@Customer_Name, @NIC, @DOB, @Address, @Email)";

            SqlParameter[] parameters =
            {
            new SqlParameter("@Customer_Name", Customer_Name),
            new SqlParameter("@NIC", NIC),
            new SqlParameter("@DOB", DOB),
            new SqlParameter("@Address", Address),
            new SqlParameter("@Email", Email)
        };

            _cmn.RunParameterizedQuery(query, parameters);
        }




        //public void Getdata()
        //{
        //    string qry = "SELECT * FROM Customer  WHERE Customer_Id = '" + Customer_Id + "'";
        //    fileoperation fill = new fileoperation();
        //    SqlDataReader rd = fill.FillWithID(qry);

        //    if (rd.Read())
        //    {
        //        Customer_Id = Convert.ToInt32(rd["emp_id"].ToString());
        //        Customer_Name = rd["Customer_Name"].ToString();
        //        NIC = Convert.ToString(rd["NIC"]);
        //        DOB = rd["DOB"].ToString();
        //        Address = rd["Address"].ToString();
        //        Email = rd["Email"].ToString();
        //        Mobile_Number = Convert.ToInt32(rd["allowance"]);
        //        joindate = Convert.ToDateTime(rd["joindate"]);
        //        jobrole = Convert.ToString(rd["job_role"]);
        //        gender = rd["gender"].ToString();
        //    }
        //}

    }

}
