using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class OperationManagement : IOperation
    {
        List<EmployeeDetails> employees;
        public OperationManagement()
        {
            employees = new List<EmployeeDetails>();
        }
        //This class have single responsibility such as reading input
        public List<EmployeeDetails> ReadInput()
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
            //storing object in the list
            employees.Add(details);
            return employees;
        }
        //method to generate report
        public void GenerateEmployeeReport(List<EmployeeDetails> employees)
        {
            foreach (var l in employees)
            {
                Console.WriteLine("Employee Name:" + l.empName);
                Console.WriteLine("Employee Id:" + l.empId);
                Console.WriteLine("Employee Age:" + l.empAge);
                if (l.empType.Equals("Part"))
                    Console.WriteLine("NetPay:" + new PartTimerNetPay().NetPay(l.basicSalary));
                else
                    Console.WriteLine("NetPay:" + new FullTimerNetPay().NetPay(l.basicSalary));
            }
        }

    }
}

