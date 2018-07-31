using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.WarmUp
{
    class MinMaxSum
    {
        public static void ComputeMinMaxSum(int[] arr)
        {
            long sumOfAllNumbers = 0;
            foreach (int number in arr)
            {
                sumOfAllNumbers += number;
            }
            long maxValue = 0;
            long minValue = sumOfAllNumbers;
            for (int i = 0; i < arr.Length; i++)
            {
                long sum = sumOfAllNumbers - arr[i];
                if (maxValue < sum)
                {
                    maxValue = sum;
                }
                if (minValue > sum)
                {
                    minValue = sum;
                }
            }

            Console.WriteLine($"{minValue} {maxValue}");
        }
        // n - liczba elementów w tablicy
        // Złożoność obliczeniowa: O(n)

        public static void ComputeMinMaxSumSecondVersion(int[] arr)
        {
            int maxValueFromArray = arr.Max();
            int minValueFromArray = arr.Min();
            long sumOfAllNumbers = 0;
            foreach (int number in arr)
            {
                sumOfAllNumbers += number;
            }

            long maxValue = sumOfAllNumbers - minValueFromArray;
            long minValue = sumOfAllNumbers - maxValueFromArray;

            Console.WriteLine($"{minValue} {maxValue}");
        }
        // n - liczba elementów w tablicy
        // Złożoność obliczeniowa: O(n)
    }
}
