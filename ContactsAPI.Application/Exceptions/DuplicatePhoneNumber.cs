using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsAPI.Application.Exceptions
{
    public class DuplicatePhoneNumber : Exception
    {
        public DuplicatePhoneNumber()
        { }

        public DuplicatePhoneNumber(string message)
            : base(message)
        { }

        public DuplicatePhoneNumber(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
