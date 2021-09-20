using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasOne(x => x.Description)
                .WithMany()
                .HasForeignKey(x => x.DescriptionId);

            builder.HasOne(x => x.SuccessInfo)
                .WithMany()
                .HasForeignKey(x => x.SuccessInfoId);
            
            builder.HasOne(x => x.ErrorInfo)
                .WithMany()
                .HasForeignKey(x => x.ErrorInfoId);
        }
    }
}