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
        private int total;
        private int temp;
        public int rolled;
        private int CPUtotal;
        private int p2total;
        public int wins;
        public int winsCall;

        public void Sevens()
        {
            Console.WriteLine("Welcome to the sevens out game!\nwould you like to play with a partner or with the computer?");
            string cpuORplayer = Console.ReadLine();
            if (cpuORplayer.ToLower() == "computer")
            {
                while (true)
                {

                    Console.WriteLine("Press enter to roll or type stop to break out of the game");
                    string Uplay = Console.ReadLine();
                    if (Uplay.ToLower() == "stop")
                    {
                        Console.WriteLine("you won a total of " + wins + " times this session!\nand rolled: " + rolled + " times!");
                        break;
                    }
                    while (Uplay != "stop")
                    {
                        int roll1 = dice1.Roll();
                        int roll2 = dice1.Roll();
                        if (roll1 + roll2 == 7)
                        {
                            Console.WriteLine("both roll one " + roll1 + " and roll two " + roll2 + " add up to seven.\nEnding Game!");
                            rolled++;
                            Console.WriteLine("your total score at the end was: " + total + "\nand the computer scored: " + CPUtotal);
                            if (total > CPUtotal)
                            {
                                wins++;
                                Console.WriteLine("PLAYER WINS!\nPlayer wins = " + wins);
                            }
                            else
                            {
                                Console.WriteLine("CPU WINS!");
                            }
                            break;
                        }
                        else if (roll1 == roll2)
                        {
                            Console.WriteLine("you rolled " + roll1 + " and " + roll2 + "\nthey are the same! adding it to your total");
                            temp = roll1 + roll2;
                            total += temp * 2;
                            rolled++;

                        }
                        else
                        {
                            Console.WriteLine("you rolled " + roll1 + " and " + roll2);
                            rolled++;
                            temp = roll1 + roll2;
                            total += temp;

                        }
                        Console.WriteLine("its my  turn now >:)");
                        roll1 = dice1.Roll();
                        roll2 = dice1.Roll();
                        if (roll1 == roll2)
                        {
                            Console.WriteLine("CPU rolled " + roll1 + " and " + roll2);
                            temp = roll1 + roll2;
                            CPUtotal += temp * 2;
                            break;
                        }
                        else if ((roll1 + roll2) == 7)
                        {
                            Console.WriteLine("CPU rolled " + roll1 + " and " + roll2 + "\nThat adds up to seven! lets see who wins!");
                            Console.WriteLine("your total score at the end was: " + total + " \nand the computer scored: " + CPUtotal);
                            if (total > CPUtotal)
                            {
                                wins++;
                                Console.WriteLine("PLAYER WINS!\nPlayer wins = " + wins);
                            }
                            else
                            {
                                Console.WriteLine("CPU WINS!");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("CPU rolled " + roll1 + " and " + roll2);
                            temp = roll1 + roll2;
                            CPUtotal += temp;
                            break;
                        }

                    }
                }
            }
            if (cpuORplayer.ToLower() == "partner")
            {
                while (true)
                {

                    Console.WriteLine("PLAYER 1 - press enter to roll or type stop to break out of the game");
                    string Uplay = Console.ReadLine();
                    if (Uplay.ToLower() == "stop")
                    {
                        Console.WriteLine("you won a total of " + wins + " times this session!\nand rolled: " + rolled + " times!");
                        break;
                    }
                    while (Uplay != "stop")
                    {
                        int roll1 = dice1.Roll();
                        int roll2 = dice1.Roll();
                        if (roll1 + roll2 == 7)
                        {
                            Console.WriteLine("both roll one " + roll1 + " and roll two " + roll2 + " add up to seven.\nEnding Game!");
                            rolled++;
                            Console.WriteLine("your total score at the end was: " + total + "\nand p2 scored: " + p2total);
                            if (total > CPUtotal)
                            {
                                wins++;
                                Console.WriteLine("PLAYER WINS!\nPlayer wins = " + wins);
                            }
                            else
                            {
                                Console.WriteLine("CPU WINS!");
                            }
                            break;
                        }
                        else if (roll1 == roll2)
                        {
                            Console.WriteLine("you rolled " + roll1 + " and " + roll2 + "\nthey are the same! adding it to your total");
                            temp = roll1 + roll2;
                            total += temp * 2;
                            rolled++;

                        }
                        else
                        {
                            Console.WriteLine("you rolled " + roll1 + " and " + roll2);
                            rolled++;
                            temp = roll1 + roll2;
                            total += temp;

                        }
                        Console.WriteLine("PLAYER 2 - press enter to roll");
                        Console.ReadLine();
                        roll1 = dice1.Roll();
                        roll2 = dice1.Roll();
                        if (roll1 == roll2)
                        {
                            Console.WriteLine("CPU rolled " + roll1 + " and " + roll2);
                            temp = roll1 + roll2;
                            p2total += temp * 2;
                        }
                        else if ((roll1 + roll2) == 7)
                        {
                            Console.WriteLine("P2 rolled " + roll1 + " and " + roll2 + "\nThat adds up to seven! lets see who wins!");
                            Console.WriteLine("your total score at the end was: " + total + " \nand p2 scored: " + p2total);
                            if (total > p2total)
                            {
                                wins++;
                                Console.WriteLine("P1 WINS!\nPlayer one wins = " + wins);
                            }
                            else if (total < p2total)
                            {
                                Console.WriteLine("P2 WINS!");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("P2 rolled " + roll1 + " and " + roll2);
                            temp = roll1 + roll2;
                            p2total += temp;
                        }

                    }

                }

            }
            winsCall += wins;
        }
        
    }
}
