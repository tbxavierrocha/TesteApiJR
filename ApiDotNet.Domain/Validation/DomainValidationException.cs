using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Domain.Validation
{
    internal class DomainValidationException : Exception
    {
        public DomainValidationException(string error) : base(error) 
        { }

        public static void When(bool haserror, string message)
        {
            if (haserror)
                throw new DomainValidationException(message);
        }
    }
}
