using System;

namespace Core.Entities.Base
{
    public interface IRemovableEntity
    {
        public DateTime? RemovedAt { get; set; }
        public Guid? RemovedBy { get; set; }
    }
}