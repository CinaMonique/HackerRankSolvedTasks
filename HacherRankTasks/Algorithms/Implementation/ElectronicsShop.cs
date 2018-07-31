using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.Implementation
{
    class ElectronicsShop
    {
        public static int GetMoneySpentSimple(int[] keyboards, int[] drives, int b)
        {
            int maxValue = -1;
            foreach (int keyboard in keyboards)
            {
                foreach (int drive in drives)
                {
                    int shop = keyboard + drive;
                    if (shop <= b && shop > maxValue)
                    {
                        maxValue = shop;
                    }
                }
            }
            return maxValue;
        }
    }
}
