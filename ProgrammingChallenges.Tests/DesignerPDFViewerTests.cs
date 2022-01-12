using GeeksForGeeksProblems.HackerRank;
using System.Collections.Generic;
using Xunit;

namespace ProgrammingChallenges.Tests
{
    public class DesignerPDFViewerTests
    {
        [Fact]
        public void Test1()
        {
            var result = DesignerPDFViewer.designerPdfViewer(new List<int> { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 }, "zaba");
            Assert.Equal(28, result);
        }

        [Fact]
        public void Test2()
        {
            var result = DesignerPDFViewer.dayOfProgrammer(1800);
        }

    }
}
