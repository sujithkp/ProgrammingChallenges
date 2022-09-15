using GeeksForGeeksProblems;
using Xunit;

namespace ProgrammingChallenges.Tests
{
    public class SubArrayTest
    {
        [Theory]
        [InlineData()]
        public void Test1()
        {
            var startRange = -5000;
            var endRange = 5000;
            int iteration = 0;

            while (iteration++ < 100)
            {
                var size = RandomNumberHelper.GetARandomNumber(1, endRange);
                var testInput = RandomNumberHelper.GetRamdomList(startRange, endRange, size);

                var maxSum1 = MaxSubArray.MaxSubArraySum1(testInput, testInput.Length);
                var maxSum2 = MaxSubArray.MaxSubArraySum(testInput, testInput.Length);

                Assert.Equal(maxSum1, maxSum2);
            }
        }
    }
}
