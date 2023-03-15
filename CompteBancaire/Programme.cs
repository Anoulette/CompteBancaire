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
            Cheque cheque = new Cheque(); // Compte courant  
            Epargne epargne = new Epargne(); // Compte épargne

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


        }
    }
}
