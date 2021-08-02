using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    class CalculateFare
    {
        public virtual double CalculateFair(double distance, int time)
        {
            double fare = distance * 10 + time * 1;
            return fare;
        }
    }
    //adding new class - premium ride which extending the calculatefare class
    class PremiumFare : CalculateFare
    {
        public override double CalculateFair(double distance, int time)
        {
            double fare = distance * 30 + time * 10;
            return fare;
        }
    }
    //adding new class known normal ride which extending the calculatefare class
    class NormalFare : CalculateFare
    {
        public override double CalculateFair(double distance, int time)
        {
            double fare = distance * 20 + time * 5;
            return fare;
        }
    }
}

