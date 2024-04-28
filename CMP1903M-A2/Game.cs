using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A2
{
    internal class Game
    {
        public void game()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("what game would you like to play?\n " + "1 - sevens out \n 2 - Three or More\n" + ("").PadRight(24, '-'));
                Console.ForegroundColor = ConsoleColor.Magenta;
                string userGame = Console.ReadLine();
                if (userGame == "1")
                {
                    SevensOut sevengame = new SevensOut();
                    sevengame.Sevens();
                }
                else if (userGame == "2")
                {

                }
                else
                {
                    break;
                }

            }
        }
    }
}
