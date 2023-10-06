using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Product product = new Product();


            Console.WriteLine("Enter Custid");

            customer.Custid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Custname");

            customer.Custname = Console.ReadLine();




            Console.WriteLine("Enter Productid");

            product.Productid = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter Productname");

            product.Productname = Console.ReadLine();

            Console.WriteLine("Enter Price");

            product.Price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Quantity");

            product.Qty = Convert.ToInt32(Console.ReadLine());










            Order order = new Order
            {
                OrderDate = DateTime.Now,
            };

            IOperations operations = new IOperations(); 
            operations.AddToCart(product.Productid,"India", product.Qty, product.Price);
            operations.PaymentGateway(100);
            operations.BuyNow();

            order.BookOrder();

            Console.Read();
            
        }
    }
}
