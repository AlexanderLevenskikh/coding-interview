﻿namespace CodingInterview.Domain.Entities.Base
{
    public interface IHasKey<TKey>
    {
        public TKey Id { get; set; }
    }
}