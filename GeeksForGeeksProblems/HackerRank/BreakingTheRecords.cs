using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems.HackerRank
{
    public class BreakingTheRecords
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            var minRecord = -1;
            var maxRecord = -1;

            var maxRecordCount = 0;
            var minRecordCount = 0;

            foreach (var score in scores)
            {
                if (minRecord == -1)
                {
                    minRecord = maxRecord = score;
                    continue;
                }

                if (score > maxRecord)
                {
                    maxRecordCount++;
                    maxRecord = score;
                }

                if (score < minRecord)
                {
                    minRecordCount++;
                    minRecord = score;
                }
            }

            return new List<int> { maxRecordCount, minRecordCount };
        }

    }
}
