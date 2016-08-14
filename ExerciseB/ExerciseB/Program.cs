using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB
{
    class Program
    {
        static void Main(string[] args)
        {
            squareroot();
        }
        static void squareroot()
            {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("enter the number: ");
                double x = Convert.ToDouble(Console.ReadLine());
                double sqrtx = Math.Sqrt(x);
                Console.WriteLine("SquareRoot of given number is " + sqrtx);
                Console.WriteLine("{0:0.000}", sqrtx);
            }
                Console.ReadLine();
            
            }



    }
}
