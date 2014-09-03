using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.Common
{
    public abstract class Account : IDepositable
    {
        private string customer;
        private CustomerType type;
        private DateTime openingDate;
        private decimal balance;
        private decimal interestRate; // monthly based in %

        public Account(decimal ammount, decimal interestRate, CustomerType type)
        {
            if (interestRate < 0 || interestRate > 100)
            {
                throw new ArgumentException("Incorrect interest entered!");
            }

            this.balance = ammount;
            this.interestRate = interestRate;
            string date = DateTime.Now.ToShortDateString();
            this.openingDate = DateTime.Parse(date);
            this.type = type;
        }

        protected internal CustomerType Type
        {
            get { return this.type; }
        }

        public string Customer
        {
            get
            {
                return this.customer;
            }
            internal set
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
            protected internal set
            {
                this.balance = value;
            }
        }

        public DateTime OpeningDate
        {
            get { return this.openingDate; }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Incorrect interest entered!");
                }
                this.interestRate = value;
            }
        }

        public void Deposit(decimal ammount)
        {
            if (ammount < 0)
            {
                throw new ArgumentException("Ammount cannot be negative!");
            }
            balance += ammount;
        }

        public abstract decimal CalcInterest(DateTime date);

        protected internal int MonthsBetweenDateAndOpeningDate(DateTime date)
        {
            int months = 0;
            if (date.Year == this.OpeningDate.Year)
            {
                if (date.Month < this.OpeningDate.Month)
                {
                    throw new ArgumentException("Invalid date for calculating interest!");
                }
                if (date.Day < this.OpeningDate.Day)
                {
                    throw new ArgumentException("Invalid date for calculating interest!");
                }
                months = date.Month - this.OpeningDate.Month;
                if (this.OpeningDate.AddMonths(months) > date)
                {
                    months--;
                }
            }
            else if (date.Year > this.OpeningDate.Year)
            {
                months = ((12 - this.OpeningDate.Month) + date.Month) + ((date.Year - this.OpeningDate.Year - 1) * 12);
                if (this.OpeningDate.AddMonths(months) > date)
                {
                    months--;
                }
            }
            else throw new ArgumentException("Invalid date for calculating interest!");

            return months;
        }

        public abstract override string ToString();
    }
}