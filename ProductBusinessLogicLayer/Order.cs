using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    //public enum PaymentMode
    //{
    //    cash,
    //    upi,
    //    debit,
    //    credit,
    //    netbanking
    //}




    public class Order
    {
        private  int  _orderid, OrderidCounter = 1;

        public int OrderID
        {
            get { return _orderid; }
            set { _orderid = value; }
        }
        private DateTime _orderdate;

        public DateTime OrderDate
        {
            get { return _orderdate; }
            set { _orderdate = value; }
        }

        public Dictionary<int, Product> Cart { get; private set; } = new Dictionary<int, Product>();

        public void BookOrder()
        {
            Console.WriteLine($"Order #{OrderID} is booked on {OrderDate}");
            foreach (var item in Cart)
            {
                Console.WriteLine($"Product: {item.Value.Productname}, Quantity: {item.Value.Qty}, Price: {item.Value.Price}");
            }
        }

        public Order()
        {
            _orderid = OrderidCounter++;

        }

        public decimal CalculateTotalPurchase(int qty, int price)
        {
            return qty * price;
        }
    }
}




