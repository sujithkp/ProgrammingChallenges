using GeeksForGeeksProblems.HackerRank;
using System;
using System.Collections.Generic;
using Xunit;

namespace ProgrammingChallenges.Tests
{
    public class CompareTripletsTest
    {
        [Fact]
        public void Test1()
        {
            var a = new List<int> { 17, 28, 30 };
            var b = new List<int> { 99, 16, 8 };

            var result = CompareTriplets.compareTriplets(a, b);

            Assert.Equal(2, result.Count);

            Assert.Equal(2, result[0]);
            Assert.Equal(1, result[1]);
        }
    }
}
