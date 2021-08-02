using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    //This interface has method only related to pay calculation
    interface ISalaryCalculate
    {
        double PartTimerNetPay(double basicPay);
        double FullTimerNetPay(double basicPay);
    }
    //it related to other operation
    interface IOperation
    {
        List<EmployeeDetails> ReadInput();
        void GenerateEmployeeReport(List<EmployeeDetails> list);
    }

}