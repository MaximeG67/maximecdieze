using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_1
{
    public class Transaction 
    {
        public int Numero { get; set; }
        public decimal Montant { get; set; }
        public int NumExp { get; set; }
        public int NumDes { get; set; }

        public Transaction(int numero, decimal montant, int numexp, int numdes)
        {
            Numero = numero;
            Montant = montant;
            NumExp = numexp;
            NumDes = numdes;
        }
        //public void ReadTrsc(string trxnPath, string sttsPath)
        //{
        //    var transactions = new Dictionary<string, List<int>>();
        //    string[] lines = File.ReadAllLines(trxnPath);
        //    foreach (string line in lines)
        //    {
        //        Console.WriteLine($"Fichier : {line}");
        //        string[] split = line.Split(';');
        //        for (int i = 0; i < split.Length; i++)
        //        {
        //            Console.Write($" Infos : {split[i]}");
        //        }
        //        string transaction = split[1];

        //        if (!transactions.ContainsKey(transaction))
        //        {
        //            transactions.Add(transaction, new List<int>());
        //        }
        //    }
            //File.WriteAllLines(sttsPath, Transaction);
        }
    }
}
