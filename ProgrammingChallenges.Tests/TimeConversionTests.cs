using GeeksForGeeksProblems.HackerRank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProgrammingChallenges.Tests
{
    public class TimeConversionTests
    {
        [Theory]
        [InlineData("12:01:00PM")]
        [InlineData("12:01:00AM")]
        [InlineData("07:05:45PM")]
        public void Test1(string time)
        {
            var result = TimeConversion.timeConversion(time);

            Assert.DoesNotContain(result, "AM");
            Assert.DoesNotContain(result, "PM");
        }

    }
}
