using System;
using System.Threading.Tasks;

namespace CodingInterview.Persistence
{
    public interface IDbContextMigrate : IDisposable
    {
        Task MigrateAsync();
    }
}