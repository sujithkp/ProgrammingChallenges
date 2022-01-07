using GeeksForGeeksProblems.HackerRank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProgrammingChallenges.Tests
{
    public class DivisibleSumPairsTests
    {

        [Theory]
        [InlineData()]
        public void Test1()
        {
            var result = DivisibleSumPairs.divisibleSumPairs(6, 3, new List<int> { 1, 3, 2, 6, 1 , 2});

            Assert.Equal(2, result);
        }
    }
}
