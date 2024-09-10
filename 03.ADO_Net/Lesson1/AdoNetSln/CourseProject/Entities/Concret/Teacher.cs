using CourseProject.Entities.Abstract;

namespace CourseProject.Entities.Concret
{
    public class Teacher : BaseEntity
    {
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public byte  Age { get; set; }
        public List<Course> Courses { get; set; }
    }
}
