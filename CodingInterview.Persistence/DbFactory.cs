using System;
using Microsoft.EntityFrameworkCore;

namespace CodingInterview.Persistence
{
    public class DbFactory : IDisposable
    {
        private bool _disposed;
        private Func<AppDbContext> _instanceFunc;
        private DbContext? _dbContext;

        public DbFactory(Func<AppDbContext> instanceFunc)
        {
            _instanceFunc = instanceFunc;
        }

        public DbContext DbContext => _dbContext ??= _instanceFunc.Invoke();
        
        public void Dispose()
        {
            if (_disposed || _dbContext == null) return;
            
            _disposed = true;
            _dbContext.Dispose();
        }
    }
}