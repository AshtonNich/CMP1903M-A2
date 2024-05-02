using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A2
{
    using System;

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
                int count = 0;
                foreach (int roll in rolls)
                {
                    if (roll == rolled)
                    {
                        count++;
                    }
                }
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
                Console.WriteLine($"You rolled - {string.Join(", ", rolls)}");
                int maxCount = GetMaxCount(rolls);

                if (maxCount >= 3)
                {
                    int points = 0;
                    if (maxCount == 3)
                    {
                        points = 3;
                        score += points;
                        Console.WriteLine("You got " + maxCount + " of a kind!\nEarned" + points + "\nYour total score: " + score);

                    }
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
