using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems.HackerRank
{
    public class DivisibleSumPairs
    {
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            var count = 0;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                        count++;
                }
            }

            return count;
        }
    }
}
