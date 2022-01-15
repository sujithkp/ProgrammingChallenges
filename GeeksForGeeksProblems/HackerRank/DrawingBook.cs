namespace GeeksForGeeksProblems.HackerRank
{
    public class DrawingBook
    {
        public static int pageCount(int n, int p)
        {
            var fromStart = p / 2;
            n = n + (n % 2 == 0 ? 1 : 0);

            var fromEnd = (n - p) / 2;

            if (fromStart < fromEnd)
                return fromStart;

            return fromEnd;
        }
    }
}
