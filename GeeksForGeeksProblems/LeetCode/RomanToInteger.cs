using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems.LeetCode
{
    public class RomanToInteger
    {
        private const char EMPTY = '\0';

        public int ToInteger(string roman)
        {
            int num = 0;

            var dict = new Dictionary<Char, int>()
            {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100},
                {'D', 500 },
                {'M', 1000 },
            };

            char lastchar = EMPTY;

            var Iprefixed = new char[] { 'V', 'X' };
            var Xprefixed = new char[] { 'L', 'C' };
            var Cprefixed = new char[] { 'D', 'M' };

            for (int i = roman.Length - 1; i >= 0; i--)
            {
                char currChar = roman[i];

                if (lastchar == EMPTY)
                {
                    num += dict[currChar];

                    lastchar = currChar;

                    continue;
                }

                if (currChar == 'I' && Iprefixed.Contains(lastchar))
                {
                    num -= 1;
                    lastchar = EMPTY;
                    continue;
                }

                if (currChar == 'X' && Xprefixed.Contains(lastchar))
                {
                    num -= 10;
                    lastchar = EMPTY;
                    continue;
                }

                if (currChar == 'C' && Cprefixed.Contains(lastchar))
                {
                    num -= 100;
                    lastchar = EMPTY;
                    continue;
                }

                num += dict[currChar];

                lastchar = currChar;
            }

            return num;
        }
    }
}
