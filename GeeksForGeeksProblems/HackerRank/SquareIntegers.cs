using System;

namespace GeeksForGeeksProblems.HackerRank
{
    public class SquareIntegers
    {
        public static int squares(int a, int b)
        {
            var start = Math.Ceiling(Math.Sqrt(a));
            var end = Math.Floor(Math.Sqrt(b));

            return (int)(end - start + 1);
        }
    }
}
