using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.Common
{
    public class DepositAccount : Account, IWithDrawable
    {
        private decimal interestAmmount;

        public DepositAccount(decimal ammount, decimal interestRate, CustomerType type)
            : base(ammount, interestRate, type)
        {
            if (ammount < 0)
            {
                throw new ArgumentException("Ammount cannot be negative!");
            }
        }

        public void WithDraw(decimal ammount)
        {
            if (ammount < 0)
            {
                throw new ArgumentException("Ammount cannot be negative!");
            }
            if (this.Balance < ammount)
            {
                throw new ArgumentException("Cannot withdraw more than the balance!");
            }
            this.Balance -= ammount;
        }

        public override decimal CalcInterest(DateTime date)
        {
            if (this.Balance > 1000)
            {
                int months = MonthsBetweenDateAndOpeningDate(date);

                return this.interestAmmount = months * this.InterestRate * this.Balance / 100M;
            }
            else return 0;
        }

        public override string ToString()
        {
            var account = new StringBuilder();
            account.AppendLine("Deposit account details");
            account.AppendLine("-----------------------");
            account.AppendFormat("Type: {0}", this.Type);
            account.AppendLine();
            account.AppendFormat("Opened on {0}, Balance: {1}, Interest rate: {2}%", this.OpeningDate, this.Balance, this.InterestRate);

            return account.ToString();
        }
    }
}