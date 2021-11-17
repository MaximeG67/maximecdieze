using Partie_2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Partie_2
{ 
    public class AccountLine
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Balance { get; set; }
        public int Input { get; set; }
        public int Output { get; set; }
        
        public AccountLine(int id,  DateTime openDate, decimal balance, int enter, int exit)
        {
            Id = id;
            Date = openDate;
            Balance = balance;
            Input = enter;
            Output = exit;
        }
    }
    
}
