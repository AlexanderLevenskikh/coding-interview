using System;
using System.Data;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using CodingInterview.Domain.Entities;
using CodingInterview.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace CodingInterview.Persistence
{
    public class AppDbContext : DbContext, IDbContextMigrate, IUnitOfWork
    {
        private IDbContextTransaction _transaction;
        
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public async Task MigrateAsync()
        {
            await Database.MigrateAsync();
        }

        public IDisposable BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted)
        {
            _transaction = Database.BeginTransaction(isolationLevel);
            return _transaction;
        }

        public async Task<IDisposable> BeginTransactionAsync(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted,
            CancellationToken cancellationToken = default)
        {
            _transaction = await Database.BeginTransactionAsync(isolationLevel, cancellationToken: cancellationToken);
            return _transaction;
        }

        public void CommitTransaction()
        {
            _transaction.Commit();
        }

        public async Task CommitTransactionAsync(CancellationToken cancellationToken = default)
        {
            await _transaction.CommitAsync(cancellationToken);
        }
    }
}