using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResposibilityPrinciple
{
    class OperationManagement
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
            //storing objet in the list
            employees.Add(details);
            return employees;
        }
    }
}
