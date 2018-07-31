using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.Implementation
{
    class BetweenTwoSets
    {
        public static int GetTotalX(int[] a, int[] b)
        {
            List<int> numbersDividedByA = new List<int>();
            int amountOfNUmber = 0;

            for (int i = a.Min(); i <= b.Min(); i++)
            {
                if (Array.TrueForAll(a, x => i % x == 0))
                {
                    numbersDividedByA.Add(i);
                }
            }
            foreach (int i in numbersDividedByA)
            {
                if (Array.TrueForAll(b, x => x % i == 0))
                {
                    amountOfNUmber++;
                }
            }

            return amountOfNUmber;
        }
    }
}
