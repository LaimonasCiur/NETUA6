using Generic_Repository.Entities;
using Generic_Repository.Repositories;

using var dbContext = new GenericDbContext();
using var orderRepository = new OrderRepository(dbContext);
var orderItemRepository = new OrderItemRepository(dbContext);

orderRepository.Save(new Order());
orderRepository.Find(x => x.DateCreated == new DateTime());
orderItemRepository.GetAll();
orderItemRepository.GetById(1);
orderItemRepository.Dispose();