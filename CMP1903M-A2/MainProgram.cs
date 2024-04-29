using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A2
{
    internal class MainPorgram
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Welcome To The Die Roll Games 2!\n" + "Please Select an option -");
                Console.WriteLine(("").PadRight(24, '-'));
                Console.WriteLine("1 - Play a game\n" + "2 - testing\n" + "3 - stats\n" + "4 - rules\n" + "5 - exit\n" + ("").PadRight(24, '-'));
                
                Console.ForegroundColor = ConsoleColor.Magenta;
                String UInput = Console.ReadLine();
                Console.ForegroundColor= ConsoleColor.Yellow;
                if (UInput == "1")
                {
                    Game.game();
                }
                else if (UInput == "2")
                {

                }
                else if (UInput == "3")
                {

                }
                else if (UInput == "4")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    string ruleTXT = File.ReadAllText(@"Files\gamerules.txt");
                    Console.WriteLine(ruleTXT);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (UInput == "5")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
