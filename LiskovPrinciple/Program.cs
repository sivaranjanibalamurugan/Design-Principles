using System;
using LiskovPrinciple;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liskov Substitution Principle");
            Fare fare = new CalculateFares();
            Console.WriteLine("Common fare Calculation:" + fare.CalculateFare(40, 10));
            fare = new PremiumFare();
            Console.WriteLine("Premium fare Calculation:" + fare.CalculateFare(40, 10));
            fare = new NormalFare();
            Console.WriteLine("Normal fare Calculation:" + fare.CalculateFare(40, 10));

        }
    }
}