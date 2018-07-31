using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.WarmUp
{
    class Staircase
    {
        static void DrawStaircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= 1; j--)
                {
                    if (j <= i)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }
        // n - liczba poziomów schodów
        // Złożoność obliczeniowa: O(n^2)

        static void DrawStaircaseSecondVersion(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = i; j > 0; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
        }
    }
}
