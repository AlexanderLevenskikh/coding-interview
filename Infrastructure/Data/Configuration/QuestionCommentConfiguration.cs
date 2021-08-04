using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class QuestionCommentConfiguration : IEntityTypeConfiguration<QuestionComment>
    {
        public void Configure(EntityTypeBuilder<QuestionComment> builder)
        {
            builder.HasOne(x => x.Question)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.QuestionId);

            builder.HasOne(x => x.User)
                .WithMany(x => x.QuestionComments)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Description)
                .WithOne()
                .HasForeignKey<QuestionComment>(x => x.DescriptionId);
        }
    }
}