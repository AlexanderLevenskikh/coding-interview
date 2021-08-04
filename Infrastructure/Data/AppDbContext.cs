using System.Reflection;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext, IDbContextSet, IDbContextMigrate
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Answer> Answers => Set<Answer>();
        public DbSet<Description> Descriptions => Set<Description>();
        public DbSet<Question> Questions => Set<Question>();
        public DbSet<QuestionComment> QuestionComments => Set<QuestionComment>();
        public DbSet<QuestionVersion> QuestionVersions => Set<QuestionVersion>();
        public DbSet<Tag> Tags => Set<Tag>();
        public DbSet<User> Users => Set<User>();
        public DbSet<UserAnswer> UserAnswers => Set<UserAnswer>();
        public DbSet<UserAnswerVersion> UserAnswerVersions => Set<UserAnswerVersion>();
        public DbSet<UserQuestionSettings> UserQuestionSettings => Set<UserQuestionSettings>();
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public async Task MigrateAsync()
        {
            await Database.MigrateAsync();
        }
    }
}