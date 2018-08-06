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
        [Route("{id}", Name ="GetById")]
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
        [ProducesResponseType(400)]
        [ProducesResponseType(201)]
        public IActionResult AddContact([FromBody] AddContact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            int createdEntityID = _contactApplication.Add(contact);

            return CreatedAtRoute("GetById", new { id = createdEntityID }, _contactApplication.GetById(createdEntityID));

        }

        [HttpPut]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        public IActionResult UpdateContact([FromBody] UpdateContact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            int rows = _contactApplication.Update(contact);
            if(rows == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult DeleteContact(int id)
        {
            int noOfRows = _contactApplication.Remove(id);

            if(noOfRows == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}