using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy.Entity
{
    internal class Product
    {
        private int product_id;
        private string name;
        private decimal price;
        private string description;
        private int stockquantity;

        public int Product_id { get { return product_id; } set { product_id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public decimal Price { get { return price; } set { price = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int Stockquantity { get { return stockquantity; } set { stockquantity = value; } }
    }

}
