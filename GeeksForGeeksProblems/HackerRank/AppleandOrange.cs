using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems.HackerRank
{
    public class AppleandOrange
    {
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            var applesCount = 0;
            var orangeCount = 0;

            foreach(var apple in apples)
            {
                if (apple + a >= s && apple + a <= t)
                    applesCount++;
            }

            foreach (var orange in oranges)
            {
                if (orange + b >= s && orange + b <= t)
                    orangeCount++;
            }

            Console.WriteLine(applesCount);
            Console.WriteLine(orangeCount);

        }
    }
}
