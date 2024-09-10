using CourseProject.Entities.Abstract;

namespace CourseProject.Entities.Concret
{
    public class TeacherCourse : BaseEntity
    {
        public int ID { get; set; }
        public int TeacherLessonId { get; set; }
        public Teacher Teacher { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
