using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.WarmUp
{
    class VeryBigSum
    {
        static long CalculateVeryBigSum(long[] ar)
        {
            long sum = 0;
            foreach (long number in ar)
            {
                sum += number;
            }
            return sum;
        }
        // n - liczba elementów w tablicy
        // Złożoność obliczeniowa: O(n)
    }
}
