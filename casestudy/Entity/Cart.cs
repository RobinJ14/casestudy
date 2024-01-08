using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy.Entity
{
    internal class Cart
    {
        private int cart_id;
        private int customer_id;
        private int product_id;
        private int quantity;

        public int Cart_id { get { return cart_id; } set { cart_id = value; } }
        public int Customer_id { get { return customer_id; } set { customer_id = value; } }
        public int Product_id { get { return product_id; } set { product_id = value; } }
        public int Quantity { get { return quantity; }set { quantity = value; } }
    }
}
