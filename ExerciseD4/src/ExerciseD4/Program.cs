using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseD4
{
    public class Program
    {
        public void Main(string[] args)
        {
         
        
                Console.Write("Enter a number: ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(SQT(n));
            Console.ReadLine();
            }

        public static double SQT(double n)
        {
           
            Random random = new Random(); 
            double g = random.NextDouble() * (n - 1) + 1;

            while (Math.Abs(g * g - n) > 0.00001)
            { 
                g = (g + n / g) / 2;
            }
            return g;
        }
    }
}
