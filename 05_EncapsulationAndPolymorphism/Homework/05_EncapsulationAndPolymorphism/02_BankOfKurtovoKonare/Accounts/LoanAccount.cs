using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_BankOfKurtovoKonare.Customers;
using _02_BankOfKurtovoKonare.Interfaces;

namespace _02_BankOfKurtovoKonare.Accounts
{
    class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate, int periodInMonths)
            : base(customer, balance, interestRate, periodInMonths)
        {
        }

        public override decimal CalculateInterest()
        {
            if (this.Customer.GetType() == typeof(Company))
            {
                return this.Balance * (1 + this.InterestRate * (this.PeriodInMonths - 2));
            }
            return this.Balance * (1 + this.InterestRate * (this.PeriodInMonths - 3));
        }

        public override string ToString()
        {
            return String.Format("Loan Account | {0} | Calculated Interest: {1}", 
                base.ToString(), CalculateInterest());
        }
    }
}
