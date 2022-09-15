//https://practice.geeksforgeeks.org/problems/longest-common-prefix-in-an-array5129/1?page=1&company[]=Microsoft&curated[]=1&sortBy=submissions

using System;
using System.Linq;

namespace GeeksForGeeksProblems
{
    public class LongestCommonPrefix
    {
        public static String longestCommonPrefix(String[] arr, int n)
        {
            int index = 0;
            var firstString = arr[0];

            while (true)
            {
                if (index == firstString.Length) break;

                var noMatch = false;

                for (int i = 1; i < n; i++)
                {
                    if ((arr[i].Length == index) || (firstString[index] != arr[i][index]))
                    {
                        noMatch = true;
                        break;
                    }
                }

                if (noMatch) break;

                index++;
            }

            if (index == 0) return "-1";

            return arr.First().Substring(0, index);
        }
    }
}
