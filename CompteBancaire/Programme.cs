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


        // fonction qui affiche le menu
        public static void AfficherMenu()
        {
            Console.WriteLine("Veuillez sélectionner une option ci - dessous :");
            Console.WriteLine("[I] Voir les informations sur le titulaire du compte");
            Console.WriteLine("[CS] Compte courant - Consulter le solde");
            Console.WriteLine("[CD] Compte courant - Déposer des fonds");
            Console.WriteLine("[CR] Compte courant - Retirer des fonds");
            Console.WriteLine("[ES] Compte épargne - Consulter le solde");
            Console.WriteLine("[ED] Compte épargne - Déposer des fonds");
            Console.WriteLine("[ER] Compte épargne - Retirer des fonds");
            Console.WriteLine("[X] Quitter");
        }

        public static void Main(string[] args) 
        {
            // instancier les objets compte, cheque et epargne
            Compte compte = new Compte(); // Création de notre client unique
            Cheque cheque = new Cheque(2000, "Courant"); // initialiser le compte courant  
            Epargne epargne = new Epargne(10000, "Epargne"); // initaliser le compte épargne
         
            Console.WriteLine("Bonjour, tapez sur la touche Entrée pour afficher le Menu");

            Console.ReadLine();

            string? saisie ="";

            // boucle : tant que saisie != X = revenir ici, sinon sortir
            while (saisie != "X")
            {
                AfficherMenu();

                saisie = Console.ReadLine();

                switch (saisie?.ToUpper())
                {
                    case "I":
                        // Voir les informations sur le titulaire du compte;
                        Console.WriteLine("Titulaire du compte : " + compte.prenom + " " + compte.nom);
                        break;
                    case "CS":
                        // Compte courant - Consulter le solde;
                        Console.WriteLine("Solde du compte courant : " + cheque.Solde + " euros.");
                        Console.WriteLine("Appuyez sur Entrée pour afficher le Menu");
                        break;
                    case "CD":
                        // Compte courant - Déposer des fonds;
                        Console.WriteLine("Quel montant souhaitez-vous déposer ?");
                        int.TryParse(Console.ReadLine(), out var montantADeposer);
                        Console.WriteLine("Vous avez déposé : " + montantADeposer + " euros.");
                        cheque.Solde += montantADeposer;
                        Console.WriteLine("Solde actuel :" + cheque.Solde + " euros.");
                        Console.WriteLine("Appuyez sur Entrée pour afficher le Menu");
                        break;
                    case "CR":
                        // Compte courant - Retirer des fonds;
                        Console.WriteLine("Quel montant souhaitez-vous retirer ?");
                        int.TryParse(Console.ReadLine(), out var montantARetirer);
                        Console.WriteLine("Vous avez retiré : " + montantARetirer + " euros.");
                        cheque.Solde -= montantARetirer;
                        Console.WriteLine("Solde actuel :" + cheque.Solde + " euros.");
                        Console.WriteLine("Appuyez sur Entrée pour afficher le Menu");
                        break;
                    case "ES":
                        // Compte épargne - Consulter le solde;
                        Console.WriteLine("Solde du compte épargne : " + epargne.Solde + " euros.");
                        Console.WriteLine("Appuyez sur Entrée pour afficher le Menu");
                        break;
                    case "ED":
                        // Compte épargne - Déposer des fonds;
                        Console.WriteLine("Quel montant souhaitez-vous déposer ?");
                        int.TryParse(Console.ReadLine(), out montantADeposer);
                        Console.WriteLine("Vous avez déposé : " + montantADeposer + " euros.");
                        epargne.Solde += montantADeposer;
                        Console.WriteLine("Solde actuel :" + epargne.Solde + " euros.");
                        Console.WriteLine("Appuyez sur Entrée pour afficher le Menu");
                        break;
                    case "ER":
                        // Compte épargne - Retirer des fonds;
                        Console.WriteLine("Quel montant souhaitez-vous retirer ?");
                        int.TryParse(Console.ReadLine(), out montantARetirer);
                        Console.WriteLine("Vous avez retiré : " + montantARetirer + " euros.");
                        epargne.Solde -= montantARetirer;
                        Console.WriteLine("Solde actuel :" + epargne.Solde + " euros.");
                        Console.WriteLine("Appuyez sur Entrée pour afficher le Menu");
                        break;
                    case "X":
                        // quitter;
                        break;
                    default: // L'utilisateur a entré autre chose
                        Console.WriteLine("Merci de sélectionner une option parmi : I, CS, CD, CR, ES, ED, ER ou X");
                        AfficherMenu();
                        break;
                }
                Console.ReadLine();
            }
            // fin boucle
            
        }
    }
}
