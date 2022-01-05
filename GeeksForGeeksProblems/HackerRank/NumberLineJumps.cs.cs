using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems.HackerRank
{
    public class NumberLineJumps
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            int divisor = v2 - v1;
            int numeratr = x1 - x2;

            if (divisor == 0 && numeratr == 0)
                return "YES";

            if (divisor == 0 && numeratr != 0)
                return "NO";

            int mod = numeratr % divisor;

            int rem = numeratr / divisor;

            if (mod == 0 && rem >= 0)
                return "YES";

            return "NO";
        }

    }
}
