using ContactsApp.Models;
using ContactsAppWebAPI.DbOperations;
using System;
using System.Linq;

namespace ContactsAppWebAPI.ContactsOperations.CreateContact
{
    public class CreateContactCommand
    {
        public CreateContactModel Model { get; set; }
        private readonly ContactAppDbContext _dbContext;
        public CreateContactCommand( ContactAppDbContext dBContext )
        {
            _dbContext = dBContext;
        }
        public void Handle()
        {
            var contact = _dbContext.Contacts.SingleOrDefault(book => book.PhoneNumber == Model.PhoneNumber);
            if ( contact is not null )
                throw new InvalidOperationException("This contact already exists!!");

            contact = new Contact
            {
                Name = Model.Name,
                Surname = Model.Surname,
                PhoneNumber = Model.PhoneNumber,
                ProfilePicture = Model.ProfilePicture
            };
            _dbContext.Contacts.Add(contact);
            _dbContext.SaveChanges();
        }
    }
}