using GeeksForGeeksProblems.HackerRank;
using GeeksForGeeksProblems.LeetCode;
using System.Collections.Generic;
using System.Linq;

namespace GeeksForGeeksProblems
{
    class Program
    {
        class Chassis
        {
            public string ChassisId { get; set; }

            public string SKU { get; set; }
        }

        static void Main(string[] args)
        {
            //  new TwoSumSolution().TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            //  new TwoSumSolution().TwoSum(new int[] { 3, 2, 4 }, 6);
           var result = new TwoSumSolution().TwoSum3(new int[] { 3,2, 3 }, 6);

        }
    }
}
