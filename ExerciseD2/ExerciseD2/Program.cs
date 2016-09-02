using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseD2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int hcf = 0;
            int lcm = 0;

            CalculateHCFAndLCM(a, b, ref hcf, ref lcm);

            Console.WriteLine("HCF:" + hcf);
            Console.WriteLine("LCM:" + lcm);
            Console.ReadLine();
        }

        public static void CalculateHCFAndLCM(int a, int b, ref int hcf, ref int lcm)
        {


            int larger = Math.Max(a, b);
            int smaller = Math.Min(a, b);

            while (larger != smaller)
            {
                larger =larger - smaller;
                if (larger < smaller)
                {
                    var temp = smaller;
                    smaller = larger;
                    larger = temp;
                }
            }

            hcf =larger;
            lcm = (a * b) / hcf;


        }
    }
}