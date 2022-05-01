using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class CabInvoiceException : Exception
    {
        // Custom Exception Class to denote the exception  internally generated
        public ExceptionType exceptionType;
        // Exception enum class to initialize the error messages
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE,
            INVALID_DISTANCE,
            INVALID_TIME,
            INVALID_RIDES,
            NULL_RIDE,
            INVALID_USER_ID
        }
        // Parameterised constructor to override the base class message
        public CabInvoiceException(ExceptionType innerException, string message) : base(message)
        {
            this.exceptionType = innerException;
        }
    }

}
