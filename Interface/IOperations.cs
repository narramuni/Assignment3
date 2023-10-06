using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class IOperations
    {
        public void AddToCart(int prodid, string city, int qty, int price)
        {
            Console.WriteLine($"Add products with ID {prodid} to the cart in {city},Quantity:{qty}," +
                $"Price:{price}");
        }

        public void PaymentGateway(int amt)
        {
            Console.WriteLine($"Processed payment of {amt} through the payment gateway");
        }

        public void BuyNow()
        {
            Console.WriteLine(  "Instant purchase completed");
        }
    }
}
