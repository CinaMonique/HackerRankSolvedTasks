using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.Implementation
{
    class MigratoryBirds
    {
        static int FindMostPopularBird(int[] ar)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int bird in ar)
            {
                if (dict.ContainsKey(bird))
                {
                    dict[bird]++;
                }
                else
                {
                    dict.Add(bird, 0);
                }
            }
            IEnumerable<KeyValuePair<int, int>> allMaxValues = dict.Where(x => x.Value == dict.Values.Max());
            return allMaxValues.Min(u => u.Key);
        }

        static int FindMostPopularBirdSecondVersion(int[] ar)
        {
            int[] amountOfIds = new int[5];
            foreach (int bird in ar)
            {
                amountOfIds[bird - 1]++;
            }
            int maxValue = amountOfIds.Max();
            return amountOfIds.ToList().IndexOf(maxValue) + 1;
        }
    }
}
