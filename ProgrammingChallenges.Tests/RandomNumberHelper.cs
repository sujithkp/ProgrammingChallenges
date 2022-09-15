using System;
using System.Linq;

namespace ProgrammingChallenges.Tests
{
    public class RandomNumberHelper
    {
        public static int[] GetRamdomList(int rangeStart, int rangeEnd, int size)
        {
            var random = new Random();
            var randomnums = Enumerable.Range(rangeStart, rangeEnd - rangeStart);
            randomnums = randomnums.OrderBy(t => random.Next());
            return randomnums.Take(size).ToArray();
        }

        public static int GetARandomNumber (int start, int end)
        {
            var random = new Random();
            return random.Next(start, end);
        }
    }
}
