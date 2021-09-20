using System;
using System.Collections.Generic;
using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Answer : Entity
    {
        public Guid DescriptionId { get; set; }
        public Guid? SuccessInfoId { get; set; }
        public Guid? ErrorInfoId { get; set; }
        public bool IsCorrect { get; set; }

        public virtual ICollection<QuestionVersion> QuestionVersions { get; set; } = new List<QuestionVersion>();
        public virtual Description Description { get; set; } = default!;
        public virtual Description? SuccessInfo { get; set; }
        public virtual Description? ErrorInfo { get; set; }
    }
}