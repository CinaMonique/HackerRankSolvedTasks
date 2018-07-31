using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacherRankTasks.Algorithms.WarmUp
{
    class TimeConversion
    {
        static string ConvertTime(string s)
        {
            string result;
            int stringLength = s.Length;
            int indexOfStartingHourFormat = stringLength - 2;
            string hourWithoutFormat = s.Substring(0, indexOfStartingHourFormat);
            string hourFormat = s.Substring(indexOfStartingHourFormat);
            if (hourFormat == "AM")
            {
                if (GetHourAsInt(hourWithoutFormat) == 12)
                {
                    result = "00" + hourWithoutFormat.Substring(2);
                }
                else
                {
                    result = hourWithoutFormat;
                }
            }
            else
            {
                if (GetHourAsInt(hourWithoutFormat) == 12)
                {
                    result = "12" + hourWithoutFormat.Substring(2);
                }
                else
                {
                    string hourIn24hFormat = (GetHourAsInt(hourWithoutFormat) + 12).ToString();
                    result = hourIn24hFormat + hourWithoutFormat.Substring(2);
                }
            }
            return result;
        }
        // Złożoność obliczeniowa: 1

        private static int GetHourAsInt(string hourWithoutFormat)
        {
            return Convert.ToInt32(hourWithoutFormat.Substring(0, 2));
        }

        static string ConvertTimeUsingMethods(string s)
        {
            int indexOfStartingHourFormat = s.Length - 2;
            string hourWithoutFormat = s.Substring(0, indexOfStartingHourFormat);
            if (s.EndsWith("AM"))
            {
                if (Convert.ToInt32(s.StartsWith("12")) == 12)
                {
                    return "00" + hourWithoutFormat.Substring(2);
                }
                return hourWithoutFormat;
            }

            if (Convert.ToInt32(s.StartsWith("12")) == 12)
            {
                return "12" + hourWithoutFormat.Substring(2);
            }
            string hourIn24HFormat = (Convert.ToInt32(hourWithoutFormat.Substring(0, 2)) + 12).ToString();
            return hourIn24HFormat + hourWithoutFormat.Substring(2);
        }
    }
}
