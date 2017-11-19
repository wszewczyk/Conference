using Conf.Core.Abstract.Repositories;

namespace Conf.Infrastructure.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

    public abstract class Repository<T> : IRepository<T>
        where T : class
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _set;

        protected Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _set = dbContext.Set<T>();
        }


        public void Add(T entity)
        {
            _set.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            throw new System.NotImplementedException();
        }

        public T Get(int id)
        {
            return _set.Find(id);
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

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this._dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
