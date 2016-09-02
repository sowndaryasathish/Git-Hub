using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseE3
{
    public class Program
    {
        public void Main(string[] args)

        {
            Console.Write("Enter the Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isPrime(n));
            Console.ReadLine();
        }

        
        public static bool isPrime(int n)
        {
            if(n<2)
            {
                return false;
            }
            bool isPrime = true;    
            for(int i=2;i<=n-1;i++)
            {
                if(n%i ==0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
