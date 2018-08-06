using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsAPI.Application.Contract;
using ContactsAPI.Application.Contract.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactsAPI.Controllers
{
    [Route("api/contacts/")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactApplication _contactApplication;

        public ContactController(IContactApplication contactApplication)
        {
            _contactApplication = contactApplication;
        }

        [HttpGet]
        public IActionResult GetContacts()
        {
            return Ok(_contactApplication.GetAll());
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetContactById(int id)
        {
            Contacts contact = _contactApplication.GetById(id);

            if(contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        [HttpPost]
        public IActionResult AddContact(AddContact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _contactApplication.Add(contact);

            return Ok();

        }
    }
}