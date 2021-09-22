using System;

namespace CodingInterview.Domain.Entities.Base
{
    public abstract class Entity<TKey> : IHasKey<TKey>, IAuditable
    {
        public TKey Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}