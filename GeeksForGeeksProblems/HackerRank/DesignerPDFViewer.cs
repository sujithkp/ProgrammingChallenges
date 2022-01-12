using System.Collections.Generic;
using System.Linq;

namespace GeeksForGeeksProblems.HackerRank
{
    public class DesignerPDFViewer
    {
        public static int designerPdfViewer(List<int> h, string word)
        {
            var maxHeight = 1;

            foreach (var ch in word)
            {
                if (h[ch - 'a'] > maxHeight)
                    maxHeight = h[ch - 'a'];
            }

            return maxHeight * word.Count();
        }

        public static string dayOfProgrammer(int year)
        {
            if (year < 1917 && year % 4 == 0)
                return "12.09." + year;

            if (year == 1918)
                return "26.09." + year;

            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                return "12.09." + year;
           
            return "13.09." + year;
        }
    }
}
