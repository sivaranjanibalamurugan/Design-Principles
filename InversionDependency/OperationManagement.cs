using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDependency
{
    class OperationManagement : IGetAccess
    {

        //This class have single responsibility such as reading input
        //gets details from the user
        public EmployeeDetails GetDetails()
        {
            EmployeeDetails details = new EmployeeDetails();
            Console.WriteLine("Enter employee Name:");
            details.empName = Console.ReadLine();
            Console.WriteLine("Enter employee Id:");
            details.empId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee age:");
            details.empAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter basic salary:");
            details.basicSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter employement type:");
            details.empType = Console.ReadLine();
            return details;
        }
        //method to generate report
        public static void GenerateEmployeeReport(EmployeeDetails employees)
        {

            Console.WriteLine("Employee Name:" + employees.empName);
            Console.WriteLine("Employee Id:" + employees.empId);
            Console.WriteLine("Employee Age:" + employees.empAge);
            if (employees.empType.Equals("Part"))
                Console.WriteLine("NetPay:" + new PartTimerNetPay().NetPay(employees.basicSalary));
            else
                Console.WriteLine("NetPay:" + new FullTimerNetPay().NetPay(employees.basicSalary));

        }


    }
}

