using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value for a, b, c:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                double s = (a + b + c) / 2;
                double x = (s * (s - a) * (s - b) * (s - c));
                double area = Math.Sqrt(x);
                Console.WriteLine("The area of Triangle is " + area);
            }
            else
            {
                Console.WriteLine("The given values cannot form a triangle");
            }
            Console.ReadLine();

        }
    }
}
