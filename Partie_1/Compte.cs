using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_1
{
    public class Compte
    {
        public int Numero { get; set; }
        public decimal Solde { get; set; }
        public Compte(int numero, decimal solde)
        {
            Numero = numero;
            Solde = solde;
        }
        //public void Lecturecompte(string accpPath, string sttsPath)
        //{
        //    var comptes = new Dictionary<string, List<int>>();
        //    string[] lines = File.ReadAllLines(accpPath);
        //    foreach (string line in lines)
        //    {
        //        Console.WriteLine($"Fichier : {line}");
        //        string[] split = line.Split(';');
        //        for (int i = 0; i < split.Length; i++)
        //        {
        //            Console.WriteLine($"Infos s : {split[i]}");
        //        }
        //        string compte = split[1];

        //        if (!comptes.ContainsKey(compte))
        //        {
        //            comptes.Add(compte, new List<int>());
        //        }
        //    }
        //    File.WriteAllLines(sttsPath, comptes);
        //}
    }
}
