﻿using System;
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
            Cheque cheque = new Cheque(2000, "courant"); // initialiser le compte courant  
            Epargne epargne = new Epargne(10000, "épargne"); // initaliser le compte épargne
         
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
                        Console.WriteLine("Titulaire du compte : " + cheque.prenom + " " + cheque.nom);
                        Console.WriteLine("Appuyez sur Entrée pour afficher le Menu");
                        break;
                    case "CS":
                        // Compte courant - Consulter le solde;
                        cheque.ConsulterSolde();
                        break;
                    case "CD":
                        // Compte courant - Déposer des fonds;
                        cheque.Deposer();
                        break;
                    case "CR":
                        // Compte courant - Retirer des fonds;
                        cheque.Retirer();
                        break;
                    case "ES":
                        // Compte épargne - Consulter le solde;
                        epargne.ConsulterSolde();
                        break;
                    case "ED":
                        // Compte épargne - Déposer des fonds;
                        epargne.Deposer();
                        break;
                    case "ER":
                        // Compte épargne - Retirer des fonds;
                        epargne.Retirer();
                        break;
                    case "X":
                        // pour quitter le programme, créez 2 fichiers texte contenant toutes les transactions du compte courant et du compte épargne
                        Console.WriteLine("Merci, à bientôt !");
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
