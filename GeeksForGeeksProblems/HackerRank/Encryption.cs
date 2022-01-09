using System;
using System.Text;

namespace GeeksForGeeksProblems.HackerRank
{
    public class Encryption
    {
        public static string encryption(string s)
        {
            s = s.Replace(" ", string.Empty);

            double sqrt = Math.Sqrt(s.Length);

            var rows = (int)Math.Ceiling(sqrt);
            var cols = (int)Math.Ceiling(sqrt);

            var matrix = new char[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (((cols * r) + c) >= s.Length)
                        matrix[r, c] = '\0';
                    else
                        matrix[r, c] = s[(cols * r) + c];
                }
            }
            
            StringBuilder strb = new StringBuilder();

            for (int c = 0; c < cols; c++)
            {
                for (int r = 0; r < rows; r++)
                {
                    var ch = matrix[r, c];

                    if (ch == '\0')
                        break;

                    strb.Append(ch);
                }

                strb.Append(" ");
            }

            return strb.ToString().TrimEnd();
        }
    }
}
