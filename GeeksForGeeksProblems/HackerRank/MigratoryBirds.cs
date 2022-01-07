using System.Collections.Generic;
using System.Linq;

namespace GeeksForGeeksProblems.HackerRank
{
    public class MigratoryBirds
    {
        public static int migratoryBirds(List<int> arr)
        {
            int maxocc = -1;
            int minele = -1;

            foreach (var distinctEle in arr.Distinct())
            {
                var occ = arr.Count(x => x == distinctEle);

                if (occ > maxocc)
                {
                    maxocc = occ;
                    minele = distinctEle;
                }

                if (occ == maxocc && distinctEle < minele)
                {
                    minele = distinctEle;
                }
            }

            return minele;
        }
    }
}
