using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace casestudy.Util
{
    internal class DBconnection
    {
        static SqlConnection connection = null;

        public static SqlConnection GetConnection()
        {
            connection = new SqlConnection();
           // connection.ConnectionString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            connection.ConnectionString = Propertyutil.getpropertystring();
            return connection;
        }
    }
}
