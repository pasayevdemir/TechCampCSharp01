using CourseProject.Entities.Abstract;

namespace CourseProject.Entities.Concret
{
    public class StudentCourses : BaseEntity
    {
        public int ID { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
