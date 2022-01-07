using GeeksForGeeksProblems.HackerRank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProgrammingChallenges.Tests
{
    public class BetweenTwoSetsTests
    {
        [Theory]
        [InlineData()]
        public void Test1()
        {
            var result = BetweenTwoSets.getTotalX(new List<int> { 3, 4 }, new List<int> { 24, 48 });

            Assert.Equal(2, result);
        }

        [Theory]
        [InlineData()]
        public void Test2()
        {
            var result = BetweenTwoSets.getTotalX(new List<int> { 2, 4 }, new List<int> { 16, 32, 96 });

            Assert.Equal(3, result);
        }
    }
}
