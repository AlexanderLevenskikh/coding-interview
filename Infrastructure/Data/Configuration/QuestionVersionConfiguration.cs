using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class QuestionVersionConfiguration : IEntityTypeConfiguration<QuestionVersion>
    {
        public void Configure(EntityTypeBuilder<QuestionVersion> builder)
        {
            builder.HasMany(x => x.Answers)
                .WithMany(x => x.QuestionVersions)
                .UsingEntity(t => t.ToTable("QuestionVersionsWithAnswers"));

            builder.HasOne(x => x.Question)
                .WithMany(x => x.QuestionVersions)
                .HasForeignKey(x => x.QuestionId);
            
            builder.HasOne(x => x.Description)
                .WithMany()
                .HasForeignKey(x => x.DescriptionId);
            
            builder.HasOne(x => x.AdditionalInfo)
                .WithMany()
                .HasForeignKey(x => x.AdditionalInfoId);
            
            builder.HasOne(x => x.Question)
                .WithMany(x => x.QuestionVersions)
                .HasForeignKey(x => x.QuestionId);
            
            builder.HasOne(x => x.NextVersion)
                .WithOne()
                .HasForeignKey<QuestionVersion>(x => x.NextVersionId);
        }
    }
}