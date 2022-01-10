using System;
using System.Collections.Generic;
using System.Linq;

namespace GeeksForGeeksProblems.HackerRank
{
    public class BillDivision
    {
        public static void bonAppetit(List<int> bill, int k, int b)
        {
            var total = bill.Sum() - bill[k];

            var share = total / 2;

            if (share == b)
            {
                Console.Write("Bon Appetit");
                return;
            }

            Console.Write( b - share);
        }
    }
}
