using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliMastermind.src
{
    public class MasterMindSettings
    {
        public static List<char> couleurAutorise = new List<char>()
        {
            'B', 'R', 'N', 'V', 'J', 'G',
        };                                                                                                                              // liste des initiales de couleur

        public static List<ConsoleColor> couleurForground = new List<ConsoleColor>()
        {
            ConsoleColor.White, ConsoleColor.Black, ConsoleColor.White, ConsoleColor.Black, ConsoleColor.Black, ConsoleColor.Black,
        };                                                                                                                              // liste des couleurs de premier plan

        public static List<ConsoleColor> couleurBackground = new List<ConsoleColor>()
        {
            ConsoleColor.Blue, ConsoleColor.Red, ConsoleColor.Black, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Gray,
        };                                                                                                                              // liste des couleurs d'arrères plan
    }
}
