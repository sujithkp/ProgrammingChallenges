using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems.HackerRank
{
    public class BiggerIsGreater
    {
        public static string biggerIsGreater(string w)
        {
            var arr = w.ToArray();

            var found = false;
            var foundat = -1;

            var newStr = string.Empty;

            for (int i = arr.Length - 1; i > 0; i-- )
            {
                var currChar = arr[i];

                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] > arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                        found = true;

                        foundat = j + 1;

                        break;
                    }
                }

                if (found) break;
            }

            if (!found) return "no answer";

            var finalArray = new List<char>();

            finalArray.AddRange(arr.Take(foundat ));

            var newArray = arr.Skip(foundat).Take(arr.Length - foundat).ToArray();

            Array.Sort(newArray);

            finalArray.AddRange(newArray);

            return string.Join(string.Empty, finalArray);
        } 
    }
}
