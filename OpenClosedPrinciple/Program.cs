using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing the Open Closed Principle");
            CalculateFare calculate = new PremiumFare();
            CalculateFare calculate1 = new NormalFare();
            Console.WriteLine("Fare for premium ride: " + calculate.CalculateFair(10, 15));
            Console.WriteLine("Fare for normal ride: " + calculate1.CalculateFair(10, 15));

        }
    }
}
