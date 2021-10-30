using System;
using CodingInterview.Domain.Entities.Base;

namespace CodingInterview.Domain.Entities
{
    public class Description : Entity<Guid>
    {
        public string Content { get; set; } = default!;
    }
}