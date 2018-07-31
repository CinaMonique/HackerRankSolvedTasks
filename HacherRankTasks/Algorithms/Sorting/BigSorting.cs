using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace HacherRankTasks.Algorithms.Sorting
{
    class BigSorting
    {
        // Za wolne
        public static string[] SortBigNumberSlow(string[] unsorted)
        {
            return unsorted.OrderBy(u => u.Length).ThenBy(u => u).ToArray();
        }

        // Za wolne
        public static string[] SortBigNumberAlsoSlow(string[] unsorted)
        {
            Array.Sort(unsorted, CompareStringsByLength);
            return unsorted;
        }

        private static int CompareStringsByLength(string a, string b)
        {
            int comparisonValue = a.Length.CompareTo(b.Length);

            if (comparisonValue != 0)
            {
                return comparisonValue;
            }

            return a.CompareTo(b);
        }

        // Jeszcze bardziej wolne
        public static string[] SortBigNumber(string[] unsorted)
        {
            return unsorted.OrderBy(u => BigInteger.Parse(u)).ToArray();
        }

    }
}
