using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems
{
    public class StringBuilding
    {
        public static string GetSubString(string firstString, string secondString)
        {
            var firstStringLength = firstString.Length;

            if (firstStringLength == 0)
                return string.Empty;

            firstStringLength = secondString.Length < firstString.Length ? secondString.Length : firstStringLength;

            for (int subStrLength = firstStringLength; subStrLength > 0; subStrLength--)
            {
                var subStrInSecondStr = secondString.Substring(0, subStrLength);

                if (firstString.IndexOf(subStrInSecondStr) > -1)
                    return subStrInSecondStr;
            }

            return string.Empty;
        }


        public static int buildString(int a, int b, string s)
        {
            var constructedString = string.Empty;
            var finalString = s;

            var newCost = a;
            var copyCost = b;

            var totalCost = 0;
            var reducedFinalString = finalString;

            while (constructedString != finalString)
            {
                var str1 = GetSubString(constructedString, reducedFinalString);

                var canCopy = str1.Length != 0;

                var nextChar = reducedFinalString.Substring(0, str1.Length == 0 ? 1 : str1.Length);

                var thiscopyCost = canCopy ? copyCost : int.MaxValue;

                var thisNewcharcost = newCost * (str1.Length == 0 ? 1 : str1.Length);

                var charsAdded = 0;

                if (thiscopyCost < thisNewcharcost)
                {
                    Console.WriteLine("Copy : " + str1 + " , "+ thiscopyCost);
                    constructedString += str1;
                    totalCost += thiscopyCost;
                    charsAdded = str1.Length;
                }
                else
                {
                    Console.WriteLine("Add : " + nextChar + " , " + thisNewcharcost); ;
                    constructedString += nextChar;
                    totalCost += thisNewcharcost;
                    charsAdded = nextChar.Length;
                }

                reducedFinalString = reducedFinalString.Substring(charsAdded, reducedFinalString.Length - charsAdded);
            }

            return totalCost;

        }


        public static void Run()
        {
            var cost = buildString(1, 3, "cabcjpsdaedsasedsascabcjpsddsdaedsasedsa");

        }
    }
}



/*
 * 
3
40 1 2
cbaasgcbiikaegcbiidcbaasgcbiikaegcbiidir
40 1 3
cabcjpsdaedsasedsascabcjpsddsdaedsasedsa
40 2 3
cbacojcrojcrlidickjcjcrojcrlijcrojcrrojq
 * 
 * 
 * 
 20
24
45
 * 
 * */