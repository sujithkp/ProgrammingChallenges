using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems
{
    public class BuySellStock
    {
        public static List<List<int>> MaxProfitFromstockBuySell(int[] prices)
        {
            var sharePair = new List<List<int>>();

            int smallestPrice = prices[0];
            int largestPrice = prices[0];
            int maxProfit = 0;

            var maxprofits = new List<int>();

            var smallestPriceIndex = 0;
            int largestPriceIndex = 0;


            for (int i = 1; i < prices.Length; i++)
            {
                int profit = prices[i] - smallestPrice;

                if (prices[i] <= smallestPrice)
                {
                    if (maxProfit > 0)
                    {
                        sharePair.Add(new List<int>() { smallestPriceIndex, largestPriceIndex });
                        maxprofits.Add(maxProfit);
                    }

                    largestPriceIndex = smallestPriceIndex = i;
                    largestPrice = smallestPrice = prices[i];
                    maxProfit = 0;
                }

                if (prices[i] > largestPrice)
                {
                    largestPrice = prices[i];

                    maxProfit = largestPrice - smallestPrice;

                    largestPriceIndex = i;
                }
            }

            if (maxProfit > 0)
            {
                maxprofits.Add(maxProfit);
                sharePair.Add(new List<int> { smallestPriceIndex, largestPriceIndex });
            }

            return sharePair;
        }
    }
}
