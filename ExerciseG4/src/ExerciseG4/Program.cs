using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseG4
{
    public class Program
    {
        public void Main(string[] args)
        {
            string[] input;
            string[] names = new string[10];
            string[] marks = new string[10];
            int count = 0;



            
          

            for (int i = 0; i <= 10; i++)
            {
                Console.Write("Enter name of student" +(i+1)+":" );
                input = Console.ReadLine().Split(',');

                Console.Write("Enter mark of student " + (i + 1) + ": ");
                input = Console.ReadLine().Split(',');

                //if (input[0] == "e") break;
                //else if (input[0] != "e")
                //{
                    names[i] = input[0];
                    marks[i] = input[1];
               // }


                count++;
            }

            Console.WriteLine("\nStudent  marks");
            Console.WriteLine("=======  ======");
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine(i + " " + names[i] + " " + marks[i]);
            }
        }


    }
}
