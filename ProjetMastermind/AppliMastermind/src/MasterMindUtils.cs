using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace AppliMastermind.src
{
    public class MasterMindUtils
    {
        /*public static char[] TocharArray(char[] tab)                                                      // convertie un tableau de type 'char' en tableau 'char'
        {
            char[] chars = new char[tab.Length];                                                         // initialisation du tableau de la meme taille que le tableau 'tab'
            for (int i = 0; i < tab.Length; i++)                                                            // parcours du tableau de type 'char'
            {
                char c = tab[i];                                                                            // recuperation du caractère a la position 'i' dans le tableau 'tab'
                if (c >= '0' && c <= '9')                                                                   // verification si le numéro ascii caractère soit compris entre '0' à '9'
                    chars[i] = char.Parse(c.ToString());                                                  // ajout dans le tableau char
                else
                    throw new ArgumentException($"'{c.ToString()}' is not a number please try again !");    // execution d'erreur avec un message pour dire que le caractère n'est pas un nombre
            }

            return chars;                                                                                  // retourne le tableau si tout c'est bien passé
        }

        public static string ConvertArraycharToString(char[] leTableau)   // convertie un tableau de type 'char' en string
        {
            string rep = "";
            foreach (char leNumero in leTableau)                           // parcours du tableau pour la convertion
            {
                rep += leNumero.ToString();                                 // convertie l'entier et incremente dans la variable 'rep'
            }
            return rep;
        }*/

        public static int EstContenu(char[] tab, char value)  // recherche dand le tableau si la valeur est contenu et retourne -1 si elle n'apparait pas ou la position si elle apparait
        {
            int i = 0;
            while(i < tab.Length)                               // parcours le tableau
            {
                if (tab[i] == value)                            // si la valeur et identique à la valeur en position 'i' dans le tableau alors on retourne la position
                    return i;                                   // sinon ont continue a rechercher
                i++;
            }

            return -1;                                          // si aucune valeur trouver alors on retourne -1 ce qui signifit que la valeur n'est pas contenu
        }

        public static bool EstDesInitialDeCouleur(char[] lesCaracteres)                 // retourne vrai si un/les caractère(s) ne sont pas contenu dans la liste des caractères valide 
        {
            int i = 0;
            while(i < lesCaracteres.Length)                                             // parcours du tableau
            {
                if (!MasterMindSettings.couleurAutorise.Contains(lesCaracteres[i]))     // si il n'est pas contenu alors..
                    return true;                                                        // ont retourne vrai
                i++;
            }
            return false;
        }

        public static char[] GetSaisie()                                                                                        // retourne la saisie de l'utilisateur
        {
            string saisie = Console.ReadLine().ToUpper();                                                                       // recupère la saisie est la met en UpperCase (Majuscule)
            char[] tempo;                                                                                                       
            while ((tempo = saisie.ToCharArray()).Length != 5 || MasterMindUtils.EstDesInitialDeCouleur(saisie.ToCharArray()))  // tant que la saisie ne fait pas une longueur de 5 caractères ou que les caractère ne font pas partie de la liste des caractères autorisé, alors..
            {
                Console.Write("Veuillez saisir 5 caractères ! >");
                saisie = Console.ReadLine().ToUpper();
            }
            return tempo;
        }

        public static Tuple<int, int> GetInfoEssai(char[] laCombinaison, char[] unEssai)     // retourne une tuple de deux valuer entiers (bien placé, mal placé)
        {
            //--- Calcul des biens/mals placés ---
            int posContenu = 0, i, bp = 0, mp = 0;
            char[] copie = new char[5];
            char[] tempo = new char[5];
            for (i = 0; i < 5; i++)
            {
                copie[i] = laCombinaison[i];                                                 // copie des caractères pour éviter d'accèder à l'espace mémoire des variable combinaison et essai
                tempo[i] = unEssai[i];
            }

            for (i = 0; i < 5; i++)
            {
                if (copie[i] == tempo[i])                                                   // calcul des bien placé en fonction de la position de i
                {
                    bp++;
                    copie[i] = 'Y';
                    tempo[i] = 'X';
                }
                else if ((posContenu = MasterMindUtils.EstContenu(copie, tempo[i])) != -1)  // sinon calcule des mal placé en fonction de la position de i
                {
                    mp++;
                    copie[posContenu] = 'Y';
                    tempo[i] = 'X';
                }
            }
            return Tuple.Create(bp, mp);                                                    // créé la tuple avec les valeur
        }

        public static void WriteTextColor(string text)                                                                                          // écris en couleur dans la console
        {
            Console.ResetColor();                                                                                                               // met par défaut les couleur d'arrère et d'avant plan
            foreach (char c in text)
            {
                if(MasterMindSettings.couleurAutorise.Contains(c))                                                                              // regarde si le caractère actuelle se trouve dans la liste des caractères de couleur
                {
                    Console.ForegroundColor = MasterMindSettings.couleurForground[MasterMindSettings.couleurAutorise.FindIndex(a => a == c)];   // recherche l'index du caractère d'initiale de la couleur pour recuperer sa couleur 'ConsoleColor.', pour le premier plan
                    Console.BackgroundColor = MasterMindSettings.couleurBackground[MasterMindSettings.couleurAutorise.FindIndex(a => a == c)];  // pour l'arrière plan
                    Console.Write(c);                                                                                                           // écris le caractère
                    Console.ResetColor();                                                                                                       // remet par défaut les couleurs de la console
                } else
                    Console.Write(c);                                                                                                           // si le caractère n'est pas trouvé alors cela l'écris juste sans couleur
            }
        }
    }
}
