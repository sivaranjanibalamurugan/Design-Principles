using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDependency
{
    class AccessFactory
    {
        public static IGetAccess GetDetails()
        {
            return new OperationManagement();
        }
    }
}
