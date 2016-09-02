using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseC5a
{
    class Program
    {
        static void Main(string[] args)
        {

            int number, r, sum = 0;
            Console.Write("enter the three digit Number: ");

            number = int.Parse(Console.ReadLine());
            double n = Convert.ToDouble(Console.ReadLine());
            double length = Math.Floor(Math.Log10(n) + 1);
            Console.ReadLine();
            if (length == 3)
            {
                Console.WriteLine("Press enter");

            }
            else
                Console.WriteLine("wrong number. enter three digit number");
            Console.ReadLine();
            
           

            for (int i = number; i > 0; i = i / 10)
            {
                r = i % 10;
                sum = sum + r * r * r;

            }
            if (sum == number)
            {
                Console.Write("TRUE");
            }

            else
                Console.Write("FALSE");
            Console.ReadLine();
        }
    }
}
