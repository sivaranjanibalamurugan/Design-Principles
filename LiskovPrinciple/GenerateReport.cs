using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple
{
    public abstract class Fare
    {
        public abstract double CalculateFare(double distance, int time);

    }
    // to calculate comman fare
    class CalculateFares : Fare
    {
        public override double CalculateFare(double distance, int time)
        {
            double fare = distance * 10 + time * 1;
            return fare;
        }
    }
    //adding new class known premium ride to calculate fare class
    class PremiumFare : Fare
    {
        public override double CalculateFare(double distance, int time)
        {
            double fare = distance * 30 + time * 10;
            return fare;
        }
    }
    //adding new class known normal ride to calculate fare class
    class NormalFare : Fare
    {
        public override double CalculateFare(double distance, int time)
        {
            double fare = distance * 20 + time * 5;
            return fare;
        }
    }
}