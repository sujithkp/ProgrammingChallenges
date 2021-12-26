using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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



        static void Main(string[] args)
        {
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
