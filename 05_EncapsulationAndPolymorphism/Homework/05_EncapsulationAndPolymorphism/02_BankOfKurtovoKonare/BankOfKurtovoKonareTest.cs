using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_BankOfKurtovoKonare.Accounts;
using _02_BankOfKurtovoKonare.Customers;

namespace _02_BankOfKurtovoKonare
{
    class BankOfKurtovoKonareTest
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>()
            {
                new DepositAccount(new Company("The Grand Company"), 10000m, 0.01m, 18),
                new LoanAccount(new Person("Gosho Mosho"), 900m, 0.02m, 8),
                new MortgageAccount(new Person("Masha Misha"), 6000m, 0.03m, 24)
            };

            foreach (var account in accounts)
            {
                Console.WriteLine(account);
                Console.WriteLine("===============================================================================");
            }
        }
    }
}
