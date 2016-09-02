using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseD3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomNumber = random.Next(0, 9);
            int Guess;
            int attempt = 1;
            Console.WriteLine("Guess The Number Between 0 and 9: ");
            Guess = Convert.ToInt32(Console.ReadLine());
            while (randomNumber != Guess)
            {
                Console.WriteLine("Try again!!!\n ");
                Guess = Convert.ToInt32(Console.ReadLine());
                attempt++;
            } 

            if (attempt <= 2)
            {
                Console.WriteLine("You are a Wizard");
            }
            else if (attempt <= 5)
            {
                Console.WriteLine("You are a Good Guess");
            }
            else
            {
                Console.WriteLine("You are a Lousy.");
            }
            Console.ReadLine();
        }    

        
    }
}
