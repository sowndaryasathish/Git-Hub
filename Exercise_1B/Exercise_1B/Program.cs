using System;

namespace Exercise_1B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. squareroot");
            Console.WriteLine("2. Salary ");
            Console.WriteLine("3. temperature ");
            Console.WriteLine("4. formula ");
            Console.WriteLine("5. arithmetic");
            Console.WriteLine("6. fare");
            Console.WriteLine("7. roundoff");
            Console.WriteLine("8. area");

            Console.Write("Enter Your choice: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    squareRoot();
                    break;
                case 2:
                    salary();
                    break;
                case 3:
                    temperature();
                    break;
                case 4:
                    formula();
                    break;
                case 5:
                    arithmetic();
                    break;
                case 6:
                    fare();
                    break;
                case 7:
                    roundOff();
                    break;
                case 8:
                    area();
                    break;
                default:
                    break;
            }
        }
        static void squareRoot()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("enter the number: ");
                double x = Convert.ToDouble(Console.ReadLine());
                double sqrtx = Math.Sqrt(x);
                Console.WriteLine("SquareRoot of given number is " + sqrtx);
                Console.WriteLine("{0:0.000}", sqrtx);
            }
            Console.ReadLine();

        }
        static void salary()
        {

            Console.Write("Enter The Salary: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double totalsalary = (0.03) * x + (0.10) * x + x;

            Console.WriteLine("The total salary is: s$" + totalsalary);

            Console.ReadLine();
        }

        static void temperature()
        {
            Console.Write("Enter the Temparature in Celsius: ");
            double c = Convert.ToInt32(Console.ReadLine());
            double F = 1.8 * c + 32;
            Console.WriteLine("Fahrenheit value is " + F);
            Console.ReadLine();

        }

        static void formula()
        {
            Console.Write("Enter any value: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 5 * (x * x) - (4 * x) + 3;
            Console.WriteLine("The value of y is " + y);
            Console.ReadLine();

        }
        static void arithmetic()
        {
            Console.WriteLine("Enter the value of x and y coordinates");
            Console.WriteLine("x1\nx2\ny1\ny2\n");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            double z = (((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            double distance = Math.Sqrt(z);
            Console.WriteLine("The distance is: " + distance);
            Console.ReadLine();
        }

        static void fare()
        {
            Console.Write("Enter the distance travelled: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double totalfare = 2.40 + (x * 0.4);
            Console.WriteLine("{0:0.0}", (totalfare));
            Console.ReadLine();
        }
        static void roundOff()
        {
            Console.Write("Enter the distance travelled: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double totalfare = 2.40 + (x * 0.4);
            double roundoffvalue = Math.Pow(10, 1);
            totalfare = Math.Ceiling(totalfare * roundoffvalue) / roundoffvalue;
            Console.WriteLine(totalfare);
            Console.ReadLine();
        }
        static void area()
        {
            Console.Write("Enter the value for a, b, c:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                double s = (a + b + c) / 2;
                double x = (s * (s - a) * (s - b) * (s - c));
                double area = Math.Sqrt(x);
                Console.WriteLine("The area of Triangle is " + area);
            }
            else
            {
                Console.WriteLine("The given values cannot form a triangle");
            }
            Console.ReadLine();

        }
    }
}