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
        }
    }

