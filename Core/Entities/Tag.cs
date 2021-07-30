using Core.Entities.Base;

namespace Core.Entities
{
    public class Tag : Entity
    {
        public Tag(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public TagType Type { get; set; }
    }
}