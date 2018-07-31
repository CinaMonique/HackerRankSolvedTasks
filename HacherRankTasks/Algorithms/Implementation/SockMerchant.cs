using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.Implementation
{
    class SockMerchant
    {
        public static int MatchSocks(int n, int[] ar)
        {
            int numberOfPairs = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ar[i] == ar[j] && ar[i] != 0)
                    {
                        numberOfPairs++;
                        ar[j] = 0;
                        break;
                    }
                }
            }
            return numberOfPairs;
        }

        public static int MatchSocksSecondVersion(int n, int[] ar)
        {
            int total = 0;
            int[] socks = new int[100];
            foreach (var element in ar)
            {
                socks[element - 1]++;
            }
            foreach (var element in socks)
            {
                total += element / 2;
            }
            return total;
        }
    }
}
