using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace casestudy.Util
{
    internal class Propertyutil
    {
        public static string getpropertystring()
        {
           String str = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            //return @"Server=ROBI_TECH;Database=Ecommerce;Integrated Security=True;";
            return str;
            

        }
    }
}
