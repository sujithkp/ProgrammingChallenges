using GeeksForGeeksProblems.HackerRank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProgrammingChallenges.Tests
{
    public class OrangeAndAppleTests
    {
        [Theory]
        [InlineData()]
        public void Test1()
        {
            AppleandOrange.countApplesAndOranges(7, 11, 5, 15, new List<int> { -2, 2, 1 }, new List<int> { 5, -6 });
        }
    }
}
