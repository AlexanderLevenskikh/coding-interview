using Core.Entities.Base;

namespace Core.Entities
{
    public class Description : Entity
    {
        // TODO encrypted byte[] ?
        public string Content { get; set; }
    }
}