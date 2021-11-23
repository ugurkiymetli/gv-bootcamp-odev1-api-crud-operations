using ContactsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsAppWebAPI.DbOperations
{
    public class ContactAppDbContext : DbContext
    {
        public ContactAppDbContext( DbContextOptions<ContactAppDbContext> options ) : base(options) { }
        public DbSet<Contact> Contacts { get; set; }
    }
}
