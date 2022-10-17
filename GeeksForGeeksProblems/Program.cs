using GeeksForGeeksProblems.HackerRank;
using System.Collections.Generic;
using System.Linq;

namespace GeeksForGeeksProblems
{
    class Program
    {
        class Chassis
        {
            public string ChassisId { get; set; }

            public string SKU { get; set; }
        }

        static void Main(string[] args)
        {
            int count = SquareIntegers.squares(17, 24);


            //var c = SubArrayCount.GetSubArrayCount(new int[] { 6, -1, -3, 4, -2, 2, 4, 6, -12, -7 });
            SubArrayCount.GetSubArrayCount(new int[] {  0, 0, 5, 5, 0, 0 } );

            return;

            var list = new List<Chassis>();

            list.Add(new Chassis() { ChassisId = "1", SKU = "SKU1" });
            list.Add(new Chassis() { ChassisId = "2", SKU = "SKU2" });
            list.Add(new Chassis() { ChassisId = "1", SKU = "SKU3" });

            var qry = from chassis in list
                      where chassis.ChassisId == "1"
                      group chassis by chassis.ChassisId into chassisGroup
                      select chassisGroup;

            StringBuilding.Run();
        }
    }
}
