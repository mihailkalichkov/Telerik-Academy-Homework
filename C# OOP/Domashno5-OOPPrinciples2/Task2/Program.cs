using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bank.Common;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>()
            {
                new DepositAccount(1200,2.3M,CustomerType.Indidual),
                new DepositAccount(5000,0.25M,CustomerType.Company),
                new LoanAccount(10000,2.35M,CustomerType.Indidual),
                new LoanAccount(30000,3.3M,CustomerType.Company),
                new MortgageAccount(50500,5.5M,CustomerType.Indidual),
                new MortgageAccount(120000,5.36M,CustomerType.Company),
            };

            Console.WriteLine(accounts[0].ToString());
            Console.WriteLine();
            Console.WriteLine(accounts[3].ToString());
            Console.WriteLine();
            Console.WriteLine(accounts[4].ToString());
            Console.WriteLine();

            // operations with different types accounts
            /* Interest calculations:
             * if account is opened on 12 day of some month, than on 12 day on the next month
             * I assume 1 month has passed. If it is opened on 31 day and the next month is february
             * or month with 30 days I assume that the 1 month period closes on the last day of the
             * shorter month. Substitute entered dates to chech cases*/

            Console.ForegroundColor = ConsoleColor.Yellow;
            accounts[0].Deposit(100);
            Console.WriteLine("Balance: {0}", accounts[0].Balance);
            Console.WriteLine(accounts[0].CalcInterest(new DateTime(2015, 02, 02)));
            Console.WriteLine(accounts[0].CalcInterest(new DateTime(2014, 11, 22)));
            (accounts[0] as DepositAccount).WithDraw(1000);
            Console.WriteLine("Balance: {0}", accounts[0].Balance);
            Console.WriteLine(accounts[0].CalcInterest(new DateTime(2015, 02, 22)));
            Console.WriteLine(accounts[0].CalcInterest(new DateTime(2014, 11, 22)));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Balance: {0}", accounts[3].Balance);
            accounts[3].Deposit(120);
            Console.WriteLine("Balance: {0}", accounts[3].Balance);
            Console.WriteLine(accounts[3].CalcInterest(new DateTime(2015, 02, 22)));
            Console.WriteLine(accounts[2].CalcInterest(new DateTime(2014, 11, 22)));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Balance: {0}", accounts[4].Balance);
            accounts[4].Deposit(1200);
            Console.WriteLine("Balance: {0}", accounts[4].Balance);
            Console.WriteLine(accounts[4].CalcInterest(new DateTime(2015, 02, 22)));
            Console.WriteLine(accounts[5].CalcInterest(new DateTime(2014, 11, 22)));
            Console.WriteLine(accounts[4].CalcInterest(new DateTime(2015, 11, 22)));
            Console.WriteLine(accounts[5].CalcInterest(new DateTime(2016, 11, 22)));
            Console.ResetColor();
            Console.WriteLine();

            // create two types customers
            Customer individual = new Customer("Petar", "Ivanov", "7856412358", "123456789", "Sofia");
            Customer company = new Customer("Petrol AD", "987654321", VAT.Yes, "Petar Stojanov");

            Console.WriteLine(individual.ToString());
            Console.WriteLine();
            Console.WriteLine(company.ToString());
            Console.WriteLine();

            /* add accounts to customers */
            //individual.AddAccount(accounts[1]); //exception (adds company deposit account to individual)
            //company.AddAccount(accounts[0]); //exception (vice versa)
            individual.AddAccount(accounts[0]);
            individual.AddAccount(accounts[2]);
            individual.AddAccount(accounts[4]);

            company.AddAccount(accounts[1]);
            company.AddAccount(accounts[3]);
            company.AddAccount(accounts[5]);

            Console.WriteLine(individual.ToString());
            Console.WriteLine(company.ToString());
        }
    }
}