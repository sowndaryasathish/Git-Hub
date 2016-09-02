using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseG1
{
    public class Program
    {
        public void Main(string[] args)
        {
            int vowel = 0;
            int i;
            Console.WriteLine("Please enter the string:");
            string str = Console.ReadLine();
            for (i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    vowel++;
                }

                if (str[i] == 'a')
                {
                    vowel++;
                }
                    Console.Write("a:", vowel);
                
            }
            Console.WriteLine("Number of vowels in sentence is :" + vowel);
            
            Console.WriteLine("e:");
            Console.WriteLine("i:");
            Console.WriteLine("o:");
            Console.WriteLine("u:");

            Console.ReadLine();
        }
    }
}
