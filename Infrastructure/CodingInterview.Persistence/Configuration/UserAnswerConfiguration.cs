using CodingInterview.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodingInterview.Persistence.Configuration
{
    public class UserAnswerConfiguration : IEntityTypeConfiguration<UserAnswer>
    {
        public void Configure(EntityTypeBuilder<UserAnswer> builder)
        {
            builder.HasOne(x => x.Answer)
                .WithMany()
                .HasForeignKey(x => x.AnswerId);

            builder.HasOne(x => x.User)
                .WithMany(x => x.Answers)
                .HasForeignKey(x => x.UserId);
        }
    }
}