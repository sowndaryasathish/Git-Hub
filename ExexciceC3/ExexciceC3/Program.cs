using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExexciceC3
{
    class Grades
    {
       static void Main(string[] args)
        {
            Console.Write("Enter your mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());
            string grade = CalculateGrade(mark);
            Console.WriteLine("You scored {0} Marks which is {1} grade. ", mark, grade);
            Console.ReadLine();
        }
        static string CalculateGrade(int mark)
        {
            string grade;
            if (mark <= 100 && mark >= 80)
            {
                grade = "A";
            }
            else if (mark <= 79 && mark >= 60)
            {
                grade = "B";
            }
            else if (mark <= 59 && mark >= 40)
            {
                grade = "C";
            }
            else if (mark <= 39 && mark >= 0)
            {
                grade = "F";
            }
            else
            {
                grade = "**Error**";
            }
            return grade;
        }
    }
}
