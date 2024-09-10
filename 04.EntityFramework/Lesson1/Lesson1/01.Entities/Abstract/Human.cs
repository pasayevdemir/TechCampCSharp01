using Lesson1.Entities.Abstract;

namespace Lesson1.Entities.Concret
{
    public abstract class Human : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; } = 18;
        public DateTime BirthDay { get; set; }
    }
}
