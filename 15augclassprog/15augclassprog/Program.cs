using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15augclassprog
{
    class Program
    {
        public static void Main()
        {
            Console.Write("enter 24 hr format: ");
            int input = Convert.ToInt32(Console.ReadLine();
            int hrin24 = Convert.ToInt32(input);
            int hrin12 = hrin24 % 12;
            if(hrin12 == 0)
            {
                hrin12 = 12;
                    }
            string ampmindicator = "";
            if (hrin24>12)
            {
                ampmindicator = "PM";

            }
            else
            {
                ampmindicator = "AM";

            }

            Console.WriteLine("hr in 12hr format is: { 0} { 1}", hrin12, ampmindicator);
            Console.ReadLine();
        }
    }
}
