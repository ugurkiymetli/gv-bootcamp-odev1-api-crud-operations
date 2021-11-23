using Bootcamp_Project_Dragon.Models;
using Microsoft.EntityFrameworkCore;

namespace Bootcamp_Project_Dragon_API.DbOperations
{
    public class ContactAppDbContext : DbContext
    {
        public ContactAppDbContext( DbContextOptions<ContactAppDbContext> options ) : base(options) { }
        public DbSet<Contact> Contacts { get; set; }
    }
}
