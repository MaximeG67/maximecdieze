using System;
using System.Collections.Generic;
using System.Text;

namespace Part_II.Models
{
    class Gestionnaire
    {
        public const string typeParticulier = "Particulier";
        public const string typeEntreprise = "Entreprise";

        public int Id { get; private set; }
        public string Type { get; private set; }
        private List<Compte> _listeComptes;
        
        public Gestionnaire(int id,string type)
        {
            Id = id;
            Type = type;
            _listeComptes = new List<Compte>();
        }

        public void AjouterCompte(Compte cpt) {
            if(!_listeComptes.Contains(cpt))
                _listeComptes.Add(cpt);
        }

        public List<Compte> getListeCompte()
        {
            return _listeComptes;
        }
    }
}
