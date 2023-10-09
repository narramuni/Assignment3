using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Program : IOperations
    {
        public void AddToCart(int prodid, string city, int qty, int price)
        {
            // Create a product and add it to the cart
            var product = new Product
            {
                Productid = prodid,
                Productname = city,
                Qty = qty,
                Price = price
            };
            CurrentOrder.Cart[prodid] = product;
            Console.WriteLine($"Added to cart: Product #{prodid}, Name: {city}, Quantity: {qty}, Price: {price}");
        }

        public void PaymentGateway(int amt)
        {
            // Implement the payment gateway logic here
            Console.WriteLine($"Payment of {amt:C} made successfully.");
        }

        public void BuyNow()
        {
            // Complete the order and proceed with payment
            CurrentOrder.BookOrder();
            PaymentGateway(CurrentOrder.Cart.Values.Sum(p => p.Price));
        }

        private Customer CurrentCustomer { get; set; }
        // Current order
        private Order CurrentOrder { get; set; }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.StartShopping();
        }


        public void StartShopping()
        {
            CurrentCustomer = new Customer
            {
                Custid = 1,
                Custname = "John Doe"
            };
            CurrentOrder = new Order();
            CurrentOrder.OrderDate = DateTime.Now;
            Console.WriteLine($"Welcome, {CurrentCustomer.Custname}! Your Customer ID: {CurrentCustomer.Custid}");
            Console.WriteLine($"Your Order ID: {CurrentOrder.OrderID}, Order Date: {CurrentOrder.OrderDate}");

            // Shopping logic
            AddToCart(101, "Product A", 2, 50);
            AddToCart(102, "Product B", 1, 30);
            BuyNow();

            Console.Read();

        }
    }
}
