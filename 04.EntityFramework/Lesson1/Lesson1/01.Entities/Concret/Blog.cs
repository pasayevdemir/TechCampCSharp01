using Lesson1.Entities.Abstract;

namespace Lesson1._01.Entities.Concret
{
    public class Blog : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
