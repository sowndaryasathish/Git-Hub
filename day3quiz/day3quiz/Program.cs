using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length in cm: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double length = x / 2.54;
            Console.WriteLine("The length converted to inch is " + "{0:0.000}", length);
            Console.ReadLine();

        }
    }
}
