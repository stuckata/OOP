using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_BankOfKurtovoKonare.Customers;
using _02_BankOfKurtovoKonare.Interfaces;

namespace _02_BankOfKurtovoKonare.Accounts
{
    abstract class Account : IInterest, IDeposit
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;
        private int periodInMonths;

        public Account(Customer customer, decimal balance, decimal interestRate, int periodInMonths)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.PeriodInMonths = periodInMonths;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }

        public int PeriodInMonths
        {
            get
            {
                return this.periodInMonths;
            }
            set
            {
                this.periodInMonths = value;
            }
        }

        public abstract decimal CalculateInterest();

        public decimal DepositMoney(decimal deposit)
        {
            return this.Balance += deposit; 
        }

        public override string ToString()
        {
            return String.Format("{0} | Balance: ${1} | Interest Rate: {2}% | Period in Months: {3}", 
                this.Customer, this.Balance, this.InterestRate * 100, this.PeriodInMonths);
        }
    }
}
