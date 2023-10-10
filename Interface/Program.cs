using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Interface
{
    public class Program : IOperations
    {
        public static void Main(string[] args)  

       
        {

            Product p = new Product();
            {
                Console.WriteLine("enter your product id:");
                p.Productid = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("enter your product name:");
                p.Productname = (Console.ReadLine());


                Console.WriteLine("enter your product quantity:");
                p.Qty = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter your product price:");
                p.Price = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("*****************");


                Customer c = new Customer();
                Console.WriteLine("enter your customer id:");
                c.Custid = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter your customer name:");
                c.Custname = (Console.ReadLine());

                Order o = new Order();

                Console.WriteLine("enter your first order date:");
                o.OrderDate = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("enter your second order date:");
                o.OrderDate = Convert.ToDateTime(Console.ReadLine());


                Console.WriteLine("************************************");



                o.Addtocart(c.Custid, c.Custname, o.OrderDate, p.Qty, p.Price);

                Console.WriteLine($"CustomerDetails: {c.Custid},{c.Custname}");
                Console.WriteLine($"ProductDetails:  {p.Productid},{p.Productname},{p.Qty},{p.Price}");
                Console.WriteLine($"OrderDetails:    {o.OrderDate},{o.OrderDate}");

                Console.ReadLine();
            }
            
        }

        
    }
 }
