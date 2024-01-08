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
            int flag=1,ch;
            
            OrderProcessorRepositoryimpl orderProcessorRepositoryimpl = new OrderProcessorRepositoryimpl();


            do
            {
                Console.WriteLine("1.Register Customeer.......");
                Console.WriteLine("2.Create Product.......");
                Console.WriteLine("3.Delete Product.......");
                Console.WriteLine("4.Add To Cart.......");
                Console.WriteLine("5.View Cart.......");
                Console.WriteLine("6.Place Order.......");
                Console.WriteLine("7.View Customer Order......");
                Console.WriteLine("8.delete customer......");
                Console.WriteLine("9.Exit........");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Customer customer = new Customer();
                        Console.Write("Enter customer ID::");
                        customer.Customer_id= Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter customer Name::");
                        customer.Name = Console.ReadLine();
                        Console.Write("Enter customer email::");
                        customer.Email = Console.ReadLine();
                        Console.Write("Enter customer password::");
                        customer.password2 = Console.ReadLine();

                        Boolean res= orderProcessorRepositoryimpl.createcustomer(customer);
                        if (res)
                        {
                            Console.WriteLine("succefully inserted");
                        }
                        break;    

                    case 2: Product product = new Product();
                        Console.Write("Enter product ID::");
                        product.Product_id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter product Name::");
                        product.Name = Console.ReadLine();
                        Console.Write("Enter product price::");
                        product.Price= Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Enter product description::");
                        product.Description = Console.ReadLine();
                        Console.Write("Enter stockquantity::");
                        product.Stockquantity = Convert.ToInt32(Console.ReadLine());

                        Boolean pro = orderProcessorRepositoryimpl.createproduct(product);
                        if (pro)
                        {
                            Console.WriteLine("succefully inserted");
                        }

                        break;
                    case 3:
                        Product product1 = new Product();
                        Console.WriteLine("Enter productid");
                        product1.Product_id = Convert.ToInt32(Console.ReadLine());
                        Boolean ress=orderProcessorRepositoryimpl.deleteproduct(product1);
                        if (ress)
                        {
                            Console.WriteLine("succefully deleted");
                        }

                        break;
                    case 4:
                        Customer customer1 = new Customer();
                        Product product2 = new Product();
                        
                        Console.Write("Enter product ID::");
                        product2.Product_id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter customer ID::");
                        customer1.Customer_id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter quantity::");
                        int Quantity = Convert.ToInt32(Console.ReadLine());
                        
                        Boolean r=orderProcessorRepositoryimpl.addtocart(customer1,product2,Quantity);
                        if (r)
                        {
                            Console.WriteLine("succefully inserted");
                        }
                        break;

                    case 5: Console.WriteLine("Enter customer id:") ;
                        
                        Customer customer2 = new Customer();
                        customer2.Customer_id = Convert.ToInt32(Console.ReadLine());

                        List<Product> list1= orderProcessorRepositoryimpl.getallfromcart(customer2);
                        foreach (Product p in list1)
                        {
                            Console.WriteLine($"\nproductid={p.Product_id}\tprice={p.Price} \tname={p.Name}\t description={p.Description}\t stock= {p.Stockquantity}\n");
                        }
                        break;


                    case 6: flag = 2; break;
                    case 7: flag = 2; break;
                    case 8:
                        Customer customer3 = new Customer();
                        Console.WriteLine("Enter customer id:");

                        customer3.Customer_id = Convert.ToInt32(Console.ReadLine());

                        Boolean res2 = orderProcessorRepositoryimpl.deletecustomer(customer3);
                        if (res2)
                        {
                            Console.WriteLine("succefully deleted");
                        };

                        break;
 
                    case 9: flag = 0; break;




                    default: 
                        Console.WriteLine("Invalid input"); 
                        break;
                }




            } while(flag==1);

        

        }
    }
}
