using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems.HackerRank
{
    public class MinMaxSUm
    {
        public static void miniMaxSum(List<int> arr)
        {
            var sortedArray = arr.ToArray();
            Array.Sort(sortedArray);

            decimal maxSum = 0;
            decimal minSum = 0;

            sortedArray.Take(4).ToList().ForEach(x => minSum += x);
            sortedArray.Reverse().Take(4).ToList().ForEach(x => maxSum += x);

            Console.Write(minSum + " " + maxSum);
        }
    }
}
