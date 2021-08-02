using System;
using System.Collections.Generic;


namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface Segregation Principle");
            OperationManagement operation = new OperationManagement();
            List<EmployeeDetails> list = null;
            for (int i = 0; i < 2; i++)
            {
                list = operation.ReadInput();
            }
            operation.GenerateEmployeeReport(list);
        }
    }
}
    }
}
