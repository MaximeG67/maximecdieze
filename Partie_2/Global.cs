using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_2.Canva
{
    public static class Global
    {
        public static List<Account> ReadAccount(string accpPath)
        {
            List<Account> account = new List<Account>();
            string[] lines = File.ReadAllLines(accpPath);
            foreach (string line in lines)
            {
                int id;
                DateTime date;
                decimal balance;
                int enter;
                int exit;

                string[] split = line.Split(';');
                id = int.Parse(split[0]);
                date = DateTime.Parse(split[1]);
                if (string.IsNullOrWhiteSpace(split[3]))
                {
                    enter = 0;
                }
                else
                {
                    enter = int.Parse(split[3]);
                }

                if (string.IsNullOrWhiteSpace(split[4]))
                {
                    exit = 0;
                }
                else
                {
                    exit = int.Parse(split[4]);
                }

                if (string.IsNullOrWhiteSpace(split[2]))
                {
                    balance = 0;
                }
                else
                {
                    balance = decimal.Parse(split[2].Replace(".", ","));
                }

                if (id != 0 && !Administrator.accountExist(id,account))
                {
                    Account c = new Account(id, date, balance , enter, exit);
                    account.Add(c);
                }
            }
            return account;
        }
    }
}
