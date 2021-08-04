using System;
using Core.Entities.Base;

namespace Core.Entities
{
    public class QuestionComment : Entity
    {
        public Guid QuestionId { get; set; }
        public Guid UserId { get; set; }
        public Guid DescriptionId { get; set; }

        public virtual Question Question { get; set; } = default!;
        public virtual User User { get; set; } = default!;
        public virtual Description Description { get; set; } = default!;
    }
}