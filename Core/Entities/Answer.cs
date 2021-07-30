using System;
using Core.Entities.Base;

namespace Core.Entities
{
    public class Answer : Entity
    {
        public Guid DescriptionId { get; set; }
        public Guid? SuccessInfoId { get; set; }
        public Guid? ErrorInfoId { get; set; }
        public bool IsCorrect { get; set; }

        public Answer(Guid descriptionId, bool isCorrect)
        {
            DescriptionId = descriptionId;
            IsCorrect = isCorrect;
        }
    }
}