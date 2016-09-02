using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseE2
{
    public class Program
    {
        public void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
            Console.WriteLine("\nSquare of the numbers");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * i);
            }
            Console.ReadLine();
            Console.WriteLine("\nInverse of the numbers");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0:0.00}", (1/i));
            }
            Console.ReadLine();
            Console.WriteLine("\nSquareroot of the numbers");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Math.Sqrt(i));
            }
            Console.ReadLine();





        }
        
    }
}
