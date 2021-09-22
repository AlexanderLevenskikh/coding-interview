using System;
using CodingInterview.Domain.Entities.Base;

namespace CodingInterview.Domain.Entities
{
    public class UserQuestionSettings : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid QuestionId { get; set; }
        public bool IsIgnored { get; set; }
        
        public virtual User User { get; set; } = default!;
        public virtual Question Question { get; set; } = default!;
    }
}