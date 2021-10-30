using System;
using CodingInterview.Domain.Entities.Base;

namespace CodingInterview.Domain.Entities
{
    public class UserAnswerVersion : Entity<Guid>
    {
        public Guid UserAnswerId { get; set; }
        public Guid? DescriptionId { get; set; }
        public Guid? NextVersionId { get; set; }

        public virtual UserAnswer UserAnswer { get; set; } = default!;
        public virtual Description? Description { get; set; }
        public virtual UserAnswerVersion? NextVersion { get; set; }
    }
}