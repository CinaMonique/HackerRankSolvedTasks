using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.WarmUp
{
    class PlusMinus
    {
        static void CalculatePlusMinus(int[] arr)
        {
            int negativeNumbers = 0;
            int positiveNumbers = 0;
            int zerosNumbers = 0;
            int arrayLength = arr.Length;
            foreach (int number in arr)
            {
                if (number < 0)
                {
                    negativeNumbers++;
                }
                else if (number > 0)
                {
                    positiveNumbers++;
                }
                else
                {
                    zerosNumbers++;
                }
            }
            Console.WriteLine($"{(double)positiveNumbers / arrayLength}");
            Console.WriteLine($"{(double)negativeNumbers / arrayLength}");
            Console.WriteLine($"{(double)zerosNumbers / arrayLength}");
        }
        // n - liczba elementów w tablicy
        // Złożoność obliczeniowa: n 
    }
}
