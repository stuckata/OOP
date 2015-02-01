using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CompanyHierarchy.Interfaces;
using _04_CompanyHierarchy.Enumerations;
using _04_CompanyHierarchy.Models;

namespace _04_CompanyHierarchy.Models
{
    class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;

        public Customer(string id, string firstName, string lastName, decimal netPurchaseAmount)
            : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get
            {
                return this.netPurchaseAmount;
            }
            set
            {
                this.netPurchaseAmount = value;
            }
        }
    }
}
