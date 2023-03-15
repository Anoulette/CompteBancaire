using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    class Epargne
    // La classe Epargne doit avoir un constructeur qui affecte un solde et un type de compte.
    // Fixez le solde initial à 10 000 €.
    {
        public Epargne(int solde, string typeCompte)
        {
            TypeCompte = typeCompte;
            Solde = solde;
        }

        public string TypeCompte { get; set; }
        public int Solde { get; set; }
    }
}
