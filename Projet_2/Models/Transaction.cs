using System;
using System.Collections.Generic;
using System.Text;

namespace Part_II.Models
{
    class Transaction
    {
        public int Id { get; private set; }
        public double Montant { get; private set; }
        public int IdExpediteur { get; private set; }
        public int IdDestinataire { get; private set; }
        public DateTime Date { get; private set; }

        public Transaction(int id, double montant, int idExpediteur, int idDestinataire,DateTime date)
        {
            Id = id;
            Montant = montant;
            IdExpediteur = idExpediteur;
            IdDestinataire = idDestinataire;
            Date = date;
        }
    }
}
