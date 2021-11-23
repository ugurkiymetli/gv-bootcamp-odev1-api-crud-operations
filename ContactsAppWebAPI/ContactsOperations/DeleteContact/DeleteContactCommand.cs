
using ContactsAppWebAPI.DbOperations;
using System;
using System.Linq;
namespace ContactsAppWebAPI.ContactsOperations.DeleteContact
{
    public class DeleteContactCommand
    {
        public int id { get; set; }
        private readonly ContactAppDbContext _dbContext;
        public DeleteContactCommand( ContactAppDbContext dBContext )
        {
            _dbContext = dBContext;
        }
        public void Handle()
        {
            var contact = _dbContext.Contacts.SingleOrDefault(contact => contact.ContactID == id);
            if ( contact == null )
                throw new InvalidOperationException("This contact is not found!!");
            _dbContext.Contacts.Remove(contact);
            _dbContext.SaveChanges();
        }
    }
}