using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class UserAnswerVersionConfiguration : IEntityTypeConfiguration<UserAnswerVersion>
    {
        public void Configure(EntityTypeBuilder<UserAnswerVersion> builder)
        {
            builder.HasOne(x => x.UserAnswer)
                .WithMany(x => x.UserAnswerVersions)
                .HasForeignKey(x => x.UserAnswerId);

            builder.HasOne(x => x.Description)
                .WithMany()
                .HasForeignKey(x => x.DescriptionId);

            builder.HasOne(x => x.NextVersion)
                .WithOne()
                .HasForeignKey<UserAnswerVersion>(x => x.NextVersionId);
        }
    }
}