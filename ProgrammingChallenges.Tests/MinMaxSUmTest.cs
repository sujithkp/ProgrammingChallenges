using GeeksForGeeksProblems.HackerRank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProgrammingChallenges.Tests
{
    public class MinMaxSUmTest
    {
        [Fact]
        public void Test1()
        {
            var arr = new List<int> { 256741038, 623958417, 467905213, 714532089, 938071625 };

            MinMaxSUm.miniMaxSum(arr);

        }
    }
}
