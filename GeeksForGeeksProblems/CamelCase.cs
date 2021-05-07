using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems
{
    public class CamelCase
    {
        public static int camelcase(string s)
        {
            return  s.Where(x => x >= 'A' && x <= 'Z').Count() + 1;
        }

        public static void Run()
        {
            camelcase("saveChangesInTheEditor");
        }

    }
}
