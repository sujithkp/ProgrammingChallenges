//https://practice.geeksforgeeks.org/problems/largest-subarray-with-0-sum/1?page=1&company[]=Microsoft&curated[]=1&sortBy=submissions

using System;
using System.Collections.Generic;
using System.Linq;

namespace GeeksForGeeksProblems
{
    public class ZeroSumSubArray
    {
        public static int GetSizeOfLargestZeroSumSubArray(int[] arr)
        {
            var sum = 0;
            var count = 0;

            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (sum == 0) { count = i + 1; continue; }

                if (!dictionary.Keys.Contains(sum))
                    dictionary.Add(sum, i);
                else
                    count = Math.Max(i - dictionary[sum], count);
            }

            return count;
        }

        public static int GetSizeOfLargestZeroSumSubArray1(int[] arr)
        {
            var subArrays = new List<List<int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr.Skip(i).Take(j + 1).Sum() == 0)
                    {
                        subArrays.Add(arr.Skip(i).Take(j + 1).ToList());
                    }
                }
            }

            return subArrays.Max(list => list.Count());
        }
    }
}
