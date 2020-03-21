using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugasclassdanobjek
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName          =      "jono";
            taxi.OnDuty              =      true;
            taxi.NumPassanger        =      10;


            taxi.TaxiInfo();
            Console.WriteLine();
            taxi.PickUpPassanger();
            taxi.DropOffPassanger();

            Console.ReadKey();

        }
    }
}
