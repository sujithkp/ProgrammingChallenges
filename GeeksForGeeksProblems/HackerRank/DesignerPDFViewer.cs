using System.Collections.Generic;
using System.Linq;

namespace GeeksForGeeksProblems.HackerRank
{
    public class DesignerPDFViewer
    {
        public static int designerPdfViewer(List<int> h, string word)
        {
            var maxHeight = 1;

            foreach(var ch in word)
            {
                if (h[ch - 'a'] > maxHeight)
                    maxHeight = h[ch - 'a'];
            }

            return maxHeight * word.Count();
        }
    }
}
