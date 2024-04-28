using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A2
{
    internal class Die
    {
        //property
        static Random random = new Random();
        int currentRoll;

        //Method
        public int Roll()
        {
            currentRoll = random.Next(1, 7);
            return currentRoll;
        }
    }
}
