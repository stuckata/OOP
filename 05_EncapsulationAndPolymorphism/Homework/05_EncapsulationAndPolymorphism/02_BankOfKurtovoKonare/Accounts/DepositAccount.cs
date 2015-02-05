using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_BankOfKurtovoKonare.Customers;
using _02_BankOfKurtovoKonare.Interfaces;

namespace _02_BankOfKurtovoKonare.Accounts
{
    class DepositAccount : Account, IWithdraw
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate, int periodInMonths)
            : base(customer, balance, interestRate, periodInMonths)
        {
        }

        public decimal WithdrawMoney(decimal withdraw)
        {
            return this.Balance -= withdraw;
        }

        public override decimal CalculateInterest()
        {
            if (this.Balance >= 0 && this.Balance < 1000)
            {
                return 0;
            }
            return this.Balance * (1 + this.InterestRate * this.PeriodInMonths);
        }

        public override string ToString()
        {
            return String.Format("Deposit Account | {0} | Calculated Interest: {1}", 
                base.ToString(), CalculateInterest());
        }
    }
}
