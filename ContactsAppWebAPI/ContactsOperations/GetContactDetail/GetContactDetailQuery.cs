using ContactsAppWebAPI.DbOperations;
using System;
using System.Linq;

namespace ContactsAppWebAPI.ContactsOperations.GetContactDetail
{
    public class GetContactDetailQuery
    {
        public GetContactDetailModel Model { get; set; }
        public int id { get; set; }
        private readonly ContactAppDbContext _dbContext;
        public GetContactDetailQuery( ContactAppDbContext dBContext )
        {
            _dbContext = dBContext;
        }
        public GetContactDetailModel Handle()
        {
            var contact = _dbContext.Contacts.Where(contact => contact.ContactID == id).SingleOrDefault();
            if ( contact == null )
                throw new InvalidOperationException("This contact is not found!!");

            GetContactDetailModel contactViewModel = new()
            {
                Name = contact.Name,
                Surname = contact.Surname,
                PhoneNumber = contact.PhoneNumber,
                ProfilePicture = contact.ProfilePicture,
            };
            return contactViewModel;
        }
    }
}