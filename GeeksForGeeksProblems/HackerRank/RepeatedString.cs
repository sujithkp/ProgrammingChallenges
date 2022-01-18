using System.Linq;

namespace GeeksForGeeksProblems.HackerRank
{
    public class RepeatedString
    {
        public static long repeatedString(string s, long n)
        {
            var numberOfas = s.Count(x => x == 'a');
            var repeatetionRequired = n / s.Length;
            var partsrequired = n % s.Length;
            var asinparts = s.Take((int)partsrequired).Count(x => x == 'a');

            var totalas = numberOfas * repeatetionRequired + asinparts;

            return totalas;
        }

    }
}
