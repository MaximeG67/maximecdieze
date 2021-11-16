using Part_II.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Part_II.Controllers
{
    static class GestionnaireController
    {
        private static List<Gestionnaire> _listeGestionnaires = new List<Gestionnaire>();

        /// <summary>
        /// Instancie et retourne un Gestionnaire
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Gestionnaire CreerGestionnaire(int id,string type)
        {
            if(trouverGestionnaire(id) == null)
            {
                if (type == Gestionnaire.typeEntreprise || type == Gestionnaire.typeParticulier)
                {
                    Gestionnaire gest = new Gestionnaire(id, type);
                    _listeGestionnaires.Add(gest);
                    return gest;
                }
                else
                {
                    GlobalFunctions.WriteLogs($"Gestionnaire {id} : le type {type} n'est pas valide");
                }
            }
            else
            {
                GlobalFunctions.WriteLogs($"Gestionnaire {id} : l'id est déjà attribué");
            }
            return null;
        }

        /// <summary>
        /// Retourne un gestionnaire parmi tous ceux instanciés 
        /// </summary>
        /// <param name="idGest"></param>
        /// <returns></returns>
        public static Gestionnaire trouverGestionnaire(int idGest)
        {
            return _listeGestionnaires.Find(gest => gest.Id == idGest);
        }

        /// <summary>
        /// Vérifie si un compte est attribué à un gestionnaire
        /// </summary>
        /// <param name="gest"></param>
        /// <param name="cpt"></param>
        /// <returns></returns>
        public static bool EstAttribue(Gestionnaire gest,Compte cpt)
        {
            return gest.getListeCompte().Find(cp=>cp.Id==cpt.Id) != null;
        }

        /// <summary>
        /// Attribue un compte à un gestionnaire
        /// </summary>
        /// <param name="gest"></param>
        /// <param name="cpt"></param>
        public static void attribuerCompte(Gestionnaire gest, Compte cpt)
        {
            if (!EstAttribue(gest, cpt))
                gest.AjouterCompte(cpt);
        }


    }
}
