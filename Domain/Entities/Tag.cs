using System.Collections.Generic;
using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Tag : Entity
    {
        public string Name { get; set; } = default!;
        public TagType Type { get; set; }
        
        public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}