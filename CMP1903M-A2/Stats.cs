using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A2
{
    internal class Stats
    {
        public static void stats()
        {
            SevensOut wins = new SevensOut();
            int winValue = wins.winsCall;
            int rolls = wins.rolled;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the stats page\n" + "Please select an option -");
            Console.WriteLine(("").PadRight(24, '-'));
            Console.WriteLine("1 - View stats\n" + "2 - Back to menu\n" + ("").PadRight(24, '-'));

            Console.ForegroundColor = ConsoleColor.Magenta;
            String UInput = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (UInput == "1")
            {
                Console.WriteLine("Wins - " + winValue);
                Console.WriteLine("Rolls - " + rolls);
            }
            else if (UInput == "2")
            {
                return;
            }
        }
    }
}
