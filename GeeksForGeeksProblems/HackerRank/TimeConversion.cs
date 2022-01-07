using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems.HackerRank
{
    public class TimeConversion
    {
        public static string timeConversion(string s)
        {
            var isPm = s.Substring(s.Length - 2, 2) == "PM";

            var parts = s.Split(':');

            if (int.Parse(parts[0]) < 12 && isPm)
                parts[0] = (int.Parse(parts[0]) + 12).ToString();
            else if (int.Parse(parts[0]) == 12 && !isPm)
                parts[0] = "00";

            return string.Join(":", parts).Replace("AM", string.Empty).Replace("PM", string.Empty);
        }
    }
}
