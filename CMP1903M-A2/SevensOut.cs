using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CMP1903M_A2
{
    internal class SevensOut
    {
        private Die dice1 = new Die();
        private Die dice2 = new Die();
        private int total;
        private int temp;
        private int rolled;

        public void Sevens()
        {
            Console.WriteLine("Welcome to the sevens out game!\nwould you like to play with a partner or with the computer?");
            string cpuORplayer = Console.ReadLine();
            if (cpuORplayer == "computer") 
            {
                while (true)
                {
                    int roll1 = dice1.Roll();
                    int roll2 = dice2.Roll();

                    Console.WriteLine("Press enter to roll or type stop to break out of the game");
                    string Uplay = Console.ReadLine();
                    if (Uplay == "stop")
                    {
                        break;
                    }
                    while (Uplay != "stop")
                    {
                        if (roll1 + roll2 == 7)
                        {
                            Console.WriteLine("both roll one " + roll1 + " and roll two " + roll2 + " add up to seven.\nEnding Game!");
                            rolled++;
                            break;
                        }
                        else if (roll1 == roll2)
                        {
                            Console.WriteLine("both roll one " + roll1 + " and roll two " + roll2 + " are the same! adding it to your total");
                            temp = roll1 + roll2;
                            total += temp * 2;
                            rolled++;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("roll 1 is " + roll1 + " and roll 2 is " + roll2);
                            break;
                        }

                    }
                }
            }
        }
    }
}
