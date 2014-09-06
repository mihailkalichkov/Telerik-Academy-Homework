namespace ATMDatabase.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using ATM.Model;

    public class ATMContext : DbContext
    {
        public ATMContext()
            : base("ATM")
        {

        }

        public DbSet<CardAccount> CardAccounts { get; set; }
        public DbSet<TransactionHistory> TransactionsHistory { get; set; }
    }
}