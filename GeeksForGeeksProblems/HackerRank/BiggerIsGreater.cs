using System;
using System.Linq;

namespace GeeksForGeeksProblems.HackerRank
{
    public class BiggerIsGreaterSoution
    {
        public static string BiggerIsGreater(string str)
        {
            string change = null;

            var arr = str.ToArray();

            var largestChangeisAt = -1;

            var changed = true;

            for (int i = str.Length - 1; i > 0; i--)
            {
                if (i < largestChangeisAt)
                    break;

                if (changed)
                    arr = str.ToArray();

                changed = false;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] > arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                        changed = true;

                        if (j > largestChangeisAt)
                        {
                            change = new string(arr);
                            largestChangeisAt = j;
                        }

                        break;
                    }
                }
            }

            if (change == null) return "no answer";

            var maxChange = largestChangeisAt;

            var lastPart = change.Substring(largestChangeisAt + 1, change.Length - largestChangeisAt - 1);

            var lastPartArr = lastPart.ToArray();

            Array.Sort(lastPartArr);

            var firstPart = change.Substring(0, largestChangeisAt + 1);

            return firstPart + new string(lastPartArr);
        }
    }
}
