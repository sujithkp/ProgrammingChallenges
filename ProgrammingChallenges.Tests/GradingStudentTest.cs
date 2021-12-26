using GeeksForGeeksProblems.HackerRank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProgrammingChallenges.Tests
{
    public class GradingStudentTest
    {
        [Fact]
        public void Test1()
        {
            var a = new List<int> { 73, 67, 38, 33 };

            var expectedResult = new List<int> { 75, 67, 40, 33 };

            var result = GradingStudentSolution.GradingStudents(a);

            Assert.Equal(result, expectedResult);
        }
    }
}
