using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using casestudy.Entity;

namespace casestudy.DAO
{
    internal interface IOrderProcessorRepository
    {
        Boolean createproduct(Product product);
        Boolean createcustomer(Customer customer);
        Boolean deleteproduct(Product productid);
        Boolean deletecustomer(Customer customerid);
        Boolean addtocart(Customer customer,Product product,int quantity);
        Boolean removefromcart(Customer customer,Product product);
        List<Product> getallfromcart(Customer customer);

        Boolean placeorder(Customer customer, List<Tuple< Product,int>> list1, string shippingaddress);

        List<Tuple< Product,int>> getordersbycustomer(Customer customerid);



    }
}
