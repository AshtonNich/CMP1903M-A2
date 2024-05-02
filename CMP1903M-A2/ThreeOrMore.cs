using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A2
{
    public class ThreeOrMore
    {
        private Die[] dice = new Die[5];

        public ThreeOrMore()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }
        }
        private int[] RollAllDice()
        {
            int[] rolls = new int[dice.Length];
            for (int i = 0; i < dice.Length; i++)
            {
                rolls[i] = dice[i].Roll();
            }
            return rolls;
        }

        private int GetMaxCount(int[] rolls)
        {
            int maxCount = 0;
            foreach (int rolled in rolls)
            {
                int count = Array.FindAll(rolls, x => x == rolled).Length;
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            return maxCount;
        }

        public int Threes()
        {
            int score = 0;

            while (score < 20)
            {
                int[] rolls = RollAllDice();
                Console.WriteLine($"You rolled: {string.Join(", ", rolls)}");

                int maxCount = GetMaxCount(rolls);

                if (maxCount >= 3)
                {
                    int points = (maxCount == 3) ? 3 : (maxCount == 4) ? 6 : 12;
                    score += points;
                    Console.WriteLine("You got " + maxCount + " of-a-kind!\nEarned" + points + "\nYour total score: " + score);
                }
                else
                {
                    Console.WriteLine("No 3-of-a-kind or better. Try again.");
                    return 0;
                }
            }

            Console.WriteLine("Congratulations! You reached 20 points!");
            return score;
        }


    }
}
