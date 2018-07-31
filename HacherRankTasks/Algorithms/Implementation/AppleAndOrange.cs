using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.Implementation
{
    class AppleAndOrange
    {
        static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int applesAmount = 0;
            int orangesAmount = 0;

            foreach (int apple in apples)
            {
                int applePosition = a + apple;
                if(apple > 0 && a + applePosition >= s && applePosition <= t)
                {
                    applesAmount++;
                }
            }

            foreach (int orange in oranges)
            {
                int orangePosition = b + orange;
                if (orange < 0 && orangePosition >= s && orangePosition <= t)
                {
                    orangesAmount++;
                }
            }

            Console.WriteLine($"{applesAmount}");
            Console.WriteLine($"{orangesAmount}");
        }
        // n - liczba elementów w tablicy
        // Złożoność obliczeniowa: O(n)
    }
}
