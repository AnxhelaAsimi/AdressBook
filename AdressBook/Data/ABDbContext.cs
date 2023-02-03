using AdressBook.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace AdressBook.Data
{
    public class ABDbContext : DbContext
    {
        public ABDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
