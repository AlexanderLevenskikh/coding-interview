using System;
using System.Collections.Generic;
using CodingInterview.Domain.Entities.Base;

namespace CodingInterview.Domain.Entities
{
    public class Tag : Entity<Guid>
    {
        public string Name { get; set; } = default!;
        public TagType Type { get; set; }
        
        public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}