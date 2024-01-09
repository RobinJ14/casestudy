using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using casestudy.DAO;
using casestudy.Entity;

namespace casestudy
{
    internal class EcomApp
    {
        static void Main(string[] args)
        {
            int flag = 1, ch;
            Boolean res;

            OrderProcessorRepositoryimpl orderProcessorRepositoryimpl = new OrderProcessorRepositoryimpl();


            do
            {
                Console.WriteLine("1.Register Customeer.......");
                Console.WriteLine("2.Create Product.......");
                Console.WriteLine("3.Delete Product.......");
                Console.WriteLine("4.Add To Cart.......");
                Console.WriteLine("5.View Cart.......");
                Console.WriteLine("6.delete from Cart.......");
                Console.WriteLine("7.Place Order.......");
                Console.WriteLine("8.View Customer Order......");
                Console.WriteLine("9.delete customer......");
                Console.WriteLine("10.Exit........");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        getcustomer();
                        break;

                    case 2:
                        getproduct();
                        break;
                    case 3:
                        removeproduct();
                        break;
                    case 4:
                        addcart();
                        break;

                    case 5:
                        showcart();
                        break;

                    case 6:
                        removecart();
                        break;

                    case 7:
                        placeorder();
                        break;
                    case 8:
                        vieworder();

                        break;
                    case 9:
                        deletecustomer();

                        break;

                    case 10:
                        flag = 0;
                        break;

                    default:
                        Console.WriteLine("Invalid input.....");
                        break;
                }




            } while (flag == 1);

            void getcustomer()
            {
                Customer customer = new Customer();
                Console.Write("Enter customer ID::");
                customer.Customer_id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter customer Name::");
                customer.Name = Console.ReadLine();
                Console.Write("Enter customer email::");
                customer.Email = Console.ReadLine();
                Console.Write("Enter customer password::");
                customer.password2 = Console.ReadLine();

                res = orderProcessorRepositoryimpl.createcustomer(customer);
                if (res)
                {
                    Console.WriteLine("succefully inserted");
                }

            }

            void getproduct()
            {
                Product product = new Product();
                Console.Write("Enter product ID::");
                product.Product_id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter product Name::");
                product.Name = Console.ReadLine();
                Console.Write("Enter product price::");
                product.Price = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter product description::");
                product.Description = Console.ReadLine();
                Console.Write("Enter stockquantity::");
                product.Stockquantity = Convert.ToInt32(Console.ReadLine());

                res = orderProcessorRepositoryimpl.createproduct(product);
                if (res)
                {
                    Console.WriteLine("succefully inserted");
                }

            }

            void removeproduct()
            {
                Product product1 = new Product();
                Console.WriteLine("Enter productid");
                product1.Product_id = Convert.ToInt32(Console.ReadLine());
                res = orderProcessorRepositoryimpl.deleteproduct(product1);
                if (res == true)
                {
                    Console.WriteLine("succefully deleted");
                }
                else
                {
                    Console.WriteLine("");
                }
            }

            void addcart()
            {
                Customer customer1 = new Customer();
                Product product2 = new Product();

                Console.Write("Enter product ID::");
                product2.Product_id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter customer ID::");
                customer1.Customer_id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter quantity::");
                int Quantity = Convert.ToInt32(Console.ReadLine());

                res = orderProcessorRepositoryimpl.addtocart(customer1, product2, Quantity);
                if (res)
                {
                    Console.WriteLine("succefully inserted");
                }
            }

            void showcart()
            {
                Console.WriteLine("Enter customer id:");

                Customer customer2 = new Customer();
                customer2.Customer_id = Convert.ToInt32(Console.ReadLine());

                List<Product> list1 = orderProcessorRepositoryimpl.getallfromcart(customer2);
                foreach (Product p in list1)
                {
                    Console.WriteLine($"\nproductid={p.Product_id}\tprice={p.Price} \tname={p.Name}\t description={p.Description}\t stock= {p.Stockquantity}\n");
                }
            }

            void removecart()
            {
                Customer customer3 = new Customer();
                Product product3 = new Product();

                Console.Write("Enter product ID::");
                product3.Product_id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter customer ID::");
                customer3.Customer_id = Convert.ToInt32(Console.ReadLine());


                res = orderProcessorRepositoryimpl.removefromcart(customer3, product3);
                if (res)
                {
                    Console.WriteLine("succefully deleted");
                }
            }


            void placeorder()
            {
                List<Tuple<Product, int>> tuples2 = new List<Tuple<Product, int>>();
                Product product4 = new Product();
                Customer customer5 = new Customer();

                Console.WriteLine("Enter customer id");
                customer5.Customer_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter product id");
                product4.Product_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter quantity");
                int quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("shipping address");
                string addr = Console.ReadLine();


                tuples2.Add(new Tuple<Product, int>(product4, quantity));
                res = orderProcessorRepositoryimpl.placeorder(customer5, tuples2, addr);
                if (res)
                {
                    Console.WriteLine("succefully inserted");
                };

            }

            void vieworder()
            {
                Console.WriteLine("Enter customer id:");

                Customer customer4 = new Customer();
                customer4.Customer_id = Convert.ToInt32(Console.ReadLine());
                List<Tuple<Product, int>> tuples = orderProcessorRepositoryimpl.getordersbycustomer(customer4);
                foreach (Tuple<Product, int> tuple in tuples)
                {
                    Console.WriteLine($"Product_ID={tuple.Item1.Product_id} \tProduct Name={tuple.Item1.Name} \t Quantity={tuple.Item2}");
                }
            }

            void deletecustomer()
            {
                Customer customer6 = new Customer();
                Console.WriteLine("Enter customer id:");
                customer6.Customer_id = Convert.ToInt32(Console.ReadLine());
                res = orderProcessorRepositoryimpl.deletecustomer(customer6);
                if (res)
                {
                    Console.WriteLine("succefully deleted");
                };

            }

        }
    }
}
