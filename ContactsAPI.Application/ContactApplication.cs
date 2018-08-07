using AutoMapper;
using AutoMapper.QueryableExtensions;
using ContactsAPI.Application.Contract;
using ContactsAPI.Application.Contract.Contracts;
using ContactsAPI.Application.Exceptions;
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

        public int Add(AddContact contact)
        {
            if(_contactRepository.GetByEmail(contact.Email) != null)
            {
                throw new DuplicateEmailException();
            }

            if (_contactRepository.GetByPhoneNumber(contact.PhoneNumber) != null)
            {
                throw new DuplicatePhoneNumber();
            }

            Contact contactDto = new Contact(0, contact.FirstName, contact.MiddleName, contact.LastName, contact.Email,
                contact.PhoneNumber, contact.Status, contact.CreatorRID, 0);
            contactDto.CreationDate = DateTime.UtcNow;

            _contactRepository.Add(contactDto);
            int rowsAffected = _contactRepository.SaveChanges();

            return contactDto.Id;

        }

        public int Update(UpdateContact contact)
        {
            Contact contactDto = _contactRepository.GetById(contact.Id);

            if(contactDto == null)
            {
                throw new NotFoundException();
            }

            var contactByEmail = _contactRepository.GetByEmail(contact.Email);
            if (contactByEmail != null && contactByEmail.Id != contactDto.Id )
            {
                throw new DuplicateEmailException();
            }

            var contactByPhone = _contactRepository.GetByPhoneNumber(contact.PhoneNumber);
            if (contactByPhone != null && contactByPhone.Id != contactDto.Id)
            {
                throw new DuplicatePhoneNumber();
            }


            Contact updateContact = new Contact(contact.Id, contact.FirstName, contact.MiddleName, contact.LastName, contact.Email,
                contact.PhoneNumber, contact.Status, contactDto.CreatorRID, contact.ModifierRID);
            updateContact.CreationDate = contactDto.CreationDate;
            updateContact.ModificationDate = DateTime.UtcNow;

            _contactRepository.Update(updateContact);
            return _contactRepository.SaveChanges();

        }

        public int Remove(int id)
        {
            var contact = _contactRepository.GetById(id);

            if(contact == null)
            {
                throw new NotFoundException();
            }

            _contactRepository.Remove(id);
            return _contactRepository.SaveChanges();

        }

    }
}
