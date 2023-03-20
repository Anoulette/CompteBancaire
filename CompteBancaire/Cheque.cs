using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    class Cheque : Compte
    // La classe Cheque doit avoir un constructeur qui attribue un solde et un type de compte.
    // Définissez le solde initial à 2 000 €.
    {
        public Cheque(int solde, string type)
            : base(solde, type)
        {
        }
    }
}
