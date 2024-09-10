using CourseProject.Entities.Abstract;

namespace CourseProject.Entities.Concret
{
    public class Course : BaseEntity
    {
        public int ID{ get; set; }
        public string Name{ get; set; }
        public string Address{ get; set; }
        public string Email { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
