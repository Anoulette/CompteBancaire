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
        public int Solde { get; set; }
        public string Type { get; set; }
        public string prenom = "Daphné";
        public string nom = "Croville";

        public Compte(int solde, string type)
        {
            Solde = solde;
            Type = type;
        }

        internal void Deposer()
        {
            Console.WriteLine("Quel montant souhaitez-vous déposer ?");
            int.TryParse(Console.ReadLine(), out var montantADeposer);
            Console.WriteLine("Vous avez déposé : " + montantADeposer + " euros.");
            Solde += montantADeposer;
            Console.WriteLine("Transaction : " + montantADeposer + " euros le " + DateTime.Now.ToString("dd/MM/yyyy à HH:mm") + " - Solde actuel : " + Solde + " euros.");
            Console.WriteLine("Appuyez sur Entrée pour afficher le Menu");
        }

        internal void Retirer()
        {
            Console.WriteLine("Quel montant souhaitez-vous retirer ?");
            int.TryParse(Console.ReadLine(), out var montantARetirer);
            Console.WriteLine("Vous avez retiré : " + montantARetirer + " euros.");
            Solde -= montantARetirer;
            Console.WriteLine("Transaction : " + montantARetirer + " euros le " + DateTime.Now.ToString("dd/MM/yyyy à HH:mm") + " - Solde actuel : " + Solde + " euros.");
            Console.WriteLine("Appuyez sur Entrée pour afficher le Menu");
        }

        internal void ConsulterSolde()
        {
            Console.WriteLine("Solde du compte " + Type + " : " + Solde + " euros.");
            Console.WriteLine("Appuyez sur Entrée pour afficher le Menu");
        }
    }


}
