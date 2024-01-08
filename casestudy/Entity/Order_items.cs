using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy.Entity
{
    internal class Order_items
    {
        private int order_item_id;
        private int order_id;
        private int product_id;
        private int quantiy;

        public int Order_item_id { get { return order_item_id; } set { order_item_id = value; } }
        public int Order_id { get { return order_id; } set { order_id = value; } }
        public int Product_id { get { return product_id; } set { product_id = value; } }

        public int quantity { get { return quantiy; } set { quantiy = value; } }

    }  
}
