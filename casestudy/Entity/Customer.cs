using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy.Entity
{
    internal class Customer
    {
        private int customer_id { get; set; }
        private string name { get; set; }
        private string email { get; set; }
        private string password { get; set; }

        public int Customer_id { get { return customer_id; } set { customer_id=value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string password2 { get { return password; } set { password = value; } }





    }
}
