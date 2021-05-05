using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems
{
    public class FunnyString
    {

        public static string funnyString(string s)
        {
            char[] a1 = s.ToCharArray();
            char[] a2 = s.Reverse().ToArray();

            var length = s.Length;
            var funny = true;

            for (int i = 0; i < length - 1; i++)
                funny &= (Math.Abs(a1[i + 1] - a1[i])  == Math.Abs(a2[i] - a2[i + 1]));

            return funny ? "Funny" : "Not Funny";
        }


        public static void Run()
        {
            funnyString("lmnop");
        }

    }
}
