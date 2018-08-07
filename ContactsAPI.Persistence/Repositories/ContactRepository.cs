using ContactsAPI.DomainModel;
using ContactsAPI.Persistence.Contract;
using ContactsAPI.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContactsAPI.Persistence.Repositories
{
    public class ContactRepository : CoreRepository<Contact>, IContactRepository
    {
        public ContactRepository(ContactContext context) : base(context)
        {

        }

        public Contact GetByEmail(string email)
        {
            return dbSet.AsNoTracking().FirstOrDefault(elm => elm.Email == email);
        }

        public Contact GetByPhoneNumber(string phone)
        {
            return dbSet.AsNoTracking().FirstOrDefault(elm => elm.PhoneNumber == phone);
        }

        // TODO: Provide implementation of methods declared in IContactRepository(if any)
    }
}
