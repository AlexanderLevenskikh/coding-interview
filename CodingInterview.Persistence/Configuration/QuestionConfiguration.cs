using CodingInterview.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodingInterview.Persistence.Configuration
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasMany(x => x.Tags)
                .WithMany(x => x.Questions)
                .UsingEntity(t => t.ToTable("QuestionsWithTags"));
        }
    }
}