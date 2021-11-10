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
        public static void WriteFic(string input, string input1, string output)
        {
            //Dictionary<string, List<float>> dico = new Dictionary<string, List<float>>();
            string[] lines = System.IO.File.ReadAllLines(input);
            string[] lines1 = System.IO.File.ReadAllLines(input1);
            
            foreach (string line in lines1)
            {
                System.IO.File.WriteAllLines(output, lines1);
            }
        }
    }
}
