using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankOfKurtovoKonare.Customers
{
    class Company : Customer
    {
        public Company(string name)
            : base(name)
        {
        }

        public override string ToString()
        {
            return String.Format("Customer -- Company | {0}", base.ToString());
        }
    }
}
