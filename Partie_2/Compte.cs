using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte
{
    static class Compte
    {
        private static List<Compte> listeComptes = new List<Compte>();


        public static Compte createAccount(int id,DateTime date)
        {
            return createAccount(id,0,date)
        }

        public static Compte createAccount(int id, double total, DateTime date)
        {

        }
    }
}
