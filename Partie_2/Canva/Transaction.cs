using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_2.Canva
{
    class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int IdSender { get; set; }
        public int IdRecipient { get; set; }
        public Transaction(int id, decimal amount, int idSender, int idRecipient, DateTime date)
        {
            Id = id;
            Date = date;
            Amount = amount;
            IdSender = idSender;
            IdRecipient = idRecipient;
        }
    }
}
