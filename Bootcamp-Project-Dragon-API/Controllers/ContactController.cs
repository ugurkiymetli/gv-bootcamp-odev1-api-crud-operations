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
                Id= 1,
                Name= "Silvanus",
                Surname= "Carlino",
                PhoneNumber= "6186536283",
                ProfilePicture= "http://dummyimage.com/x.png/ff4444/ffffff",
              },
              new Contact{
                Id= 2,
                Name= "Gannie",
                Surname= "Torrese",
                PhoneNumber= "8429607324",
                ProfilePicture= "http://dummyimage.com/x.png/cc0000/ffffff",
              },
              new Contact{
                Id= 3,
                Name= "Lissie",
                Surname= "Wombwell",
                PhoneNumber= "1078657306",
                ProfilePicture= "http://dummyimage.com/x.png/5fa2dd/ffffff",
              },
              new Contact{
                Id= 4,
                Name= "Bobbee",
                Surname= "Luppitt",
                PhoneNumber= "3152299686",
                ProfilePicture= "http://dummyimage.com/x.png/dddddd/000000",
              },
              new Contact{
                Id= 5,
                Name= "Linnet",
                Surname= "MacCorkell",
                PhoneNumber= "3921066098",
                ProfilePicture= "http://dummyimage.com/x.png/5fa2dd/ffffff",
              },
              new Contact{
                Id= 6,
                Name= "Sol",
                Surname= "Laetham",
                PhoneNumber= "5132311122",
                ProfilePicture= "http://dummyimage.com/x.png/cc0000/ffffff",
              },
              new Contact{
                Id= 7,
                Name= "Brannon",
                Surname= "Tunbridge",
                PhoneNumber= "3957222567",
                ProfilePicture= "http://dummyimage.com/x.png/cc0000/ffffff",
              },
              new Contact{
                Id= 8,
                Name= "Ashia",
                Surname= "Bracegirdle",
                PhoneNumber= "9771322079",
                ProfilePicture= "http://dummyimage.com/x.png/5fa2dd/ffffff",
              },
              new Contact{
                Id= 9,
                Name= "Eunice",
                Surname= "Skevington",
                PhoneNumber= "8167207899",
                ProfilePicture= "http://dummyimage.com/x.png/ff4444/ffffff",
              },
              new Contact{
                Id= 10,
                Name= "Joli",
                Surname= "Prozillo",
                PhoneNumber= "4452608790",
                ProfilePicture= "http://dummyimage.com/x.png/ff4444/ffffff",
              },
              new Contact{
                Id= 11,
                Name= "Donnell",
                Surname= "Fabbri",
                PhoneNumber= "6155401399",
                ProfilePicture= "http://dummyimage.com/x.png/cc0000/ffffff",
              },
              new Contact{
                Id= 12,
                Name= "Shaylynn",
                Surname= "Beston",
                PhoneNumber= "9142672643",
                ProfilePicture= "http://dummyimage.com/x.png/cc0000/ffffff",
              },
              new Contact{
                Id= 13,
                Name= "Diena",
                Surname= "Gierth",
                PhoneNumber= "1858750340",
                ProfilePicture= "http://dummyimage.com/x.png/5fa2dd/ffffff",
              },
              new Contact{
                Id= 14,
                Name= "Armando",
                Surname= "Reading",
                PhoneNumber= "4697558840",
                ProfilePicture= "http://dummyimage.com/x.png/cc0000/ffffff",
              },
              new Contact{
                Id= 15,
                Name= "Harp",
                Surname= "Killbey",
                PhoneNumber= "5913372515",
                ProfilePicture= "http://dummyimage.com/x.png/cc0000/ffffff",
              },
              new Contact{
                Id= 16,
                Name= "Elle",
                Surname= "Rowena",
                PhoneNumber= "1522825136",
                ProfilePicture= "http://dummyimage.com/x.png/ff4444/ffffff",
              },
              new Contact{
                Id= 17,
                Name= "Raf",
                Surname= "Michie",
                PhoneNumber= "7948358359",
                ProfilePicture= "http://dummyimage.com/x.png/ff4444/ffffff",
              },
              new Contact{
                Id= 18,
                Name= "Smith",
                Surname= "Boat",
                PhoneNumber= "7824474755",
                ProfilePicture= "http://dummyimage.com/x.png/dddddd/000000",
              },
        };

        [HttpGet]
        public List<Contact> GetContacts()
        {
            var contacts = ContactList.OrderBy(c => c.Id).ToList<Contact>();
            return contacts;
        }

        [HttpGet("{id}")]

        public Contact GetById( int id )
        {
            var contact = ContactList.Where(c => c.Id == id).SingleOrDefault();
            return contact;
        }
    }
}
