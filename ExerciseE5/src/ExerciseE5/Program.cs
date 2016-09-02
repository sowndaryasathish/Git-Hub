using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseE5
{
    public class Program
    {
        public void Main(string[] args)

        {

        }

            
     
        public static  bool isPrime(int n)
        { 

            for(n = 5; n<10000; n++)
            if (n < 2)
            {
                return false;
            }
            bool isPrime = true;
            for (int i = 2; i <= n - 1; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
    }
    

