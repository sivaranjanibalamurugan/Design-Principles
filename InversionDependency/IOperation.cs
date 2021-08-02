using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDependency
{
    
   
        interface ISalaryCalculate
        {
            double NetPay(double basicPay);
        }

        public interface IGetAccess
        {
            EmployeeDetails GetDetails();
        }
    
}
