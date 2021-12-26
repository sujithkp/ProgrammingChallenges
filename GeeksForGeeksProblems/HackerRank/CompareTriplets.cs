using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems.HackerRank
{
    public class CompareTriplets
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int suma = 0;
            int sumb = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i]) suma += 1;

                if (b[i] > a[i]) sumb += 1;

            }

            return new List<int> { suma, sumb };
        }
    }
}
