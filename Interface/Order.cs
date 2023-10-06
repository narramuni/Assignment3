using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public enum PaymentMode
    {
        cash,
        upi,
        debit,
        credit,
        netbanking
    }




    public class Order
    {
        private int _orderid , OrderidCounter = 1;

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

        private PaymentMode _paymode;

        public PaymentMode GetPaymentMode
        {
            get { return _paymode; }
            set { _paymode = value; }
        }

        public Order()
        {
            _orderid = OrderidCounter++;

        }

        public decimal CalculateTotalPurchase(int qty, int price)
        {
            return qty * price;
        }


        public void BookOrder(int custid, DateTime orderdate, PaymentMode paymode, int qty, int price)
        {
            Console.WriteLine("Order booked successfully......");

            decimal amt = CalculateTotalPurchase(qty, price);
            Console.WriteLine($"Order booked for customerid= {custid} on {orderdate}, payment received by {paymode} for a qty of {qty} @ the price of {price} and the total price = {amt}");
        }

        public void BookOrder()
        {
            Console.WriteLine($"OrderID :{_orderid} - Order date: {_orderdate}");
        }
    }
}




