﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceException : Exception
    {
        public ExceptionType exception;
        public enum ExceptionType
        {
            INVALID_DISTANCE, INVALID_TIME, INVALID_RIDE_TYPE,
        }
        public InvoiceException(ExceptionType exception, string message) : base(message)
        {
            this.exception = exception;
        }
    }
}