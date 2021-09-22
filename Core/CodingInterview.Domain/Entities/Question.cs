using System;
using System.Collections.Generic;
using CodingInterview.Domain.Entities.Base;

namespace CodingInterview.Domain.Entities
{
    public class Question : Entity<Guid>
    {
        public virtual ICollection<QuestionVersion> QuestionVersions { get; set; } = new List<QuestionVersion>();
        public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();
        public virtual ICollection<QuestionComment> Comments { get; set; } = new List<QuestionComment>();
    }
}