using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingInterview.Domain.Entities.Base;

namespace CodingInterview.Domain.Repositories.Base
{
    public interface IRepository<TEntity, in TKey> where TEntity : AggregateRoot<TKey>
    {
        IUnitOfWork UnitOfWork { get; }

        IQueryable<TEntity> GetAll();

        void AddOrUpdate(TEntity entity);

        void Delete(TEntity entity);

        Task<T> FirstOrDefaultAsync<T>(IQueryable<T> query);

        Task<T> SingleOrDefaultAsync<T>(IQueryable<T> query);

        Task<List<T>> ToListAsync<T>(IQueryable<T> query);
    }
}
