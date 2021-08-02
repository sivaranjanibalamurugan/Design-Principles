using System;

namespace InversionDependency
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IGetAccess operation = AccessFactory.GetOperationManagementObject();
            operation.GenerateEmployeeReport(operation.GetDetails());

        }
    }
}
    

