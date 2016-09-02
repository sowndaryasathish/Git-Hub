using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace day4quiz
{
    public class Program
    {
        public void Main(string[] args)
        {
            int attempt = 0;
            bool isPINaccepted = false;
            do
            {


                Console.WriteLine("Welcome t Bank of ISS");
                Console.Write("Enter your PIN: ");
                string PIN = Console.ReadLine();
                attempt++;
                if (PIN == "123456")
                {
                    Console.WriteLine("PIN accepted.You can access your account now");
                    isPINaccepted = true;
                    Console.ReadLine();
                }
                else
                {
                    if (attempt < 3)
                    {


                        Console.WriteLine("Incorrect PIN.Try Again");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Too many wrong PIN  entries.Your account is blocked now ");
                        Console.ReadLine();
                    }
                }
            }
            while (!isPINaccepted && attempt < 3);

        }
    }
}

           


            
                   

                







                        
            

        
    

