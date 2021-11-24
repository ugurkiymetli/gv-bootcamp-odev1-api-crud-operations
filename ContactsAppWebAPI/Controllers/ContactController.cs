using ContactsAppWebAPI.ContactsOperations.CreateContact;
using ContactsAppWebAPI.ContactsOperations.DeleteContact;
using ContactsAppWebAPI.ContactsOperations.GetContactDetail;
using ContactsAppWebAPI.ContactsOperations.GetContacts;
using ContactsAppWebAPI.ContactsOperations.UpdateContact;
using ContactsAppWebAPI.DbOperations;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ContactsAppWebAPI.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly ContactAppDbContext _context;
        public ContactController( ContactAppDbContext context )
        {
            _context = context;
        }

        //GetContacts
        [HttpGet]
        public IActionResult GetContacts()
        {
            try
            {
                GetContactsQuery query = new(_context);
                var result = query.Handle();
                return Ok(result);
            }
            catch ( Exception ex )
            {
                return BadRequest(ex.Message);
            }
        }

        //GetById
        [HttpGet("{id}")]

        public IActionResult GetById( int id )
        {
            GetContactDetailModel result;
            try
            {
                GetContactDetailQuery query = new(_context);
                query.id = id;
                GetContactDetailQueryValidator validator = new GetContactDetailQueryValidator();
                validator.ValidateAndThrow(query);
                result = query.Handle();
            }
            catch ( Exception ex )
            {
                return BadRequest(ex.Message);
            }
            return Ok(result);

        }

        //AddContact
        [HttpPost]
        public IActionResult AddContact( [FromBody] CreateContactModel newContact )
        {
            CreateContactCommand command = new(_context);
            try
            {
                command.Model = newContact;
                CreateContactCommandValidator validator = new();
                validator.ValidateAndThrow(command);
                command.Handle();
            }
            catch ( Exception ex )
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        //UpdateContact
        [HttpPut("{id}")]
        public IActionResult UpdateContact( int id, [FromBody] UpdateContactModel updatedContact )
        {
            UpdateContactCommand command = new(_context);
            try
            {
                command.Model = updatedContact;
                command.id = id;
                UpdateContactCommandValidator validator = new();
                validator.ValidateAndThrow(command);
                command.Handle();
            }
            catch ( Exception ex )
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        //DeleteContact
        [HttpDelete("{id}")]
        public IActionResult DeleteContact( int id )
        {

            DeleteContactCommand command = new(_context);
            try
            {
                command.id = id;
                DeleteContactCommandValidator validator = new();
                validator.ValidateAndThrow(command);
                command.Handle();
            }
            catch ( Exception ex )
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
    }
}