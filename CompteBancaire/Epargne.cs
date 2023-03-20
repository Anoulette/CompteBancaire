using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    class Epargne : Compte
    // La classe Epargne doit avoir un constructeur qui affecte un solde et un type de compte.
    // Fixez le solde initial à 10 000 €.
    {
        public Epargne(int solde, string type)
            : base(solde, type)
        {
        }
    }
}
