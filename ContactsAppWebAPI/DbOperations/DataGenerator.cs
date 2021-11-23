using ContactsApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
namespace ContactsAppWebAPI.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize( IServiceProvider serviceProvider )
        {
            using ( var context = new ContactAppDbContext(serviceProvider.GetRequiredService<DbContextOptions<ContactAppDbContext>>()) )
            {
                //look for Contacts DB
                if ( context.Contacts.Any() )
                    return;// Data was already seeded
                context.Contacts.AddRange(
                    new Contact
                    {
                        ContactID = 1,
                        Name = "Silvanus",
                        Surname = "Carlino",
                        PhoneNumber = "6186536283",
                        ProfilePicture = "http://dummyimage.com/200x200.png/fff",
                    },
                    new Contact
                    {
                        ContactID = 2,
                        Name = "Gannie",
                        Surname = "Torrese",
                        PhoneNumber = "8429607324",
                        ProfilePicture = "http://dummyimage.com/200x200.png/fff",
                    },
                    new Contact
                    {
                        ContactID = 3,
                        Name = "Lissie",
                        Surname = "Wombwell",
                        PhoneNumber = "1078657306",
                        ProfilePicture = "http://dummyimage.com/200x200.png/fff",
                    },
                    new Contact
                    {
                        ContactID = 4,
                        Name = "Bobbee",
                        Surname = "Luppitt",
                        PhoneNumber = "3152299686",
                        ProfilePicture = "http://dummyimage.com/200x200.png/fff",
                    },
                    new Contact
                    {
                        ContactID = 5,
                        Name = "Linnet",
                        Surname = "MacCorkell",
                        PhoneNumber = "3921066098",
                        ProfilePicture = "http://dummyimage.com/200x200.png/fff",
                    },
                    new Contact
                    {
                        ContactID = 6,
                        Name = "Sol",
                        Surname = "Laetham",
                        PhoneNumber = "5132311122",
                        ProfilePicture = "http://dummyimage.com/200x200.png/fff",
                    },
                    new Contact
                    {
                        ContactID = 7,
                        Name = "Brannon",
                        Surname = "Tunbridge",
                        PhoneNumber = "3957222567",
                        ProfilePicture = "http://dummyimage.com/200x200.png/fff",
                    },
                    new Contact
                    {
                        ContactID = 8,
                        Name = "Ashia",
                        Surname = "Bracegirdle",
                        PhoneNumber = "9771322079",
                        ProfilePicture = "http://dummyimage.com/200x200.png/fff",
                    },
                    new Contact
                    {
                        ContactID = 9,
                        Name = "Eunice",
                        Surname = "Skevington",
                        PhoneNumber = "8167207899",
                        ProfilePicture = "http://dummyimage.com/200x200.png/fff",
                    },
                    new Contact
                    {
                        ContactID = 10,
                        Name = "Joli",
                        Surname = "Prozillo",
                        PhoneNumber = "4452608790",
                        ProfilePicture = "http://dummyimage.com/200x200.png/fff",
                    },
                    new Contact
                    {
                        ContactID = 11,
                        Name = "Donnell",
                        Surname = "Fabbri",
                        PhoneNumber = "6155401399",
                        ProfilePicture = "http://dummyimage.com/200x200.png/fff",
                    },
                    new Contact
                    {
                        ContactID = 12,
                        Name = "Shaylynn",
                        Surname = "Beston",
                        PhoneNumber = "9142672643",
                        ProfilePicture = "http://dummyimage.com/200x200.png/fff",
                    },
                    new Contact
                    {
                        ContactID = 13,
                        Name = "Diena",
                        Surname = "Gierth",
                        PhoneNumber = "1858750340",
                        ProfilePicture = "http://dummyimage.com/200x200.png/fff",
                    },
                    new Contact
                    {
                        ContactID = 14,
                        Name = "Armando",
                        Surname = "Reading",
                        PhoneNumber = "4697558840",
                        ProfilePicture = "http://dummyimage.com/200x200.png/fff",
                    },
                    new Contact
                    {
                        ContactID = 15,
                        Name = "Harp",
                        Surname = "Killbey",
                        PhoneNumber = "5913372515",
                        ProfilePicture = "http://dummyimage.com/200x200.png/fff",
                    },
                    new Contact
                    {
                        ContactID = 16,
                        Name = "Elle",
                        Surname = "Rowena",
                        PhoneNumber = "1522825136",
                        ProfilePicture = "http://dummyimage.com/200x200.png/fff",
                    },
                    new Contact
                    {
                        ContactID = 17,
                        Name = "Raf",
                        Surname = "Michie",
                        PhoneNumber = "7948358359",
                        ProfilePicture = "http://dummyimage.com/200x200.png/fff",
                    },
                    new Contact
                    {
                        ContactID = 18,
                        Name = "Smith",
                        Surname = "Boat",
                        PhoneNumber = "7824474755",
                        ProfilePicture = "http://dummyimage.com/200x200.png/fff",
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
