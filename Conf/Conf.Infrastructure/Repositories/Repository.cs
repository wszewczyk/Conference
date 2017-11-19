using Conf.Core.Abstract.Repositories;

namespace Conf.Infrastructure.Repositories
{
    using System.Collections.Generic;
    using System.Data;
    using System.Threading.Tasks;

    public abstract class Repository<T> : IRepository<T>
        where T : class
    {
        public void Add(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void AddRange(IEnumerable<T> entities)
        {
            throw new System.NotImplementedException();
        }

        public T Get(int id)
        {
            return null;
        }

        public IEnumerable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            throw new System.NotImplementedException();
        }
    }
}
