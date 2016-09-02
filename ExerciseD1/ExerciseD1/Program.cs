using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseD1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.Write("Enter a number (1-100): ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n != 88);

            Console.WriteLine("Lucky you");
            Console.ReadLine();
        }
    }
}
