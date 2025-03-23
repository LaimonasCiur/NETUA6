using Microsoft.EntityFrameworkCore;

namespace Generic_Repository.Entities
{
    public class GenericDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=.;Initial Catalog=EF_Core_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    } 
}
