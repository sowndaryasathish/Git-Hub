using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB_6
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of x and y coordinates");
            Console.WriteLine("x1\nx2\ny1\ny2\n");

            
         
        
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            double z = (((x2 - x1) * (x2 - x1)) +( (y2 - y1) * (y2 - y1)));
            double distance = Math.Sqrt(z);
            Console.WriteLine("The distance is: " + distance);
            Console.ReadLine();
        }
    }
}
