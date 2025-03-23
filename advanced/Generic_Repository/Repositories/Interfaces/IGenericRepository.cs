using Generic_Repository.Entities.Interfaces;
using System.Linq.Expressions;

namespace Generic_Repository.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class, IEntity
    {
        public T GetById(int id);
        public IEnumerable<T> GetAll();
        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        public int Save(T entity);
    }
}
