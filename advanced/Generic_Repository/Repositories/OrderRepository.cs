using Generic_Repository.Entities;

namespace Generic_Repository.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IDisposable
    {
        public OrderRepository(GenericDbContext context) : base(context){ }
    }
}
