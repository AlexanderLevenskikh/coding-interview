using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class UserQuestionSettingsConfiguration : IEntityTypeConfiguration<UserQuestionSettings>
    {
        public void Configure(EntityTypeBuilder<UserQuestionSettings> builder)
        {
            builder.HasOne(x => x.User)
                .WithMany(x => x.QuestionSettings)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Question)
                .WithMany()
                .HasForeignKey(x => x.QuestionId);
        }
    }
}