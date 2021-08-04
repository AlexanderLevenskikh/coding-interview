using System;
using Core.Entities.Base;

namespace Core.Entities
{
    public class UserQuestionSettings : Entity
    {
        public Guid UserId { get; set; }
        public Guid QuestionId { get; set; }
        public bool IsIgnored { get; set; }
        
        public virtual User User { get; set; } = default!;
        public virtual Question Question { get; set; } = default!;
    }
}