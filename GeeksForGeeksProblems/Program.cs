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
            MaxSubArray.MaxSubArraySum1(new int[] { -2, -3, 4, -1, -2, 1, 5, -3 }, 8);
            MaxSubArray.MaxSubArraySum(new int[] { -2, -3, 4, -1, -2, 1, 5, -3 }, 8);


            MaxSubArray.MaxSubArraySum(new int[] { 1, 2, -2, 3, -4, 7, -15, 20 }, 8);
            //MaxSubArray.MaxSubArraySum(new int[] { -12, -13, -4, -1, -2, -21, -15, -13 }, 8);


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
