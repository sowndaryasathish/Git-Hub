using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseE6
{
    public class Program
    {
        public static void Main()
        {
            
            int n, factors = 0, i = 1;
            Console.WriteLine("Perfect Numbers From 1 to 1000 are: ");
            for (n = 1; n <= 1000; n++)
            {
                i = 1;
                factors = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        factors = factors + i;
                    i++;
                }
                if (factors == n)
                {
                    Console.WriteLine("{0}", n);
                }
            }
            Console.ReadLine();
        }
    }
}
