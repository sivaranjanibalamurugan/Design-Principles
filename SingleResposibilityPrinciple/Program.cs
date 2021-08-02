using System;
using System.Collections.Generic;


namespace SingleResposibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Single Responsibility Principle");
            List<EmployeeDetails> list = null;
            OperationManagement operation = new OperationManagement();
            for (int i = 0; i < 5; i++)
            {

                list = operation.ReadInput();
            }
            GenerateReport generate = new GenerateReport();
            generate.GenerateEmployeeReport(list);
        }
    }
}
