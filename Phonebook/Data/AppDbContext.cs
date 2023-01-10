using Microsoft.EntityFrameworkCore;

namespace Phonebook.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
