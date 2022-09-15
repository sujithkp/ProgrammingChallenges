using System;

namespace GeeksForGeeksProblems
{
    public class MaxSubArray
    {
        public static int MaxSubArraySum1(int[] arr, int size)
        {
            int maxsofar = arr[0];
            int currmax = arr[0];

            for (int i = 1; i < size; i++)
            {
                currmax = Math.Max(arr[i], currmax + arr[i]);
                maxsofar = Math.Max(maxsofar, currmax);
            }

            return maxsofar;
        }

        public static int MaxSubArraySum(int[] arr, int size)
        {
            int maxsofar = arr[0];
            int currmax = arr[0];
            int startIndex = 0;
            int endIndex = 0;

            for (int i = 1; i < size; i++)
            {
                if (arr[i] > currmax + arr[i])
                {
                    currmax = arr[i];
                    startIndex = i;
                }
                else
                {
                    currmax += arr[i];
                }

                if (currmax > maxsofar)
                {
                    maxsofar = currmax;
                    endIndex = i;
                } 
            }

            //  Console.WriteLine(maxsofar);
            //  Console.WriteLine(string.Join(",", arr.Skip(startIndex).Take(endIndex + 1 - startIndex)));

            return maxsofar;
        }

    }
}
