using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_1
{
    public static class Ecriture
    {
        public static List<Compte> Readcpt(string accpPath)
        {
            List<Compte> comptes = new List<Compte>();
            Compte c = new Compte(0, 0);
            int convers;
            string[] lines = File.ReadAllLines(accpPath);

            foreach (string line in lines)
            {

                Console.WriteLine($"Fichier : {line}");
                string[] split = line.Split(';');
                for (int i = 0; i < split.Length; i++)
                {
                    Console.WriteLine($" Infos Split C : {split[i]}");
                    int.TryParse(split[0], out convers);
                    c.Numero = convers;
                    c.Solde = System.Convert.ToDecimal(split[1]);
                    comptes.Add(c);
                }
            }
            return comptes;
        }


        public static List<Transaction> ReadTrsc(string trxnPath)
        {
            List<Transaction> transactions = new List<Transaction>();
            Transaction t = new Transaction(0, 0, 0, 0);
            int convers;            
            string[] lines = File.ReadAllLines(trxnPath);           
            foreach (string line in lines)
            {
                Console.WriteLine($"Fichier : {line}");
                string[] split = line.Split(';');
                for (int i = 0; i < split.Length - 1; i++)
                {
                    Console.WriteLine($" Infos : {split[i]}");
                    int.TryParse(split[0], out convers);
                    t.Numero = convers;
                    t.Montant = System.Convert.ToDecimal(split[1]);
                    int.TryParse(split[0], out convers);
                    t.NumExp = convers;
                    int.TryParse(split[0], out convers);
                    t.NumDes = convers;
                    transactions.Add(t);
                }
            }
            return transactions;
        }

    }
}

