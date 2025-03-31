using AppliMastermind.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliMastermind
{
    public class MasterMindUI
    {
        private MasterMind leJeu;

        public MasterMindUI(MasterMind unJeu)
        {
            this.leJeu = unJeu;
        }

        public void ClearConsole() // Supprime toutes les lignes de la console
        { Console.Clear(); }

        public string RequestPlayer() // retourne un string pour demander de saisir au joueur une combinaison
        { return ($"Veuillez saisir 5 caractère correspondant à {String.Join(", ", MasterMindSettings.couleurAutorise)}: "); }

        public string ErreurSaisi() // retourne un string pour demander de saisir au joueur une combinaison
        {
            return ($"Veuillez saisir 5 caractère correspondant à {String.Join(", ", MasterMindSettings.couleurAutorise)}: ");
        }

        public void GetTableau() // créé un tableau pour visualiser les essai facilement
        {
            Console.Write("+- Essai(s) -+- Bien(s) Placé(s) -+- Mal(s) Placé(s) -+");
            Console.Write("\n|            |                    |                   |");

            foreach (char[] unEssai in this.leJeu.GetEssais()) // parcours la liste des essais
            {
                Console.Write($"\n|   ");
                MasterMindUtils.WriteTextColor(new string(unEssai)); // écris en couleur dans la console
                Console.Write($"    |         {this.leJeu.GetBienPlace(unEssai)}          |         {this.leJeu.GetMalPlace(unEssai)}         |");
                //                              ^-- Retourne les biens placés                         ^-- retourne les mals placés

            }

            if (this.leJeu.GetEssais().Count > 0) // si il y a eu au moins 1 essai alors on ajoute ces lignes là dans la console
            {
                Console.Write("<-- Dernier essai.");
                Console.Write("\n|            |                    |                   |");
            }

            Console.Write("\n+------------+--------------------+-------------------+\n\n");
        }

        public string ScreenFinal()
        {
            int nbEssai = this.leJeu.GetEssais().Count; // recupère le nombre d'essai 
            string rep  = "";

            rep += ($"\nVous avez trouvé la bonne combinaison avec {nbEssai} essai(s)."); 

            if (nbEssai < 5)
                rep += (" Bravo !!!");
            else
            {
                if (nbEssai < 10)
                    rep += (" Correct");
                else
                    rep += (" Décevant");
            }

            return rep;
        }
    }
}
