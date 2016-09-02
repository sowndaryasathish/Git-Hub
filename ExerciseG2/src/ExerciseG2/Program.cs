using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseG2
{
    public class Program
    {
       public static bool Palindrome(string[] myString)
        {
            Console.WriteLine("Enter the String: ");
            Console.ReadLine();
          
            
            int length = myString.Length;
             Console.ReadLine();
            for (int i = 0; i < length / 2; i++)
             {
             if (myString[i] != myString[length - i - 1])
             return false;
             }
             return true;

       
            
        }

    }
}

