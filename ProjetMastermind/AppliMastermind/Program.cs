using AppliMastermind.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliMastermind
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //--- Déclarations ---
            /*short[] combinaison = new short[5];	// Tableau contenant la combinaison de 5 couleurs à trouver
            short[] copie = new short[5];       // Tableau contenant la copie du tableau combinaison
            short[] essai = new short[5]; 	    // Tableau contenant chacun des essais
            int i,   			                // Indice de parcours des tableaux
            nbEssai,                            // Compteur d'essais avant de trouver la formule
            bp,            	                    // Compteur de bien placés
            mp;            	                    // Compteur de mal placés


            //--- Saisie de la combinaison à trouver ---
            Console.WriteLine("1er joueur : ");
            string saisie = Console.ReadLine();
            short[] tempo = new short[5];
            while((tempo = Program.ToShortArray(saisie.ToCharArray())).Length != 5)
            {
                Console.Write("Veuillez saisir 5 caractères ! >");
                saisie = Console.ReadLine();
            }

            for (i = 0; i < 5; i++)
                combinaison[i] = tempo[i];  // Pour saisir un caractère + ENTREE

            nbEssai = 0;
            Console.Clear();
            Console.WriteLine("2eme joueur :");

            //--- Proposition d'une combinaison tant que les 5 couleurs n'ont pas été bien placées ---
            do
            {
                nbEssai++;

                //--- Saisie de l'essai
                Console.WriteLine("essai : " + nbEssai);
                saisie = Console.ReadLine();

                while ((tempo = Program.ToShortArray(saisie.ToCharArray())).Length != 5)
                {
                    Console.Write("Veuillez saisir 5 caractères ! >");
                    saisie = Console.ReadLine();
                }
                for (i = 0; i < 5; i++)
                {
                    essai[i] = tempo[i];
                    copie[i] = combinaison[i];
                }

                //--- Calcul des bien placés ---
                bp = 0;
                mp = 0;

                for (i = 0; i < 5; i++)
                {
                    if (copie[i] == essai[i])
                    {
                        bp++;
                        copie[i] = -1;
                        essai[i] = -2;
                    } else if (EstContenu(copie, essai[i]))
                    {
                        mp++;
                        essai[i] = -2;
                    }
                }


                //--- Affichage du résultat ---
                Console.WriteLine("Bien places : " + bp.ToString());
                Console.WriteLine("Mal  places : " + mp.ToString());
            }
            while (bp < 5);

            //--- Affichage final ---
            Console.Write("\n\nVous avez trouve en " + nbEssai + " essais... ");
            if (nbEssai < 5)
                Console.WriteLine(" Bravo !!!");
            else
            {
                if (nbEssai < 10)
                    Console.WriteLine(" Correct");
                else
                    Console.WriteLine(" Décevant");
            }*/

            /*
             * 
             * Dans le jeu, ont utilise le type 'short' car la combinaison saisie est de 0 à 9 donc ont prend un type entier, et les nombres de 0 à 9 pouvant êtres encodé sur 4 bits minimum
             * alors ont utilise 'short' qui est un type d'entiers encodé sur 16 bits, ceci permet d'éviter la surcharge mémoire.
             * 
             */

            new MasterMind(); // Lance le jeu
            Console.ReadLine();
        }
    }
}
