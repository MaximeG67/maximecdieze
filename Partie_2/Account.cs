using Partie_2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Partie_2
{
    public class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime ClosureDate { get; set; }

        public List<Transaction> transactions;

        public Account(int id, DateTime openDate, decimal balance, int enter, int exit)
        {
            Id = id;
            OpenDate = openDate;
            ClosureDate = DateTime.MinValue;
            Balance = balance;
            
        }
    }

}
