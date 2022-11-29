using GeeksForGeeksProblems.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProgrammingChallenges.Tests.LeetCodeTests
{
    public class RomanToIntegersTests
    {
        [Theory]
        [InlineData("MCMXCIV", 1994)]
        [InlineData("XVIII", 18)]
        [InlineData("M", 1000)]
        [InlineData("XLIX", 49)]
        [InlineData("XXXVIII", 38)]
        [InlineData("C", 100)]
        [InlineData("XCIX", 99)]
        public void RomanToIntegerTest(string roman, int result)
        {
            int num = new RomanToInteger().ToInteger(roman);

            Assert.Equal(result, num);
        }
    }
}
