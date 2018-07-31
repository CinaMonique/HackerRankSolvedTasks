using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.WarmUp
{
    class BirthdayCakeCandles
    {
        static int GetAmountOfTallestBirthdayCakeCandles(int[] ar)
        {
            int maxValue = ar.Max();
            int tallestCandlesAmount = 0;
            foreach (int height in ar)
            {
                if (height == maxValue)
                {
                    tallestCandlesAmount++;
                }
            }
            return tallestCandlesAmount;
        }
        // n - liczba elementów w tablicy
        // Złożoność obliczeniowa: O(n)
    }
}
