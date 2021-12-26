using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems.HackerRank
{
    public class GradingStudentSolution
    {
        public static List<int> GradingStudents(List<int> grades)
        {
            var result = new List<int>();

            foreach (var num in grades)
            {
                if (num < 38)
                {
                    result.Add(num);
                    continue;
                }

                if (5 - num % 5 < 3)
                {
                    result.Add(num + (5 - num % 5));
                    continue;
                }

                result.Add(num);
            }

            return result;
        }
    }
}
