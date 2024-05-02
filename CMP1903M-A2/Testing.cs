using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A2
{
    internal class Testing
    {
        public static void testing()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the testing page\n" + "Please select an option -");
            Console.WriteLine(("").PadRight(24, '-'));
            Console.WriteLine("1 - Test Sevens\n" + "2 - Test Three or More\n" + "3 - Exit\n" + ("").PadRight(24, '-'));

            Console.ForegroundColor = ConsoleColor.Magenta;
            String UInput = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (UInput == "1")
            {
                Die testDie = new Die();
                for (int i = 0; i < 1000; i++)
                {
                    int testRoll = testDie.Roll();
                    int testRoll2 = testDie.Roll();
                    int total = testRoll + testRoll2;
                    Debug.Assert(total >= 2 && total <= 12, "total does not equal 7");
                    int testAmount = i;
                }
                Console.WriteLine("1000 tests passed successfully!");
            }
            else if (UInput == "2")
            {
                ThreeOrMore three = new ThreeOrMore();
                for (int i = 0; i<1000; i++)
                {
                    Console.WriteLine("...");
                }
            }
            else if (UInput == "3")
            {
                Console.WriteLine("Return");
            }
        }
    }
}
