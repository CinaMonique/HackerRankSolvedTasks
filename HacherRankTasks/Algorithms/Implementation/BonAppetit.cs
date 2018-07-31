using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.Implementation
{
    class BonAppetit
    {
        static void CheckCalculationsCorrectness()
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);
            int[] bill = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int b = Convert.ToInt32(Console.ReadLine());

            int billSum = bill.Sum();
            int properCost = (billSum - bill[k]) / 2;

            Console.WriteLine(properCost == b ? "Bon Appetit" : $"{b - properCost}");

            Console.ReadKey();
        }
    }
}
