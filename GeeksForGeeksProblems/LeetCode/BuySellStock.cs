using System;
using System.Collections.Generic;

namespace GeeksForGeeksProblems.LeetCode
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

        public static List<int> GetMaxProfit(int[] prices)
        {
            List<int> maxprofits = new List<int>();

            int smallestPrice = prices[0];
            int smallestPriceIndex = 0;

            int maxProfit = 0;
            int maxProfitStartIndex = 0;
            int maxProfitEndIndex = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < smallestPrice)
                {
                    smallestPrice = prices[i];
                    smallestPriceIndex = i;
                }

                var profit = prices[i] - smallestPrice;

                if (profit > maxProfit)
                {
                    maxProfit = profit;

                    maxProfitStartIndex = smallestPriceIndex;
                    maxProfitEndIndex = i;
                }
            }

            maxprofits.Add(maxProfitStartIndex);
            maxprofits.Add(maxProfitEndIndex);

            string str = $"Profit is maximum when bought for {prices[maxProfitStartIndex]} and sold for {prices[maxProfitEndIndex]}";

            Console.WriteLine(str);

            return maxprofits;
        }

        public static List<List<int>> GetProfits(int[] prices)
        {
            var list = new List<List<int>>();

            int smallestPrice = prices[0];
            int smallestPriceIndex = 0;

            int profit = 0;

            int previousPrice = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                int currPrice = prices[i];

                if (currPrice < smallestPrice || currPrice < previousPrice)
                {
                    smallestPrice = currPrice;

                    if (profit > 0)
                        list.Add(new List<int>() { smallestPriceIndex, i - 1 });

                    smallestPriceIndex = i;
                    previousPrice = currPrice;
                    profit = 0;

                    continue;
                }

                profit += currPrice - previousPrice;

                previousPrice = currPrice;
            }

            if (profit > 0)
            {
                list.Add(new List<int>() { smallestPriceIndex, prices.Length - 1 });
            }

            return list;
        }
    }
}
