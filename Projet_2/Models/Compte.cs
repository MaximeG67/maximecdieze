using System;
using System.Collections.Generic;
using System.Text;

namespace Part_II.Models
{
    class Compte
    {
        public int Id { get; private set; }
        public double Solde { get; private set; }
        public double MaxRetrait { get; private set; }
        public DateTime DateOuv { get; private set; }
        public DateTime DateFerm { get; private set; }
        public Gestionnaire Proprietaire { get; private set; }
        private List<Transaction> _transactions;

        public Compte(int id, double solde, DateTime dateOuv)
        {
            Id = id;
            Solde = solde;
            MaxRetrait = 2000;
            DateOuv = dateOuv;
            DateFerm = DateTime.MinValue;
            _transactions = new List<Transaction>();
        }

        public void setProprio(Gestionnaire gest)
        {
            Proprietaire = gest;
        }

        public void setSolde(double solde)
        {
            Solde = solde;
        }

        public void AddTransaction(Transaction transaction)
        {
            if (!_transactions.Contains(transaction))
                _transactions.Add(transaction);
        }

        public List<Transaction> getListeTransaction()
        {
            return _transactions;
        }
    }
}
