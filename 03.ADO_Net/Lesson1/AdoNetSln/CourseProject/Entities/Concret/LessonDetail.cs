using CourseProject.Entities.Abstract;

namespace CourseProject.Entities.Concret
{
    public class LessonDetail : BaseEntity
    {
        public int ID { get; set; }
        public int TeacherLessonId { get; set; }
        public Teacher Teacher { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
