using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.Implementation
{
    class GradingStudents
    {
        static int[] RoundGrades(int[] grades)
        {
            int gradesLength = grades.Length;
            int[] result = new int[gradesLength];
            for (int i = 0; i < gradesLength ; i++)
            {
                if (grades[i] < 38)
                {
                    result[i] = grades[i];
                }
                else
                {
                    int gradeDiff = 5 - (grades[i] % 5);
                    if (gradeDiff < 3)
                    {
                        result[i] = grades[i] + gradeDiff;
                    }
                    else
                    {
                        result[i] = grades[i];
                    }
                }
            }
            return result;
        }
        // n - liczba elementów w tablicy
        // Złożoność obliczeniowa: O(n)
    }
}
