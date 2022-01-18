using GeeksForGeeksProblems.HackerRank;
using Xunit;

namespace ProgrammingChallenges.Tests
{
    public class RepeatedStringTests
    {
        [Theory]
        [InlineData("abcac", 10, 4)]
        [InlineData("aba", 10, 7)]
        [InlineData("a", 1000000000000, 1000000000000)]
        public void Test3(string input, long n, long expected)
        {
            var result = RepeatedString.repeatedString(input, n);

            Assert.Equal(expected, result);
        }
    }
}
