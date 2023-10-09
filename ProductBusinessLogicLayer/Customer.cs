using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Customer
    {
        private int _Custid;

        public int Custid
        {
            get { return _Custid; }
            set { _Custid = value; }
        }

        private string _custname;

        public string Custname
        {
            get { return _custname; }
            set { _custname = value; }
        }
    }
}







