using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day5Quiz_array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] theArray = new int[]
            {
                5,3,2,9,2,9,
                5,1,7,1,8,3,
                0,3,2,2,9,7

            };
            int count = 0;
            Console.Write("Please enter a number (0-9)");
            int number = Convert.ToInt32(Console.ReadLine());
        }
        public static void Main(string[] args)
            
        int count = 0;
        for( int = 0;i<theArray;i++)
            {
            if(theArray[i] == number)
            {
            count = count+1:
            }
}
if(count > 0)
    {
    Console.WriteLine("The occurence of a number entered is ",number,count);

    }
    else
    Console.WriteLine("The Entered number is not in the array");

}
