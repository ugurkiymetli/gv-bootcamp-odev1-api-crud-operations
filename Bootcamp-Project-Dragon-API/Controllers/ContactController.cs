using Bootcamp_Project_Dragon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Bootcamp_Project_Dragon_API.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private static List<Contact> ContactList = new List<Contact>()
        {
             new Contact{
                ContactID= 1,
                Name= "Silvanus",
                Surname= "Carlino",
                PhoneNumber= "6186536283",
                ProfilePicture= "http://dummyimage.com/200x200.png/fff",
              },
              new Contact{
                ContactID= 2,
                Name= "Gannie",
                Surname= "Torrese",
                PhoneNumber= "8429607324",
                ProfilePicture= "http://dummyimage.com/200x200.png/fff",
              },
              new Contact{
                ContactID= 3,
                Name= "Lissie",
                Surname= "Wombwell",
                PhoneNumber= "1078657306",
                ProfilePicture= "http://dummyimage.com/200x200.png/fff",
              },
              new Contact{
                ContactID= 4,
                Name= "Bobbee",
                Surname= "Luppitt",
                PhoneNumber= "3152299686",
                ProfilePicture= "http://dummyimage.com/200x200.png/fff",
              },
              new Contact{
                ContactID= 5,
                Name= "Linnet",
                Surname= "MacCorkell",
                PhoneNumber= "3921066098",
                ProfilePicture= "http://dummyimage.com/200x200.png/fff",
              },
              new Contact{
                ContactID= 6,
                Name= "Sol",
                Surname= "Laetham",
                PhoneNumber= "5132311122",
                ProfilePicture= "http://dummyimage.com/200x200.png/fff",
              },
              new Contact{
                ContactID= 7,
                Name= "Brannon",
                Surname= "Tunbridge",
                PhoneNumber= "3957222567",
                ProfilePicture= "http://dummyimage.com/200x200.png/fff",
              },
              new Contact{
                ContactID= 8,
                Name= "Ashia",
                Surname= "Bracegirdle",
                PhoneNumber= "9771322079",
                ProfilePicture= "http://dummyimage.com/200x200.png/fff",
              },
              new Contact{
                ContactID= 9,
                Name= "Eunice",
                Surname= "Skevington",
                PhoneNumber= "8167207899",
                ProfilePicture= "http://dummyimage.com/200x200.png/fff",
              },
              new Contact{
                ContactID= 10,
                Name= "Joli",
                Surname= "Prozillo",
                PhoneNumber= "4452608790",
                ProfilePicture= "http://dummyimage.com/200x200.png/fff",
              },
              new Contact{
                ContactID= 11,
                Name= "Donnell",
                Surname= "Fabbri",
                PhoneNumber= "6155401399",
                ProfilePicture= "http://dummyimage.com/200x200.png/fff",
              },
              new Contact{
                ContactID= 12,
                Name= "Shaylynn",
                Surname= "Beston",
                PhoneNumber= "9142672643",
                ProfilePicture= "http://dummyimage.com/200x200.png/fff",
              },
              new Contact{
                ContactID= 13,
                Name= "Diena",
                Surname= "Gierth",
                PhoneNumber= "1858750340",
                ProfilePicture= "http://dummyimage.com/200x200.png/fff",
              },
              new Contact{
                ContactID= 14,
                Name= "Armando",
                Surname= "Reading",
                PhoneNumber= "4697558840",
                ProfilePicture= "http://dummyimage.com/200x200.png/fff",
              },
              new Contact{
                ContactID= 15,
                Name= "Harp",
                Surname= "Killbey",
                PhoneNumber= "5913372515",
                ProfilePicture= "http://dummyimage.com/200x200.png/fff",
              },
              new Contact{
                ContactID= 16,
                Name= "Elle",
                Surname= "Rowena",
                PhoneNumber= "1522825136",
                ProfilePicture= "http://dummyimage.com/200x200.png/fff",
              },
              new Contact{
                ContactID= 17,
                Name= "Raf",
                Surname= "Michie",
                PhoneNumber= "7948358359",
                ProfilePicture= "http://dummyimage.com/200x200.png/fff",
              },
              new Contact{
                ContactID= 18,
                Name= "Smith",
                Surname= "Boat",
                PhoneNumber= "7824474755",
                ProfilePicture= "http://dummyimage.com/200x200.png/fff",
              },
        };

        [HttpGet]
        public List<Contact> GetContacts()
        {
            var contacts = ContactList.OrderBy(c => c.ContactID).ToList<Contact>();
            return contacts;
        }

        [HttpGet("{id}")]

        public Contact GetById( int id )
        {
            var contact = ContactList.Where(c => c.ContactID == id).SingleOrDefault();
            return contact;
        }

        [HttpPost]
        public IActionResult AddContact( [FromBody] Contact newContact )
        {
            var contact = ContactList.SingleOrDefault(c => c.PhoneNumber == newContact.PhoneNumber || c.ContactID == newContact.ContactID);
            if ( contact is not null )
            {
                return BadRequest();
            }

            ContactList.Add(newContact);
            return Ok();
        }

        [HttpPut("{id}")]
        //Bir Database ile çalışırken root'dan id vermeyiz, ama şimdilik listelerle çalıştığımız için böyle yaptık.
        public IActionResult UpdateContact( int id, [FromBody] Contact updatedContact )
        {
            var contact = ContactList.SingleOrDefault(c => c.ContactID == id);
            if ( contact is null )
                return BadRequest();

            contact.Name = updatedContact.Name != default
                ? updatedContact.Name
                : contact.Name;
            contact.Surname = updatedContact.Surname != default
                ? updatedContact.Surname
                : contact.Surname;
            contact.PhoneNumber = updatedContact.PhoneNumber != default ?
                updatedContact.PhoneNumber
                : contact.PhoneNumber;
            contact.ProfilePicture = updatedContact.ProfilePicture != default ?
                updatedContact.ProfilePicture
                : contact.ProfilePicture;
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteContact( int id )
        {
            var contact = ContactList.SingleOrDefault(c => c.ContactID == id);
            if ( contact is null )
                return BadRequest();
            ContactList.Remove(contact);
            return Ok();
        }

    }
}
