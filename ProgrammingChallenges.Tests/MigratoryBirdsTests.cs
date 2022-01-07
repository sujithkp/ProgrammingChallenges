using GeeksForGeeksProblems.HackerRank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProgrammingChallenges.Tests
{
    public class MigratoryBirdsTests
    {
        [Theory]
        [InlineData()]
        public void Test1()
        {
            var result = MigratoryBirds.migratoryBirds(new List<int> { 1, 4, 4, 4, 5, 3 });

            Assert.Equal(4, result);
        }

        [Theory]
        [InlineData()]
        public void Test2()
        {
            var result = MigratoryBirds.migratoryBirds(new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 });

            Assert.Equal(3, result);
        }
    }
}
