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
            //BuySellStock.GetMaxProfit(new int[] { 100, 180, 260, 310, 40, 535, 695 });

            //BuySellStock.GetMaxProfit(new int[] { 100, 30, 15, 10, 8, 25, 80 });

            var result = BuySellStock.stockBuySell1(new int[] { 822, 754, 1689, 305, 214, 782, 1463, 1432, 1382, 1734,
                    948, 231, 210, 1676, 877, 670, 1384, 725, 1370, 412, 724, 371, 928, 358, 533, 1031, 850,
                    1555, 1064, 845, 1692, 514, 630, 1333, 1640, 315, 1639, 1792, 1779, 1325, 1619, 1400,
                    378, 145, 913, 901, 1652, 530, 1259, 880, 303,685, 1586 }, 53);

            var resultStr = String.Join("," , result.SelectMany(x => x));


            var result2 = BuySellStock.GetProfits(new int[] { 822, 754, 1689, 305, 214, 782, 1463, 1432, 1382, 1734,
                    948, 231, 210, 1676, 877, 670, 1384, 725, 1370, 412, 724, 371, 928, 358, 533, 1031, 850,
                    1555, 1064, 845, 1692, 514, 630, 1333, 1640, 315, 1639, 1792, 1779, 1325, 1619, 1400,
                    378, 145, 913, 901, 1652, 530, 1259, 880, 303,685, 1586 });

            resultStr = String.Join(",", result2.SelectMany(x => x));

            BuySellStock.MaxProfitFromstockBuySell(new int[] { 4, 2, 2, 2, 4 });

            BuySellStock.MaxProfitFromstockBuySell(new int[] { 100, 180, 260, 310, 40, 535, 695 });

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
