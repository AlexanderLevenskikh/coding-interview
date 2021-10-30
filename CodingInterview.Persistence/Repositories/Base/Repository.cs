using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingInterview.Domain.Entities.Base;
using CodingInterview.Domain.Repositories;
using CodingInterview.Domain.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace CodingInterview.Persistence.Repositories.Base
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : AggregateRoot<TKey>
    {
        protected readonly AppDbContext DbContext;
        protected DbSet<TEntity> DbSet => DbContext.Set<TEntity>(); 

        public IUnitOfWork UnitOfWork => DbContext;

        public Repository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public void AddOrUpdate(TEntity entity)
        {
            if (entity.Id == null || entity.Id.Equals(default(TKey)))
            {
                DbSet.Add(entity);
            }
            else
            {
                DbSet.Update(entity);
            }
        }

        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public Task<T> FirstOrDefaultAsync<T>(IQueryable<T> query)
        {
            return query.FirstOrDefaultAsync();
        }

        public Task<T> SingleOrDefaultAsync<T>(IQueryable<T> query)
        {
            return query.SingleOrDefaultAsync();
        }

        public Task<List<T>> ToListAsync<T>(IQueryable<T> query)
        {
            return query.ToListAsync();
        }
    }
}
