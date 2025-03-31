using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AppliMastermind.src
{
    public class MasterMind
    {
        private MasterMindUI   lInterface;
        private char[]         laCombinaison;
        private List<char[]>   lesEssais;

        public List<char[]> GetEssais()            // retourne la listes des essais
        { return this.lesEssais; } 

        public int GetBienPlace(char[] unEssai)    // appelle la methode de calcule pour les biens/mals placés pour retourner que les biens placés
        {
            return MasterMindUtils.GetInfoEssai(this.laCombinaison, unEssai).Item1;
        }

        public int GetMalPlace(char[] unEssai)     // appelle la methode de calcule pour les biens/mals placés pour retourner que les mals placés
        {
            return MasterMindUtils.GetInfoEssai(this.laCombinaison, unEssai).Item2;
        }

        public MasterMind()
        {
            // -- Initialisation des attribues de la classe -- 
            this.lInterface = new MasterMindUI(this);
            this.lesEssais  = new List<char[]>();

            Console.Write(this.lInterface.RequestPlayer());             // demande au joueur de siasir
            this.laCombinaison = MasterMindUtils.GetSaisie();           // recupère le tableau de saisie dans la console
            
            do 
            {
                this.lInterface.ClearConsole();                         // efface la console
                this.lInterface.GetTableau();            // affiche le tableau
                Console.Write(this.lInterface.RequestPlayer());         // demande au joueur de siasir
                this.lesEssais.Add(MasterMindUtils.GetSaisie());        // recupère le tableau de saisie dans la console
            } while (this.GetBienPlace(this.lesEssais.Last()) != 5);    // ferme la boucle si les biens placés equivaut à 5 (car il y a que 5 nombre a saisir)

            this.lInterface.ClearConsole();
            this.lInterface.GetTableau();
            Console.Write(this.lInterface.ScreenFinal());               // Affiche l'écrans final
        }
    }
}
