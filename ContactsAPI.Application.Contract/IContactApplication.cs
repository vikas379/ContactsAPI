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

        void Add(AddContact contact);

        void Update();

        void Remove(int id);
    }
}
