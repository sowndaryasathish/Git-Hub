using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseC4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the distance(km): ");
            double distance = (Console.ReadLine());
            distance = Math.Ceiling(10 * distance) / 10;
            Console.WriteLine("The total fare is S${0:0.00}", CalculateFare(distance));
            Console.ReadLine();
        }
        public static double CalculateFare(double distance)
        {

            double fare;


            if (distance <= 0.5)
            {
                fare = 2.40;
            }
            else if (distance <= 9)
            {
                fare = 2.40 + (10 * distance - 5) * 0.04;
            }
            else
            {
                fare = 2.40 + 85 * 0.04 + (10 * distance - 90) * 0.05;
            }

            return fare;
        }
    }
}
