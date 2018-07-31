using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.Implementation
{
    class DivisibleSumPairs
    {
        public static int GetNumberOfPairs(int n, int k, int[] ar)
        {
            int numberOfPairs = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        numberOfPairs++;
                    }
                }
            }
            return numberOfPairs;
        }
        // n- liczba elementów w tablicy
        // Złożoność obliczeniowa: O(n*(n-1)) = O(n^2)
    }
}
