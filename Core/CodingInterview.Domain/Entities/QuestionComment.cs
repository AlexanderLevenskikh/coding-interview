using System;
using CodingInterview.Domain.Entities.Base;

namespace CodingInterview.Domain.Entities
{
    public class QuestionComment : AggregateRoot<Guid>
    {
        public Guid QuestionId { get; set; }
        public Guid UserId { get; set; }
        public Guid DescriptionId { get; set; }

        public virtual Question Question { get; set; } = default!;
        public virtual User User { get; set; } = default!;
        public virtual Description Description { get; set; } = default!;
    }
}