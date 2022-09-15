using GeeksForGeeksProblems.HackerRank;
using Xunit;

namespace ProgrammingChallenges.Tests
{
    public class TheTimeInWordsTests
    {
        [Theory]
        [InlineData("5:28", "twenty eight minutes past five")]
        [InlineData("5:37", "twenty three minutes to six")]
        [InlineData("5:47", "thirteen minutes to six")]
        [InlineData("5:57", "three minutes to six")]
        [InlineData("3:00", "three o' clock")]
        [InlineData("7:15", "quarter past seven")]
        [InlineData("5:45", "quarter to six")]
        public void Test1(string time, string expected)
        {
            var result = TheTimeinWords.timeInWords(int.Parse(time.Split(":")[0]), int.Parse(time.Split(":")[1]));

            Assert.Equal(result, expected);
        }
    }
}
