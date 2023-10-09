using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Product
    {

        private int _prodid;

        public int Productid
        {
            get { return _prodid; }
            set { _prodid = value; }
        }

        private string _prodname;

        public string Productname
        {
            get { return _prodname; }
            set { _prodname = value; }
        }

        private decimal _uom;

        public decimal UnitOfMeasurment
        {
            get { return _uom; }
            set { _uom = value; }
        }

        private int _qty;

        public int Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }


        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}




