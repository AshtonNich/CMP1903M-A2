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

        public void Sevens()
        {
            Console.WriteLine("Welcome to the sevens out game!\nwould you like to play with a partner or with the computer?");
            string cpuORplayer = Console.ReadLine();
            if (cpuORplayer == "computer") 
            {
                int roll1 = dice1.Roll();
                int roll2 = dice2.Roll();

                Console.WriteLine("Press any button to roll");
                Console.ReadLine();
                if (roll1 + roll2 == 7)
                {
                    Console.WriteLine("both roll 1 " + roll1 + " and roll 2 " + roll2 + " add up to seven.\nEnding Game!");
                }
                else if (roll1 == roll2)
                {

                }
            }
        }
    }
}
