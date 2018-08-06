using ContactsAPI.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsAPI.Persistence.Contract
{
    public interface IContactRepository : ICoreRepository<Contact>
    {
    }
}
