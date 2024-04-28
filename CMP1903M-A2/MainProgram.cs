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
            bool loop = true;
            while (loop)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Welcome To The Die Roll Games 2! \n" +
                    "Please Select an option -");
                Console.WriteLine(("").PadRight(24, '-'));
                Console.WriteLine("1 - Play a game \n" +
                    "2 - testing \n" +
                    "3 - stats \n " +
                    "4 - exit \n" +
                    ("").PadRight(24, '-'));
                
                
                
                Console.WriteLine("Would you like to play with a  partner or the computer?");
                Console.ForegroundColor = ConsoleColor.Magenta;
                string playerOrCpu = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("What game would you like to do?");
                Console.ForegroundColor = ConsoleColor.Magenta;
                String UInput = Console.ReadLine();
                Game game = new Game();
                while (true)
                {
                    game.game();
                }
                if (UInput == "1")
                {

                }
                else if (UInput == "2")
                {

                }
                else if (UInput == "3")
                {

                }
                else if (UInput == "4")
                {
                    
                }
            }
        }
    }
}
