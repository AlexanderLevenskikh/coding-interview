using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using CodingInterview.Domain.Entities.Base;

namespace CodingInterview.Domain.Entities
{
    public class User : AggregateRoot<Guid>
    {
        public int Id { get; set; }
        public string Email { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public Role Role { get; set; }

        [JsonIgnore] public string PasswordHash { get; set; } = default!;

        public virtual ICollection<UserAnswer> Answers { get; set; } = new List<UserAnswer>();
        public virtual ICollection<UserQuestionSettings> QuestionSettings { get; set; } = new List<UserQuestionSettings>();
        public virtual ICollection<QuestionComment> QuestionComments { get; set; } = new List<QuestionComment>();
    }
}