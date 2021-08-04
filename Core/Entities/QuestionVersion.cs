using System;
using System.Collections.Generic;
using Core.Entities.Base;

namespace Core.Entities
{
    public class QuestionVersion : Entity
    {
        public Guid QuestionId { get; set; }
        public Guid DescriptionId { get; set; }
        public Guid? AdditionalInfoId { get; set; }
        public Guid? NextVersionId { get; set; }

        public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();
        public virtual Question Question { get; set; } = default!;
        public virtual Description Description { get; set; } = default!;
        public virtual Description? AdditionalInfo { get; set; }
        public virtual QuestionVersion? NextVersion { get; set; }
    }
}