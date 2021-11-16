using Part_II.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Part_II.Controllers
{
    static class CompteController
    {
        private static List<Compte> _listeComptes = new List<Compte>();

        public static Compte CreerCompte(int id,DateTime date)
        {
            return CreerCompte(id, 0,date);
        }
        public static Compte CreerCompte(int id, double somme, DateTime date)
        {
            if(trouverCompte(id) == null)
            {
                Compte cpt = new Compte(id, somme, date);
                _listeComptes.Add(cpt);
                return cpt;
            }
            else
            {
                GlobalFunctions.WriteLogs($"Compte {id} : l'id est déjà attribué");
                return null;
            }
        }

        public static Compte trouverCompte(int idCompte)
        {
            return _listeComptes.Find(cpt => cpt.Id == idCompte);
        }


    }
}
