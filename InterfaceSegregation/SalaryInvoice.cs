using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class PartTimerNetPay : ISalaryCalculate
    {
        public double FullTimerNetPay(double basicPay)
        {
            throw new NotImplementedException();
        }

        //method to calculate part time 
        public double NetPay(double basic)
        {
            int deduction = 1000;
            double netpay = basic * 5 - deduction;
            return netpay;
        }

    }
    //class that calculate full timer salary
    class FullTimerNetPay : ISalaryCalculate
    {
        public double NetPay(double basic)
        {
            int deduction = 3000;
            double netpay = basic * 10 - deduction;
            return netpay;
        }
    }
}