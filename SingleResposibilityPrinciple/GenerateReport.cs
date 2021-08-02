using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResposibilityPrinciple
{
    class GenerateReport
    {
        //this class has single responsibility such as Generate report
        public void GenerateEmployeeReport(List<EmployeeDetails> employeeDetails)
        {
            foreach (var l in employeeDetails)
            {
                Console.WriteLine("Employee Name:" + l.empName);
                Console.WriteLine("Employee Id:" + l.empId);
                Console.WriteLine("Employee Age:" + l.empAge);
            }
        }
    }
}
