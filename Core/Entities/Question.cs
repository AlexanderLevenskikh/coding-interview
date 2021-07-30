using System.Collections.Generic;
using Core.Entities.Base;

namespace Core.Entities
{
    public class Question : Entity
    {
        public List<QuestionVersion> QuestionVersions { get; set; } = new();
    }
}