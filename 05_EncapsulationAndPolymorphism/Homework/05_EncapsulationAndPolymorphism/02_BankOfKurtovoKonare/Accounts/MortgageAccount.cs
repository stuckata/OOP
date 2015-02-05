using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_BankOfKurtovoKonare.Customers;
using _02_BankOfKurtovoKonare.Interfaces;

namespace _02_BankOfKurtovoKonare.Accounts
{
    class MortgageAccount : Account
    {
        private const int COMPANY_PROMO_PERIOD = 12;
        private const int PERSON_PROMO_PERIOD = 6;

        public MortgageAccount(Customer customer, decimal balance, decimal interestRate, int periodInMonths)
            : base(customer, balance, interestRate, periodInMonths)
        {
        }

        public override decimal CalculateInterest()
        {
            if (this.Customer.GetType() == typeof(Company))
            {
                decimal promoInterestCompany = this.Balance * (1 + (this.InterestRate / 2) * COMPANY_PROMO_PERIOD);

                if (this.PeriodInMonths <= COMPANY_PROMO_PERIOD)
                {
                    return promoInterestCompany;
                }

                return promoInterestCompany + this.Balance * 
                    (1 + this.InterestRate * (this.PeriodInMonths - COMPANY_PROMO_PERIOD));
            }

            decimal promoInterestPerson = this.Balance * (1 + (this.InterestRate / 2) * PERSON_PROMO_PERIOD);

            if (this.PeriodInMonths <= PERSON_PROMO_PERIOD)
            {
                return promoInterestPerson;
            }

            return promoInterestPerson + this.Balance *
                (1 + this.InterestRate * (this.PeriodInMonths - PERSON_PROMO_PERIOD));
        }

        public override string ToString()
        {
            return String.Format("Mortgage Account | {0} | Calculated Interest: {1}", 
                base.ToString(), CalculateInterest());
        }
    }
}
