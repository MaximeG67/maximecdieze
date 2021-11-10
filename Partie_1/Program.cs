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
            string input = path + @"\Comptes_1.txt";
            string input1 = path + @"\Transactions_1.txt";
            string output = path + @"\Statut_1.txt";

            Ecriture.WriteFic(input,input1, output);

            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
