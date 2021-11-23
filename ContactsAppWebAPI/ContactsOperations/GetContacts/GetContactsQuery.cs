using ContactsApp.Models;
using ContactsAppWebAPI.DbOperations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactsAppWebAPI.ContactsOperations.GetContacts
{
    public class GetContactsQuery
    {
        public GetContactsModel Model { get; set; }
        private readonly ContactAppDbContext _dbContext;
        public GetContactsQuery( ContactAppDbContext dBContext )
        {
            _dbContext = dBContext;
        }
        public List<GetContactsModel> Handle()
        {
            var contactList = _dbContext.Contacts.OrderBy(contact => contact.ContactID).ToList<Contact>();
            if ( contactList == null )
                throw new InvalidOperationException("No contact are found!!");
            List<GetContactsModel> contactViewModel = new List<GetContactsModel>();
            foreach ( var contact in contactList )
            {
                contactViewModel.Add(new GetContactsModel()
                {
                    Name = contact.Name,
                    Surname = contact.Surname,
                    PhoneNumber = contact.PhoneNumber,
                    ProfilePicture = contact.ProfilePicture,
                });
            }
            return contactViewModel;
        }
    }
}