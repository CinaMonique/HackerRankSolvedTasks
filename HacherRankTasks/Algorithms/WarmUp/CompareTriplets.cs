 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.WarmUp
{
    class CompareTriplets
    {
        static int[] CompareTripletsSimply(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int[] result = {0, 0};
            if (a0 > b0)
            {
                result[0]++;
            }
            else if (a0 < b0)
            {
                result[1]++;
            }
            if (a1 > b1)
            {
                result[0]++;
            }
            else if (a1 < b1)
            {
                result[1]++;
            }
            if (a2 > b2)
            {
                result[0]++;
            }
            else if (a2 < b2)
            {
                result[1]++;
            }
            return result;
        }
        // Złożoność obliczeniowa: stała

        static int[] CompareTripletsSecondVersion(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int[] result = { 0, 0 };
            CompareDoubles(a0, b0, result);
            CompareDoubles(a1, b1, result);
            CompareDoubles(a2, b2, result);
            return result;
        }
   
        private static void CompareDoubles(int a, int b, int[] result)
        {
            if (a > b)
            {
                result[0]++;
            }
            else if (a < b)
            {
                result[1]++;
            }
        }
    }
}
