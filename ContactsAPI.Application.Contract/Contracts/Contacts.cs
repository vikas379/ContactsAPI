using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsAPI.Application.Contract.Contracts
{
    public class Contacts : BaseModel
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Status { get; set; }

    }
}
