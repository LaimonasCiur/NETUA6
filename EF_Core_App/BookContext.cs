using Microsoft.EntityFrameworkCore;

namespace EF_Core_App
{
    public class BookContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=.;Initial Catalog=EF_Core_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;");
        }
    }
}
