using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.Implementation
{
    class CatsAndAMouse
    {
        static string CatchTheMouse(int x, int y, int z)
        {
            if (x == y || (double) (x + y) / 2 == z)
            {
                return "Mouse C";
            }
            if (Math.Abs(z - x) < Math.Abs(z - y))
            {
                return "Cat A";
            }

            return "Cat B";
        }
    }
}
