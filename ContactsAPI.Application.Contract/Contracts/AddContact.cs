using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ContactsAPI.Application.Contract.Contracts
{
    public class AddContact : ContactCommand
    {
        public int CreatorRID { get; set; }

    }
}
