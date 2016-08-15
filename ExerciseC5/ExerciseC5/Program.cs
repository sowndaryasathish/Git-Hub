using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseC5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a three-digit integer: ");
            string number =Console.ReadLine();
            Console.WriteLine("{0} {1} is an Armstrong number", number, ArmstrongNumber(number));
        }
        public static string ArmstrongNumber(string number)
        {
           
            string number1 = number.Substring(0, 1);
            string number2 = number.Substring(1, 1);
            string number3 = number.Substring(2, 1);

            
            double num1 = Convert.ToDouble(number1);
            double num2 = Convert.ToDouble(number2);
            double num3 = Convert.ToDouble(number3);

           
            double tribleSum = Math.Pow(num1, 3) + Math.Pow(num2, 3) + Math.Pow(num3, 3);

            
            double num = Convert.ToDouble(number);
            string ArmstrongNumber;

            if (num == tribleSum)
            {
                resultArmstrongNumber = "is";
            }
            else
            {
                ArmstrongNumber = "is not ";
            }

            return ArmstrongNumber;

        }
    }
}
