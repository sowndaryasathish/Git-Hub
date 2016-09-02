using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace exerciseG3
{
    
   
    public class Program
    {
        public void Main()

        {
            Console.WriteLine("Enter the string: ");
            string value = Convert.ToString(Console.ReadLine());
            string TitleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
            Console.WriteLine(TitleCase);
            Console.ReadLine();
        }
    }
}
