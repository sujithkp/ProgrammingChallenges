using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems.HackerRank
{
    public class BetweenTwoSets
    {
        public static int getTotalX(List<int> a, List<int> b)
        {
            var max = b.Max() * b.Max();

            var nums = new List<int>();

            for (int i = a.Max(); i <= max; i++)
            {
                var alldivisible = true;

                foreach (var ele in a)
                    if (i % ele != 0)
                    {
                        alldivisible = false;
                        break;
                    }

                if (alldivisible) nums.Add(i);
            }

            var result = new List<int>();

            foreach (var element in nums)
            {
                var alldivisible = true;

                foreach (var div in b)
                    if (div % element != 0)
                    {
                        alldivisible = false;
                        break;
                    }
                if (alldivisible)
                    result.Add(element);
            }

            return result.Count;
        }

    }
}
