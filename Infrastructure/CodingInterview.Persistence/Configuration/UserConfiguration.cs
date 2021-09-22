using CodingInterview.Domain.Entities;
using CodingInterview.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodingInterview.Persistence.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(t => t.Email)
                .HasMaxLength(256)
                .TrimmingConversion();

            builder.Property(t => t.UserName)
                .HasMaxLength(256)
                .TrimmingConversion();
            
            builder.Property(t => t.FirstName)
                .HasMaxLength(256)
                .TrimmingConversion();
            
            builder.Property(t => t.LastName)
                .HasMaxLength(256)
                .TrimmingConversion();
            
            builder.Property(t => t.MiddleName)
                .HasMaxLength(256)
                .TrimmingConversion();
            
            builder.Property(x => x.Role)
                .HasConversion<string>();
        }
    }
}