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
        private static int lastOrderId = 1;
        private int _orderid;

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

        public void Addtocart(int custid, string custname, DateTime orderdate, float qty, decimal price)
        {
            OrderID = ++lastOrderId;
            OrderDate = orderdate;
            Console.WriteLine("Order booked successfully......");



        }
        private PaymentMode PaymentGateway;
        public PaymentMode paymentgateway
        {
            get { return PaymentGateway; }
            set { PaymentGateway = value; }
        }
    }
}




