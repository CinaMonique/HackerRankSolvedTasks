using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.WarmUp
{
    public class DiagonalDifference
    {
        public static int CalculateDiagonalDifference(int[][] matrix)
        {
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            int dimensionLength = matrix.GetLength(0);
            for (int i = 0; i < dimensionLength; i++)
            {
                primaryDiagonalSum += matrix[i][i];
                secondaryDiagonalSum += matrix[i][dimensionLength - i - 1];
            }
            return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
        }
        // n - liczba elementów w tablicy
        // Złożoność obliczeniowa: O(n)
    }
}
