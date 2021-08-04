using System.Collections.Generic;
using Core.Entities.Base;

namespace Core.Entities
{
    public class Question : Entity
    {
        public virtual ICollection<QuestionVersion> QuestionVersions { get; set; } = new List<QuestionVersion>();
        public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();
        public virtual ICollection<QuestionComment> Comments { get; set; } = new List<QuestionComment>();
    }
}