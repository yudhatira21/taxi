using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassDanObject
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumbOfPassenger { get; set; }
        public string status { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Nama Driver : {0}", DriverName);
            if (OnDuty == true)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            Console.WriteLine("On Duty : {0}", status);
            Console.WriteLine("Number Of Passenger : {0}\n", NumbOfPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOfPassenger()
        {
            Console.WriteLine("{0} sedang mengantar penumpang", DriverName);
        }
    }
}
