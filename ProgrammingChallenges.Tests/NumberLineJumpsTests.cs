using GeeksForGeeksProblems.HackerRank;
using Xunit;

namespace ProgrammingChallenges.Tests
{
    public class NumberLineJumpsTests
    {
        [Theory]
        [InlineData(0, 2, 5, 3)]
        [InlineData(2932, 7030, 9106, 4840)]
        public void Test1(int x1, int v1, int x2, int v2)
        {
            var result = NumberLineJumps.kangaroo(x1, v1, x2, v2);

            Assert.Equal("NO", result);
        }

        [Theory]
        [InlineData(0, 3, 4, 2)]
        public void Test2(int x1, int v1, int x2, int v2)
        {
            var result = NumberLineJumps.kangaroo(x1, v1, x2, v2);

            Assert.Equal("YES", result);
        }
    }
}
