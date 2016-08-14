using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the distance travelled: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double totalfare = 2.40 + (x * 0.4);
            double i = Math.Truncate(totalfare);
            double j = totalfare - Math.Truncate(totalfare);
            Console.WriteLine("{0:0.0}", i+ (Math.Ceiling(j)));
            Console.ReadLine();
        }
    }
}
