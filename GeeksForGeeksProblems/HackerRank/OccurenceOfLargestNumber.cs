using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems.HackerRank
{
    public class OccurenceOfLargestNumber
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int occ = 1;
            int largest = candles[0];

            for (int i = 1; i < candles.Count; i++)
            {
                if (candles[i] == largest)
                    occ++;

                if (candles[i] > largest)
                    largest = candles[i];
            }

            return occ;
        }
    }
}
