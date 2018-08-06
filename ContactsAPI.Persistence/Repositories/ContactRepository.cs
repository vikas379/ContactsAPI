using ContactsAPI.DomainModel;
using ContactsAPI.Persistence.Contract;
using ContactsAPI.Persistence.DbContexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsAPI.Persistence.Repositories
{
    public class ContactRepository : CoreRepository<Contact>, IContactRepository
    {
        public ContactRepository(ContactContext context) : base(context)
        {

        }

        // TODO: Provide implementation of methods declared in IContactRepository(if any)
    }
}
