using System;
using System.Collections.Generic;
using Core.Entities.Base;

namespace Core.Entities
{
    public class UserAnswer : Entity
    {
        public Guid AnswerId { get; set; }
        public Guid UserId { get; set; }

        public virtual ICollection<UserAnswerVersion> UserAnswerVersions { get; set; } = new List<UserAnswerVersion>();
        public virtual Answer Answer { get; set; } = default!;
        public virtual User User { get; set; } = default!;
    }
}