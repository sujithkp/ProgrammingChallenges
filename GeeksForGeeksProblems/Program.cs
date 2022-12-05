using GeeksForGeeksProblems.HackerRank;
using GeeksForGeeksProblems.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems
{
    class Program
    {
        class Chassis
        {
            public string ChassisId { get; set; }

            public string SKU { get; set; }
        }

        public static void Main(string[] args)
        {
            SomeBulkyTask(5);

            Console.WriteLine("over");
            Console.ReadLine();
        }

        long TotalAllEvenNumbers(int[] intArray)
        {
            return intArray.Where(n => n % 2 == 0).Sum();
        }

        static Task<int> SomeBulkyTaskAsyn(int a)
        {
            return Task.Factory.StartNew(() => SomeBulkyTask(a));
        }

        static int SomeBulkyTask(int s)
        {
            Console.WriteLine("xxxxxx");
            Thread.Sleep(10000);

            return 1;
        }

        static void STGLab(string[] args)
        {

            var r = findnonperishable(new List<Ingredient>()
            {
                new Ingredient() { name = "some", IsPre = false, Description = "des"}
            });

            var n = r[0].name;


            Thread t1 = new Thread(new Racer("1").Run);
            Thread t2 = new Thread(new Racer("2").Run);
            Thread t3 = new Thread(new Racer("3").Run);
            Thread t4 = new Thread(new Racer("4").Run);
            Thread t5 = new Thread(new Racer("5").Run);


            t5.Start();
            t3.Start();
            t1.Start();
            t3.Join();
            t2.Start();
            t1.Join();
            t4.Start();
            t2.Join();
            t4.Join();
            t5.Join();


            Console.ReadLine();
        }

        public static void Sort(ref int a, ref int b)
        {
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
        }

        public static List<(string name, string description)> findnonperishable(List<Ingredient> ings)
        {
            var result = ings.Where(i => !i.IsPre)
                .Select(x => (x.name, x.Description))
                .ToList();

            return result;
        }

        public static IEnumerable<char> OrderChars(params string[] strings)
        {
            return strings.SelectMany(str => str.ToCharArray()).Where(chr => char.IsLetter(chr)).OrderBy(chr => chr);
        }
    }


    //asked during Wipro Interview
    //static classes can have static constructors - I was right.
    public static class StaticClass
    {
        static StaticClass()
        {


        }
    }

    public interface SomeInterface
    {
      //  public int SomeField; // not possible
    }

    public class Ingredient
    {
        public string name { get; set; }

        public string Description { get; set; }

        public bool IsPre { get; set; }

    }

    class Racer
    {
        private readonly string name;

        public Racer(string name)
        {
            this.name = name;
        }

        public void Run()
        {
            Thread.Sleep(100);
            Console.WriteLine(name);
        }
    }
}
