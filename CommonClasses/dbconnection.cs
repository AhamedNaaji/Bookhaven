using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookhaven.CommonClasses
{
    internal class dbconnection
    {
        public SqlConnection mycon = new SqlConnection("Data Source=DESKTOP-V3UAK82;Initial Catalog=Bookhaven;Integrated Security=True;Encrypt=False");

    }
}
