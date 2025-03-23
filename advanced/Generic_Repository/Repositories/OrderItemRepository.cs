using Generic_Repository.Entities;

namespace Generic_Repository.Repositories
{
    public class OrderItemRepository : GenericRepository<OrderItem>, IDisposable
    {
        private readonly GenericDbContext _genericDbContext;

        public OrderItemRepository(GenericDbContext dbContext) : base(dbContext)
        {
            _genericDbContext = dbContext;
        }

        public void Add(OrderItem item) 
        {
            _genericDbContext.Add(item);
        }
    }
}
