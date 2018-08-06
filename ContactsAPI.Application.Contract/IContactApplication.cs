using ContactsAPI.Application.Contract.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsAPI.Application.Contract
{
    public interface IContactApplication
    {
        IEnumerable<Contacts> GetAll();

        Contacts GetById(int id);

        int Add(AddContact contact);

        int Update(UpdateContact contact);

        int Remove(int id);
    }
}
