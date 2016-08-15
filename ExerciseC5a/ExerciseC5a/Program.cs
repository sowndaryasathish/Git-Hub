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
            String s = Console.ReadLine();
            Console.WriteLine("length is: " + s.Length);
            number = int.Parse(s);
        
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
