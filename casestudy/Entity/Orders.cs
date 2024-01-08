using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy.Entity
{
    internal class Orders
    {
        private int order_id;
        private int customer_id;
        private DateTime order_date;
        private double total_price;
        private string shipping_address;

        public int Order_id { get { return order_id; } set { order_id = value; } }
        public int Customer_id { get { return customer_id; } set { customer_id = value; } }
        public DateTime Order_date { get { return order_date; } set { order_date = value; } }

        public double Total_price { get { return total_price; } set { total_price = value; } }
        public string Shipping_address { get { return shipping_address; } set {shipping_address = value; } }


    }
}
