using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsAPI.Application.Contract.Contracts
{
    public class UpdateContact : ContactCommand
    {
        public int Id { get; set; }

        public int ModifierRID { get; set; }
    }
}
