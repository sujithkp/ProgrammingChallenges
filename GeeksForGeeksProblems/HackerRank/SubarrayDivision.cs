using System.Collections.Generic;
using System.Linq;

namespace GeeksForGeeksProblems.HackerRank
{
    public class SubarrayDivision
    {
        public static int birthday(List<int> s, int d, int m)
        {
            var nums = s.Count();
            var count = 0;

            for (int i = 0; i <= nums - m; i++)
            {
                var subarraySum = s.Skip(i).Take(m).Sum();

                if (subarraySum == d)
                    count++;
            }

            return count;
        }
    }
}
