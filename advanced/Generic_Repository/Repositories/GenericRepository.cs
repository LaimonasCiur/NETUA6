using Generic_Repository.Entities;
using Generic_Repository.Entities.Interfaces;
using Generic_Repository.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Generic_Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {
        private readonly GenericDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(GenericDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsEnumerable();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public int Save(T entity)
        {
            if (entity.Id == 0)
            {
                _dbSet.Add(entity);
            }
            else 
            {
                _dbSet.Update(entity);
            }

            _dbContext.SaveChanges();

            return entity.Id;
        }

        public void Dispose() 
        {
           _dbContext?.Dispose();
        }
    }
}
