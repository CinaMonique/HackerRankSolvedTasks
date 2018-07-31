using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.Implementation
{
    class DrawingBook
    {
        static int CountPages(int n, int p)
        {
            int pagesAmountFromTheBeggining;
            int pagesAmountFromTheEnd;

            if (p % 2 != 0) //p nieparzyste
            {
                pagesAmountFromTheBeggining = (p - 1) / 2;
                if (n % 2 == 0) //n parzyste
                {
                    pagesAmountFromTheEnd = (n - p + 1) / 2;
                }
                else //n nieparzyste
                {
                    pagesAmountFromTheEnd = (n - p) / 2;
                }

            }
            else //p parzyste
            {
                pagesAmountFromTheBeggining = p / 2;
                if (n % 2 == 0) //n parzyste
                {
                    pagesAmountFromTheEnd = (n - p) / 2;
                }
                else //n nieparzyste
                {
                    pagesAmountFromTheEnd = (n - p - 1) / 2;
                }
            }

            if (pagesAmountFromTheBeggining > pagesAmountFromTheEnd)
            {
                return pagesAmountFromTheEnd;
            }
            return pagesAmountFromTheBeggining;
        }
    }
}
