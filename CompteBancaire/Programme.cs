using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    internal class Programme
    {
        // méthode qui s'exécute au démarrage de l'application
        // doit contenir boucle Do While - Switch - Liste
        // s'assurer d'avoir sélectionné ce fichier dans la colonne FileTree avant de cliquer sur Run pour lancer l'application.
        public static void Main(string[] args) 
        {
            // instancier les objets compte, cheque et epargne
            Compte compte = new Compte(); // Création de notre client unique
            Cheque cheque = new Cheque(2000, "Courant"); // initialiser le compte courant  
            Epargne epargne = new Epargne(10000, "Epargne"); // initaliser le compte épargne

            Console.WriteLine("Bonjour, tapez sur la touche Entrée pour afficher le Menu");

            Console.ReadLine();

            Console.WriteLine("Veuillez sélectionner une option ci - dessous :");
            Console.WriteLine("[I] Voir les informations sur le titulaire du compte");
            Console.WriteLine("[CS] Compte courant - Consulter le solde");
            Console.WriteLine("[CD] Compte courant - Déposer des fonds");
            Console.WriteLine("[CR] Compte courant - Retirer des fonds");
            Console.WriteLine("[ES] Compte épargne - Consulter le solde");
            Console.WriteLine("[ED] Compte épargne - Déposer des fonds");
            Console.WriteLine("[ER] Compte épargne - Retirer des fonds");
            Console.WriteLine("[X] Quitter");
            
            string? saisie = Console.ReadLine();

            switch (saisie)
            {
                case "I":
                    // Voir les informations sur le titulaire du compte;
                    Console.WriteLine("Titulaire du compte : " + compte.prenom + " " + compte.nom);
                    break;
                case "CS":
                    // Compte courant - Consulter le solde;
                    break;
                case "CD":
                    // Compte courant - Déposer des fonds;
                    break;
                case "CR":
                    // Compte courant - Retirer des fonds;
                    break;
                case "ES":
                    // Compte épargne - Consulter le solde;
                    break;
                case "ED":
                    // Compte épargne - Déposer des fonds;
                    break;
                case "ER":
                    // Compte épargne - Retirer des fonds;
                    break;
                case "X":
                    // quitter;
                    break;
                default: // L'utilisateur a entré autre chose
                    Console.WriteLine("Merci de sélectionner une option parmi : I, CS, CD, CR, ES, ED, ER ou X");
                    break;
            }
        }
    }
}
