using ContactsAppWebAPI.DbOperations;
using System;
using System.Linq;
namespace ContactsAppWebAPI.ContactsOperations.UpdateContact
{
    public class UpdateContactCommand
    {
        public UpdateContactModel Model { get; set; }
        public int id { get; set; }
        private readonly ContactAppDbContext _dbContext;
        public UpdateContactCommand( ContactAppDbContext dBContext )
        {
            _dbContext = dBContext;
        }
        public void Handle()
        {
            var contact = _dbContext.Contacts.SingleOrDefault(contact => contact.ContactID == id);
            if ( contact == null )
                throw new InvalidOperationException("This contact is not found!!");

            contact.Name = Model.Name != default ? Model.Name : contact.Name;
            contact.Surname = Model.Surname != default ? Model.Surname : contact.Surname;
            contact.PhoneNumber = Model.PhoneNumber != default ? Model.PhoneNumber : contact.PhoneNumber;
            contact.ProfilePicture = Model.ProfilePicture != default ? Model.ProfilePicture : contact.ProfilePicture;
            _dbContext.SaveChanges();
        }
    }
}