using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.WarmUp
{
    static class ArraySum
    {
        static int SimpleArraySum(int[] ar)
        {
            int sum = 0;
            foreach (int number in ar)
            {
                sum += number;
            }
            return sum;
        }
        // n - liczba elementów w tablicy
        // Złożoność obliczeniowa: n

        static int SimpleArraySumSecondVersion(int[] ar)
        {
            return ar.Sum();
        }
        // n - liczba elementów w tablicy
        // Złożoność obliczeniowa: n
    }
}
