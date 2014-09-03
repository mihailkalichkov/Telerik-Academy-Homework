using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.Common
{
    public class LoanAccount : Account
    {
        private decimal interestAmmount;

        public LoanAccount(decimal ammount, decimal interestRate, CustomerType type)
            : base(-ammount, interestRate, type)
        {
            if (ammount < 0)
            {
                throw new ArgumentException("Ammount cannot be negative!");
            }
        }

        public override decimal CalcInterest(DateTime date)
        {
            int months = MonthsBetweenDateAndOpeningDate(date);

            if (this.Type == CustomerType.Indidual)
            {
                if (months > 3)
                {
                    this.interestAmmount = months * this.InterestRate * -this.Balance / 100M;
                }
                else this.interestAmmount = 0;
            }
            else if (this.Type == CustomerType.Company)
            {
                if (months > 2)
                {
                    this.interestAmmount = months * this.InterestRate * -this.Balance / 100M;
                }
                else this.interestAmmount = 0;
            }

            return this.interestAmmount;
        }

        public override string ToString()
        {
            var account = new StringBuilder();
            account.AppendLine("Loan account details");
            account.AppendLine("--------------------");
            account.AppendFormat("Type: {0}", this.Type);
            account.AppendLine();
            account.AppendFormat("Opened on {0}, Balance: {1}, Interest rate: {2}%", this.OpeningDate, this.Balance, this.InterestRate);

            return account.ToString();
        }
    }
}