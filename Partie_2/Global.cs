using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_2
{
    public static class Global
    {
        public static List<AccountLine> ReadAccount(string accpPath)
        {
            List<AccountLine> account = new List<AccountLine>();
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

                if (id != 0 && !Administrator.accountExist(id, account) && balance > 0)
                {

                    AccountLine c = new AccountLine(id, date, balance, enter, exit);
                    account.Add(c);
                    Console.WriteLine($"Compte numéro {id} ajouté avec succès ; Solde à {balance}");
                }
            }
            return account;
        }
        //public static List<Transaction> Compare(string trxnPath)
        //{
        //    List<Transaction> account = new List<Transaction>();
        //    string[] lines = File.ReadAllLines(trxnPath);
        //    foreach (string line in lines)
        //    {
        //        int id = ;
        //        int dateOp = ;
        //        int 
        //    }
        //}

        public static List<Administrator> ReadAdmin(string path)
        {
            List<Administrator> admin = new List<Administrator>();
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                int id;
                string type;
                int nbAdmin;
                string[] split = line.Split(';');
                id = int.Parse(split[0]);
                type = split[1];
                nbAdmin = int.Parse(split[2]);
                if (type == Administrator.TypeEntr)
                {
                    Console.WriteLine($"Ceci est un compte Entreprise avec {nbAdmin} transactions");
                }
                else if (type == Administrator.TypePart)
                {
                    Console.WriteLine($"Ceci est un compte Particulier avec {nbAdmin} transactions");
                }
                else Console.WriteLine($"Paramètre(s) invalide(s) pour le compte {id}");

            }
            return admin;
        }
        public static List<Transaction> ReadTransaction(string trxnPath)
        {
            List<Transaction> transac = new List<Transaction>();
            string[] lines = File.ReadAllLines(trxnPath);
            foreach (string line in lines)
            {
                int id;
                DateTime Date;
                decimal Amount;
                int IdSender;
                int IdRecipient;
                string[] split = line.Split(';');
                id = int.Parse(split[0]);
                Date = DateTime.Parse(split[1]);
            }
            return transac;
        }
        public static void Compare(List<Transaction> trnsac, List<AccountLine> acct)
        {
            int last = 0;
            for (int i = 0; i < acct.Count; i++)
            {
                for (int j = last; j < trnsac.Count; j++)
                {
                    if (trnsac[j].Date < acct[i].Date)
                    {
                        // Traiter Transaction
                    }
                    else
                    {
                        break;
                    }
                    Console.WriteLine($"Compte {trnsac[j].Id} et {trnsac[i].Id} ");
                    last = j + 1;
                }
                //Traiter ligne Compte
                if (true)
                {

                }

            }
        }
    }

}
