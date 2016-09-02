using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day6Quiz
{
    public class Program
    {
        static int[] minIncomeArray = new int[]
        {20000, 30000,40000,80000,
        120000, 160000,200000,320000};


        static double[] taxRateArray = new double[]

            { 0.02,0.035,0.07,0.115,
        0.15,0.17,0.18,0.20 };
        static int[] basePayableAmountArray = new int[]
            {0,200,550,3350,
            7950,13950,20750,42350};
        static void Main(string[] args)
        {
            int anualIncome = AskForIncome();
            int taxBracket = GetTaxBracket(anualIncome);
            double taxPayable = calculateIncomeTax(anualIncome, taxBracket);
            PrintResult(anualIncome, taxPayable);

        }
        public static int AskForIncome()
        {
            Console.WriteLine("Please Enter the annual Income: ");
            int income = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();


            return income;
        }
            public static int GetTaxBracket(int anualIncome)
        {
            int taxBracket = -1;
            for (int i = 0; i < minIncomeArray.Length; i++)
            {
                if(minIncomeArray[i]<anualIncome)
                {
                    taxBracket = i;

                }
            }return taxBracket;

        }



        public static double calculateIncomeTax(int anualIncome,int taxBracket)
        {
            double payableTax = 0;
            if(taxBracket > -1)
            {
                payableTax = ((anualIncome - minIncomeArray[taxBracket]) * (taxRateArray[taxBracket] + basePayableAmountArray[taxBracket]));

            }return payableTax;

        }
        public static void PrintResult(int income,double payableTax)
        {
            Console.WriteLine("For Taxable anual Income of{0:c}, the tax Payable amount is{1:c}",income, payableTax);
            Console.ReadLine();
        }
        }
        }
    


