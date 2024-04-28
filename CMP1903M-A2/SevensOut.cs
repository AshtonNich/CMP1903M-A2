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
            Console.WriteLine("Welcome to the sevens out game! \n would you like to play witha  partner or with the computer?");
            string cpuORplayer = Console.ReadLine();
            if (cpuORplayer == "computer") 
            {
                Console.WriteLine("shaboom boom");
            }
        }
    }
}
