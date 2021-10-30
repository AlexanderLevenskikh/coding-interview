using System;
using Microsoft.EntityFrameworkCore;

namespace CodingInterview.Persistence
{
    public interface IDbContextSet : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}