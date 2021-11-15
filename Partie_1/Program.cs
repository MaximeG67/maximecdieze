using Projet_1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            string acctPath = path + @"\Comptes_1.txt";
            string trxnPath = path + @"\Transactions_1.txt";
            string sttsPath = path + @"\Statut_1.txt";


            List<Compte> cpt = Ecriture.Readcpt(acctPath);
            List<Transaction> trans = Ecriture.ReadTrsc(trxnPath);
            List<Statut> stt = Ecriture.ManageTransaction(trans, cpt);
            
            using (StreamWriter sw = new StreamWriter(sttsPath))
            {
                foreach (var lambs in stt)
                {
                    sw.WriteLine($"{lambs.Numero};{lambs.Etat}");
                }
            }

            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
