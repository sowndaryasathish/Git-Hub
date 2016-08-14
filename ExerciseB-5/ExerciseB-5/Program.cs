using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB_5
{
    class formula
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any value: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 5*(x * x) - (4 * x) + 3;
            Console.WriteLine("The value of y is " + y);
            Console.ReadLine();

        }
    }
}
