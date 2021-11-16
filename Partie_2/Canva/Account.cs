using Partie_2.Canva;
using System;
using System.Collections.Generic;
using System.Text;

namespace Partie_2
{ 
    class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public DateTime OpenDate { get; set; }
        public int Enter { get; set; }
        public int Exit { get; set; }

        public List<Transaction> transactions;
        
        public Account(int id,  DateTime openDate, decimal balance, int enter, int exit)
        {
            Id = id;
            Balance = balance;
            OpenDate = openDate;
            Enter = enter;
            Exit = exit;

            //MaxWithdrawal = maxWithdrawal;
            transactions = new List<Transaction>();
        }

        public void AddTransaction(Transaction transaction)
        {
            if (!transactions.Contains(transaction))
                transactions.Add(transaction);
        }

        public List<Transaction> getAllTransaction()
        {
            return transactions;
        }

    }
    
}
