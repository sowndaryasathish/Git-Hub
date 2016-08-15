using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your gender (M/F): ");
            string gender = Console.ReadLine();
            Console.Write("Enter your Age: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            if (gender == "M")
            {
                if (Age > 40)
                    Console.WriteLine("GoodMorning Uncle {0}",name);
                else
                    Console.WriteLine("GoodMorning Mr.{0}" ,name);
                Console.ReadLine();

            }
            else if (gender == "F")
            {
                if (Age > 40)

                    Console.WriteLine("GoodMorning Aunty {0}" , name);
                else

                    Console.WriteLine("GoodMorning Ms.{0}" , name);
                Console.ReadLine();
            }




        }
    }
}
