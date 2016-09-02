using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_C1a
{
    public class Program
    {
        public void Main(string[] args)
        {
            int i, n, fact;
            Console.WriteLine("Enter the Number: ");
            n = int.Parse(Console.ReadLine());
            fact = n;
            for (i = n - 1; i <= 1; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("\nFactorial of Given Number is: " + fact);
            Console.ReadLine();
        }
    }
}
