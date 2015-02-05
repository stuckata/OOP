using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankOfKurtovoKonare.Customers
{
    class Person : Customer
    {
        public Person(string name)
            : base(name)
        {
        }

        public override string ToString()
        {
            return String.Format("Customer -- Person | {0}", base.ToString());
        }
    }
}
