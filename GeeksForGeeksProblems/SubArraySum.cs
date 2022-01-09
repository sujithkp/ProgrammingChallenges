using System;

namespace GeeksForGeeksProblems
{
    public class SubArraySum
    {
        public static void Run()
        {
            var arr = new int[] { 193, 55, 70, 82, 66, 68, 114, 194, 35, 73, 173, 31, 102, 43, 178, 78, 171, 103, 165, 182, 191, 24, 38, 24, 180, 196, 170, 128, 43, 111, 183, 59, 127, 88, 71, 129, 52, 59, 14, 61, 184, 87, 143, 11, 73, 129, 35, 42, 119, 104, 68 };

            int sumReq = 150;

            Console.WriteLine("input array : " + FormatArray(arr));
            Console.WriteLine("Sum Required : " + sumReq);

            int startIndex = 0;
            int endindex = 0;

            int sum = 0;

            var found = false;

            while (startIndex < arr.Length)
            {
                Console.WriteLine($"Start {startIndex}, endindex {endindex}, Element {arr[startIndex]}");

                sum = sum + arr[startIndex];

                Console.WriteLine("Sum : " + sum);

                if (sum > sumReq)
                {
                    sum -= arr[endindex];
                    Console.WriteLine($"revised sum : {sum}");

                    if (endindex < startIndex)
                    {
                        sum -= arr[startIndex];
                        Console.WriteLine($"new sum : {sum}");
                        endindex++;

                        continue;
                    }
                    if (endindex == startIndex)
                        endindex++;
                }

                if (sum == sumReq)
                {
                    int[] subArray = new int[startIndex + 1 - endindex];
                    Array.Copy(arr, endindex, subArray, 0, startIndex - endindex + 1);

                    Console.WriteLine("Sub Array : " + FormatArray(subArray));

                    found = true;
                    break;
                }

                startIndex++;
            }

            if (!found)
                Console.WriteLine("SubArray not found.");

            Console.ReadLine();
        }


        private static string FormatArray(int[] arr)
        {
            return ("{" + string.Join(",", arr) + "}");
        }
    }
}
