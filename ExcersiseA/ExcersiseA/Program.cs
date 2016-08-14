using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcersiseA
{
    class excersise
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Print Name");
            Console.WriteLine("2. Square of a Number");
            Console.WriteLine("3. Decimal Square");
            Console.WriteLine("4. Double Precision to Decimal");
            Console.Write("Enter Your choice: ");
            

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    printName();
                    break;
                case 2:
                    square();
                    break;
                case 3:
                    decimalsquare();
                    break;
                case 4:
                    formatdecimal();
                    break;
                default:
                    break;
            }
        }

        static void square()
        {
            Console.Write("Enter the number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The square of " + x + " is: " + (x * x));
            Console.ReadLine();
        }
        
        static void printName()
        {
            Console.Write("Name:");
            String name = Console.ReadLine();
            Console.Write("Email:");
            String email = Console.ReadLine();
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Good Morning " + name);
            Console.WriteLine(email);
            Console.ReadLine();
        }
        static void decimalsquare()
        {
            Console.Write("Enter the decimal number: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The square of " + x + " is: " + (x * x));
            Console.ReadLine();
        }
        static void formatdecimal()
        {
            for (int i = 0; i < 4; i++) {
                Console.Write("Enter the double precision number: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("{0:0.00}", x);
            }
            Console.ReadLine();
        }
    }
}
