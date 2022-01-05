using GeeksForGeeksProblems.HackerRank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProgrammingChallenges.Tests
{
    public class SubArraySumTests
    {
        [Theory]
        [InlineData()]
        public void Test1()
        {
            var result = SubarrayDivision.birthday(new List<int> { 1, 2, 1, 3, 2 }, 3, 2);

            Assert.Equal(2, result);
        }

        [Theory]
        [InlineData()]
        public void Test2()
        {
            var result = SubarrayDivision.birthday(new List<int> { 1, 1, 1, 1, 1 ,1 }, 3, 2);

            Assert.Equal(0, result);
        }
    }
}
