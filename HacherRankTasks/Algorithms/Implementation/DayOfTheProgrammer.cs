using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.Implementation
{
    class DayOfTheProgrammer
    {
        static string CalculateDate(int year)
        {
            int[] daysNumbersForCommonYear = { 31, 28, 31, 30, 31, 30, 31, 31 };
            int daysSum = daysNumbersForCommonYear.Sum();
            int programmerDayForCommonYear = 256 - daysSum;

            if (year >= 1700 && year <= 1917)
            {
                if (CheckIfYearIsLeapInJulian(year))
                {
                    programmerDayForCommonYear--;
                }
            }
            else if (year == 1918)
            {
                programmerDayForCommonYear = programmerDayForCommonYear + 13;
                if (CheckIfYearIsLeapInGregorian(year))
                {
                    programmerDayForCommonYear--;
                }
            }
            else if (year > 1918 && year <= 2700)
            {
                if (CheckIfYearIsLeapInGregorian(year))
                {
                    programmerDayForCommonYear--;
                }
            }
            return programmerDayForCommonYear + ".09." + year;
        }

        private static bool CheckIfYearIsLeapInGregorian(int year)
        {
            return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
        }

        private static bool CheckIfYearIsLeapInJulian(int year)
        {
            return year % 4 == 0;
        }
    }
}
