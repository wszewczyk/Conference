using System;

namespace Conf.Core.Abstract.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRepository<T> : IDisposable
        where T : class
    {
        void Add(T entity);

        void AddRange(IEnumerable<T> entities);

        T Get(int id);

        IEnumerable<T> GetAll();

        Task<IEnumerable<T>> GetAllAsync();

        void Update(T entity);

        void UpdateRange(IEnumerable<T> entities);

        void Remove(T entity);

        void Save();

        void RemoveRange(IEnumerable<T> entities);
    }
}
