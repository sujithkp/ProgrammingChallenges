using GeeksForGeeksProblems.HackerRank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProgrammingChallenges.Tests
{
    public class BreakingTheRecordTests
    {
        [Theory]
        [InlineData("10 5 20 20 4 5 2 25 1", "2 4")] 
        [InlineData("3 4 21 36 10 28 35 5 24 42", "4 0")]
        public void Test1(string str, string expectedResult)
        {
            var testInput = str.Split(' ');

            var expectedResults = expectedResult.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(x => int.Parse(x));

            var recordCount = BreakingTheRecords.breakingRecords(testInput.Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(x => int.Parse(x)).ToList());

            var index = 0;

            foreach(var r in expectedResults)
            {
                Assert.Equal(r, recordCount[index]);
                index++;
            }
        }
    }
}
