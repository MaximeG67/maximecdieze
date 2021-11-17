using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            string gestPath = path + @"\Gestionnaire.txt";
            string acctPath = path + @"\Comptes.txt";
            string trxnPath = path + @"\Transactions.txt";
            string sttsOpePath = path + @"\StatutOpe.txt";
            string sttsTrnPath = path + @"\StatutTrn.txt";
            string mtrlPath = path + @"\Metrologie.txt";

            List<Administrator> administrators = Global.ReadAdmin(gestPath);
            List<AccountLine> accounts = Global.ReadAccount(acctPath);

            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
