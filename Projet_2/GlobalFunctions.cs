using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Part_II
{
    static class GlobalFunctions
    {
        public static int StringToInt(string chaine)
        {
            int res;
            if (int.TryParse(chaine, out res))
                return res;
            return int.MinValue;
        }

        public static double StringToDouble(string chaine)
        {
            double res;
            chaine = chaine.Replace('.', ',');
            if (double.TryParse(chaine, out res))
                return res;
            return double.MinValue;
        }

        public static void WriteLogs(string texte)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\Logs.txt";
            using (TextWriter tw = new StreamWriter(path, true))
            {
                tw.WriteLine(texte);
            }
        }

        public static void ClearLogs()
        {
            string path = $@"{Directory.GetCurrentDirectory()}\Logs.txt";
            using (TextWriter tw = new StreamWriter(path, false))
            {
                tw.WriteLine($"Execution du {DateTime.Now}");
                tw.WriteLine("--------------------");
            }
        }
    }
}
