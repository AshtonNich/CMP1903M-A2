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
                    "Please Select a Gamemode -");
                Console.WriteLine(("").PadRight(24, '-'));
                Console.WriteLine("1 - Sevens Out \n" +
                    "2 - Three or more \n" +
                    "3 - testing \n" +
                    "4 - exit \n " +
                    ("").PadRight(24, '-'));
                Console.ForegroundColor = ConsoleColor.Magenta;
                String UInput = Console.ReadLine();

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
                    break;
                }
            }
        }
    }
}
