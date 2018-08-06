using AutoMapper;
using AutoMapper.QueryableExtensions;
using ContactsAPI.Application.Contract;
using ContactsAPI.Application.Contract.Contracts;
using ContactsAPI.DomainModel;
using ContactsAPI.Persistence.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsAPI.Application
{
    public class ContactApplication : IContactApplication
    {
        private readonly IMapper _mapper;

        private readonly IContactRepository _contactRepository;
        public ContactApplication(IContactRepository contactRepository, IMapper mapper)
        {
            _mapper = mapper;
            _contactRepository = contactRepository;
        }

        public IEnumerable<Contacts> GetAll()
        {
            var contacts = _contactRepository.GetAll();
            return _mapper.Map<List<Contacts>>(contacts);
        }

        public Contacts GetById(int id)
        {
            var contact = _contactRepository.GetById(id);
            return _mapper.Map<Contacts>(contact);
        }

        public void Add(AddContact contact)
        {
            Contact contactDto = new Contact(0, contact.FirstName, contact.MiddleName, contact.LastName, contact.Email,
                contact.PhoneNumber, contact.Status, contact.CreatorRID, 0);
            _contactRepository.Add(contactDto);
            int rowsAffected = _contactRepository.SaveChanges();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

    }
}
