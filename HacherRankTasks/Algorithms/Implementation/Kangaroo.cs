using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.Implementation
{
    class Kangaroo
    {
        static string CheckKangarooLocation(int x1, int v1, int x2, int v2)
        {
            float numberOfJumps = (float) (x2 - x1) / (v1 - v2);
            if (x2 > x1 && v2 > v1 || x1 > x2 && v1 > v2)
            {
                return "NO";
            }
            if (numberOfJumps == (int) numberOfJumps)
            {
                return "YES";
            }
            return "NO";
        }
        // Złożoność obliczeniowa: stała 
    }
}
