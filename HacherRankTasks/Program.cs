using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HacherRankTasks.Algorithms.Implementation;
using HacherRankTasks.Algorithms.WarmUp;
using HacherRankTasks.Algorithms.Sorting;


namespace HacherRankTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp));
                
            int total = BetweenTwoSets.GetTotalX(a, b);


            Console.WriteLine(total);
            
            Console.ReadKey();
        }
    }
}
