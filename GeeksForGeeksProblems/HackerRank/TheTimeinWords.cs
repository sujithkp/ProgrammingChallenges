using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems.HackerRank
{
    public class TheTimeinWords
    {
        private static string[] words = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve" };

        private static Dictionary<int, string> mins = new Dictionary<int, string>()
        {
            { 11, "eleven" },
            { 12, "twelve" },
            { 13, "thirteen" },
            { 14, "fourteen" },
            { 15, "fifteen" },
            { 16, "sixteen" },
            { 17, "seventeen" },
            { 18,"eighteen" },
            { 19,"nineteen" }
        };


        private static readonly string oClock = "o' clock";

        public static string timeInWords(int h, int m)
        {
            if (m == 0)
                return words[h - 1] + " " + oClock;

            if (m == 15)
                return "quarter past " + words[h - 1];

            if (m == 30)
                return "half past " + words[h - 1];

            if (m == 45)
                return "quarter to " + words[h];

            if (m == 1)
                return words[m - 1] + " minute past " + words[h - 1];

            if (m < 30 && m <= 10)
                return words[m - 1] + " minutes past " + words[h - 1];

            if (m > 10 && m < 20)
                return mins[m] + " minutes past " + words[h - 1];

            if (m > 20 && m < 30)
                return "twenty " + words[m - 20 - 1] + " minutes past " + words[h - 1];

            if (m > 30 && 60 - m > 20)
                return "twenty " + words[60 - m - 20 - 1] + " minutes to " + words[h ];

            if (m > 30 && 60 - m > 10)
                return mins[60 - m] + " minutes to " + words[h ];


            if (m > 30 && 60 - m <= 10)
                return words[60 - m - 1] + " minutes to " + words[h ];


            return string.Empty;
        }

    }
}
