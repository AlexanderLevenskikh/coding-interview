using System;
using System.Collections.Generic;
using CodingInterview.Domain.Entities.Base;

namespace CodingInterview.Domain.Entities
{
    public class UserAnswer : Entity<Guid>
    {
        public Guid AnswerId { get; set; }
        public Guid UserId { get; set; }

        public virtual ICollection<UserAnswerVersion> UserAnswerVersions { get; set; } = new List<UserAnswerVersion>();
        public virtual Answer Answer { get; set; } = default!;
        public virtual User User { get; set; } = default!;
    }
}