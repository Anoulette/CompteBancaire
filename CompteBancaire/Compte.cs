using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CompteBancaire
{
    class Compte
    // doit contenir le nom du titulaire du compte, le type de compte(c.-à-d.courant, épargne), et le solde.
    // Lorsque l'application démarre, ajoutez deux transactions pour le type de compte et le titulaire du compte.
    // Par exemple : `Compte courant Titulaire du compte : Prenom NomDeFamille `
    // Le prénom et le nom de famille doivent être votre nom dans le code.
    {
        public int solde;
        public string prenom = "Daphné";
        public string nom = "Croville";
        public string typeCompte;
    }


}
