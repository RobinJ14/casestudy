using casestudy.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using casestudy.Util;

namespace casestudy.DAO
{
    internal class OrderProcessorRepositoryimpl : IOrderProcessorRepository
    {
        SqlConnection conn = null;
        public bool addtocart(Customer customer, Product product, int quantity)
        {
            Cart cart = new Cart();
            cart.Customer_id=customer.Customer_id;
            cart.Product_id=product.Product_id;
            cart.Quantity = quantity;
            conn = DBconnection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into cart values({cart.Customer_id},{cart.Product_id},{cart.Quantity}); ";
            conn.Open();

            int rowcount = cmd.ExecuteNonQuery();
            if (rowcount > 0)
            {
                return true;
            }
            else { return false; }
        }

        public bool createcustomer(Customer customer)
        {
            conn = DBconnection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into customers values({customer.Customer_id},'{customer.Name}','{customer.Email}','{customer.password2}'); ";
            conn.Open();

            int rowcount=cmd.ExecuteNonQuery();
            if (rowcount > 0)
            {
                return true;
            }
            else { return false; }

            

        }

        public bool createproduct(Product product)
        {
            conn = DBconnection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into products values({product.Product_id},'{product.Name}','{product.Description}','{product.Stockquantity}'); ";
            conn.Open();

            int rowcount = cmd.ExecuteNonQuery();
            if (rowcount > 0)
            {
                return true;
            }
            else { return false; }

        }

        public bool deletecustomer(Customer customerid)
        {
            conn = DBconnection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"delete from customers where customer_id={customerid.Customer_id}; ";
            conn.Open();

            int rowcount = cmd.ExecuteNonQuery();
            if (rowcount > 0)
            {
                return true;
            }
            else { return false; }
        }

        public bool deleteproduct(Product productid)
        {
            conn = DBconnection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"delete from products where product_id={productid.Product_id}; ";
            conn.Open();

            int rowcount = cmd.ExecuteNonQuery();
            if (rowcount > 0)
            {
                return true;
            }
            else { return false; }
        }

        public List<Product> getallfromcart(Customer customer)
        {
            int id = customer.Customer_id;
            List<Product> products = new List<Product>();
            conn=DBconnection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection=conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select p.product_id,p.price,p.Name,p.description,p.stockquantity from products p inner join cart c on p.product_id=c.product_id where customer_id={id} ";
            conn.Open();
            SqlDataReader dr=cmd.ExecuteReader();

            while (dr.Read())
            {
                products.Add(new Product() { Product_id = (int)dr[0], Price = (decimal)dr[1], Name = dr[2].ToString(), 
                    Description = dr[3].ToString(), Stockquantity = (int)dr[4] });
            }
            dr.Close();
            conn.Close();
            return products;
        }

        public bool removefromcart(Customer customer, Product product)
        {

            conn = DBconnection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"delete from cart where product_id={product.Product_id} and customer_id={customer.Customer_id}; ";
            conn.Open();

            int rowcount = cmd.ExecuteNonQuery();
            if (rowcount > 0)
            {
                return true;
            }
            else { return false; }


        }
    }
}
