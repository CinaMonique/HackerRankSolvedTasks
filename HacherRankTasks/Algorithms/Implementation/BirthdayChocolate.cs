using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.Implementation
{
    class BirthdayChocolate
    {
        static int GetWaysNumberOfDividingChoco(int[] s, int d, int m)
        {
            int numberOfDividing = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int segmentsSum = 0;
                int counter = 1;
                for (int j = i; j < s.Length && counter <= m && segmentsSum <= d; j++, counter++)
                {
                    segmentsSum += s[j];
                    if (segmentsSum == d && counter == m)
                    {
                        numberOfDividing++;
                        break;
                    }
                }
            }
            return numberOfDividing;
        }

        static int GetWaysNumberOfDividingChocoSecondVersion(int[] s, int d, int m)
        {
            int numberOfDividing = 0;

            for (int i = 0; i <= s.Length - m; i++)
            {
                int segmentsSum = 0;
                for (int j = i; j < i + m; j++)
                {
                    segmentsSum += s[j];
                }
                if (segmentsSum == d)
                {
                    numberOfDividing++;
                }
            }
            return numberOfDividing;
        }
    }
}
