using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB_4
{
    class Temperature
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Temparature in Celsius: ");
            double c = Convert.ToInt32(Console.ReadLine());
            double F = 1.8*c+32;
            Console.WriteLine("Fahrenheit value is " + F);
            Console.ReadLine();

        }

    }
}
