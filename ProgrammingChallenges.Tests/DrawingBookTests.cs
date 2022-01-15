using GeeksForGeeksProblems.HackerRank;
using Xunit;

namespace ProgrammingChallenges.Tests
{
    public class DrawingBookTests
    {
        [Theory]
        [InlineData(5, 4, 0)]
        [InlineData(6, 2, 1)]
        [InlineData(6, 5, 1)]
        public void Test1(int totalPages, int requiredPage, int expectedResult)
        {
            var result = DrawingBook.pageCount(totalPages, requiredPage);

            Assert.Equal(result, expectedResult);
        }
    }
}
