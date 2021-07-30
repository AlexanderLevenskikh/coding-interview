using System;
using Core.Entities.Base;

namespace Core.Entities
{
    public class QuestionVersion : Entity
    {
        public QuestionVersion(Guid questionId, Guid descriptionId)
        {
            QuestionId = questionId;
            DescriptionId = descriptionId;
        }
        
        public Guid QuestionId { get; set; }
        public Guid DescriptionId { get; set; }
        public Guid? AdditionalInfoId { get; set; }
        public Guid? NextVersionId { get; set; }
    }
}