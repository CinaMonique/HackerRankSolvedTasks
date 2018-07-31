using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.Implementation
{
    class CountingValleys
    {
        static int CountValleys(int n, string s)
        {
            int totalAmount = 0;
            int amountOfMountains = 0;
            int numbersOfD = 0;
            int numbersOfU = 0;

            foreach (char letter in s)
            {
                if (letter == 'D')
                {
                    numbersOfD++;
                }
                else
                {
                    numbersOfU++;
                }
                if (numbersOfU == 1 && numbersOfD == 0)
                {
                    amountOfMountains++;
                }
                if (numbersOfD == numbersOfU)
                {
                    totalAmount++;
                    numbersOfD = 0;
                    numbersOfU = 0;
                }
            }
            return totalAmount - amountOfMountains;
        }

    }
}
