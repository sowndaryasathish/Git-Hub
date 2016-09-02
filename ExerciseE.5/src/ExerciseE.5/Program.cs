using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseE._5
{
    public class Program
    {
        public void Main(string[] args)
        {
            
    
                Console.WriteLine("Below are prime numbers between 5 and 10000!");
              
                for (int i = 5; i <= 10000; i++)
                {
                    bool isPrime = true;
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                        break;
                        }
                    }
                if (isPrime)
                    {
                        Console.WriteLine(i);
                    Console.ReadLine();
                    }
                }
            }
        }
    
}
