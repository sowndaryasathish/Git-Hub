using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseC6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many TV do you want to buy?");
            int tvQty = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("How many DVD do you want to buy?");
            int dvdQty = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("How many MP3 do you want to buy?");
            int mp3Qty = Convert.ToInt16(Console.ReadLine());

            
            Console.WriteLine("The total price of your goods is S${0}", CalculateTotalPrice(tvQty, dvdQty, mp3Qty));
            Console.ReadLine();
        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            
            const double tvPrice = 900;
            const double dvdPrice = 500;
            const double mp3Price = 700;

            

            double totalTvPrice = (double)tvPrice * tvQty;
            double totalDvdPrice = (double)dvdPrice * dvdPrice;
            double totalMp3Price = (double)mp3Price * mp3Qty;

            double totalDiscountPrice = totalTvPrice + totalDvdPrice;

            
            double discount;

            
            if (totalDiscountPrice >= 5000 && totalDiscountPrice < 10000)
                discount = 0.10;
            else if (totalDiscountPrice >= 10000)
                discount = 0.15;
            else
                discount = 0;

            
            double totalPrice = totalMp3Price + (1 - discount) * totalDiscountPrice;

            Console.ReadLine();
            return totalPrice;
        }
    }
}
