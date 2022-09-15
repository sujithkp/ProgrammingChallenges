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
          //  var count = ZeroSumSubArray.GetSizeOfLargestZeroSumSubArray1(new int[] { 1, -1, 3, 2, -2, -8, 4, 3, 2, 1, 10, 23 });

          //  count = ZeroSumSubArray.GetSizeOfLargestZeroSumSubArray(new int[] { 15, -2, 2, -8, 1, 7, 10, 23 });
            var count = ZeroSumSubArray.GetSizeOfLargestZeroSumSubArray1(new int[] { -341, 778, -826, -153, -574, -289, -993, -622, -989, -695, 150, -692, 755, -150, -586, -123, 960, -182, -605, 168, -635, 47, -108, 126, 158, 71, -584, -482, 565, -51, 369, -431, 431, 467, 305, 572, -793, 276, 639, -706, 574, 158, 894, -849, 979, -959, 432, -25, 712, -897, -476, 661, 791, 880, -686, -278, 364, -123, 429, -65, 230, 459, -770, -872, 330, -202, -944, 783, -502, 869, -246, -154, -935, 572, 959, -475, 18, -198, -769 });

            var count1 = ZeroSumSubArray.GetSizeOfLargestZeroSumSubArray(new int[] { -1, 1 ,- 1 ,1 });
 return;


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
