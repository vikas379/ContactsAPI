using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsAPI.Application.Contract.Contracts
{
    public class BaseModel
    {
        public int Id { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        public int CreatorRID { get; set; }

        public int ModifierRID { get; set; }

    }
}
