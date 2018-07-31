using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.Implementation
{
    class BreakingTheRecords
    {
        static int[] GetBreakingRecordsNumber(int[] scores)
        {
            int minValue = scores[0];
            int maxValue = scores[0];
            int[] result = {0, 0};

            foreach (int score in scores)
            {
                if (score > maxValue)
                {
                    result[0]++;
                    maxValue = score;
                }
                else if (score < minValue)
                {
                    result[1]++;
                    minValue = score;
                }
            }
            return result;
        }
        // n -liczba elementów w tablicy
        // Złożoność obliczeniowa: O(n)
    }
}
