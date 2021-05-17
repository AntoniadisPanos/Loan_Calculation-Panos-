using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Calculation_Panos_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Initial loan value: ");
            string InitialLoan = Console.ReadLine();
            Console.Write("How many payments: ");
            string Payments = Console.ReadLine();
            int InitialLoanAsInt = Convert.ToInt32(InitialLoan);
            int PaymentsAsInt = Convert.ToInt32(Payments);

            Console.Write("Percentage of interest rate per year is: ");
            string InterestRate = Console.ReadLine();
            int InterestRateAsInt = Convert.ToInt32(InterestRate);
            double InterestRateAsIntPercent = InterestRateAsInt / 100.0;
            Console.WriteLine();

            Console.WriteLine($"Initial loan value: {InitialLoanAsInt}");

            Console.WriteLine($"Total number of monthly payments: {PaymentsAsInt}");

            double FinalRate = InitialLoanAsInt * InterestRateAsIntPercent;
            double FinalRate1 = 1 + InterestRateAsIntPercent;
            float FinalRate2 = -1 * PaymentsAsInt;
            double FinalRate3 = Math.Pow(FinalRate1, FinalRate2);

            double TotalMonthlyPayment = FinalRate / (1 - FinalRate3);

            Console.WriteLine($"Your final montly payment is: {TotalMonthlyPayment}");

            double FinalLoan = TotalMonthlyPayment * PaymentsAsInt;
            Console.WriteLine($"Your final loan is: {FinalLoan}");

            double TotalInterestrate = FinalLoan - InitialLoanAsInt;

            Console.WriteLine($"Your total interest is: {TotalInterestrate}");
            Console.ReadKey();























        }
    }
}
