using Projet_1;
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
        public static List<Compte> Readcpt(string accpPath)
        {
            List<Compte> comptes = new List<Compte>();
            string[] lines = File.ReadAllLines(accpPath);

            foreach (string line in lines)
            {
                Compte c = new Compte(0, 0);
                string[] split = line.Split(';');
                c.Numero = int.Parse(split[0]);

                if (string.IsNullOrWhiteSpace(split[1]))
                {
                    c.Solde = 0;
                    Console.WriteLine($"Initialisation du solde du compte {c.Numero} à {c.Solde}  euros");
                }
                else
                {
                    c.Solde = decimal.Parse(split[1].Replace(".", ","));
                    Console.WriteLine($"Solde du compte {c.Numero} à {c.Solde} euros");
                }
                if (c.Solde >= 0 && !comptes.Any(x => x.Numero == c.Numero))
                {
                    comptes.Add(c);
                    Console.WriteLine($"Ajout du compte {c.Numero} avec {c.Solde} euros");
                    Console.WriteLine($"--------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine($"Le solde du compte {c.Numero} est négatif, création impossible");
                    Console.WriteLine($"--------------------------------------------------------------");
                }
            }
            return comptes;
        }



        public static List<Transaction> ReadTrsc(string trxnPath)
        {
            List<Transaction> transactions = new List<Transaction>();
            string[] lines = File.ReadAllLines(trxnPath);
            foreach (string line in lines)
            {
                Transaction t = new Transaction(0, 0, 0, 0);
                string[] split = line.Split(';');
                t.Numero = int.Parse(split[0]);
                if (string.IsNullOrWhiteSpace(split[1]))
                {
                    t.Montant = 0;
                }
                else
                {
                    t.Montant = decimal.Parse(split[1].Replace(".", ","));
                }
                t.NumExp = int.Parse(split[2]);
                t.NumDes = int.Parse(split[3]);
                transactions.Add(t);
            }

            return transactions;
        }
        public static List<Statut> ManageTransaction(List<Transaction> transactions, List<Compte> comptes)
        {
            int i = 0;
            int e = 0;
            List<Statut> statuts = new List<Statut>();
            //List<int> trnsNbr = new List<int>();
            foreach (var transac in transactions)
            {
                Statut statut = new Statut(transac.Numero, "KO");
                Compte compteExpediteur;
                Compte compteDestinataire;
                if (!statuts.Any(stt => stt.Numero == transac.Numero))
                {
                    // DEPOT
                    if (transac.NumExp == 0 && transac.NumDes != 0)
                    {
                        compteDestinataire = comptes.Find(cpt => cpt.Numero == transac.NumDes);
                        if (compteDestinataire != null)
                        {
                            if (transac.Montant > 0)
                            {
                                compteDestinataire.Solde += transac.Montant;
                                statut.Etat = "OK";
                                i++;
                            }
                        }
                    }
                    // RETRAIT
                    else if (transac.NumDes == 0 && transac.NumExp != 0)
                    {
                        compteExpediteur = comptes.Find(cpt => cpt.Numero == transac.NumExp);
                        if (compteExpediteur != null)
                        {
                            if (transac.Montant >= 0)
                            {
                                if (compteExpediteur.Solde >= transac.Montant)
                                {
                                    compteExpediteur.Solde += transac.Montant;
                                    statut.Etat = "OK";
                                    i++;
                                }
                            }
                        }
                    }
                    //VIREMENT
                    else if (transac.NumExp != 0 && transac.NumDes != 0)
                    {
                        compteExpediteur = comptes.Find(cpt => cpt.Numero == transac.NumExp);
                        compteDestinataire = comptes.Find(cpt => cpt.Numero == transac.NumDes);
                        if (compteDestinataire != null && compteExpediteur != null)
                        {
                            if (transac.Montant > 0)
                            {
                                if (compteExpediteur.Solde >= transac.Montant)
                                {
                                    compteExpediteur.Solde -= transac.Montant;
                                    compteDestinataire.Solde += transac.Montant;
                                    statut.Etat = "OK";
                                    i++;
                                }
                            }
                        }
                    }
                } e++;
                //trnsNbr.Add(transac.Numero);
                statuts.Add(statut);
            }
            Console.WriteLine($"Nombre de comptes ajoutés avec succès : {i}");
            Console.WriteLine($"Nombre de comptes non ajoutés         : {e-i}");
            return statuts;

        }
    }
}



