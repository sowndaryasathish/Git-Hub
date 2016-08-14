using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB_3
{
    class Program
    {
        static void Main(string[] args)
        {

           


            Console.Write("Enter The Salary: ");
            double x = Convert.ToDouble(Console.ReadLine());
            
            double totalsalary = (((3.00 / 100) * x ) + ((10.00 / 100) * x) + x);

            Console.WriteLine("The total salary is: $" + totalsalary);
           
            Console.ReadLine();

        }
    }

}
