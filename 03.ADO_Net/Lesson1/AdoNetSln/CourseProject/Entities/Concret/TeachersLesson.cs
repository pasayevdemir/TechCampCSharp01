using CourseProject.Entities.Abstract;

namespace CourseProject.Entities.Concret
{
    public class TeachersLesson : BaseEntity
    {
        public int ID { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public byte LessonCredits { get; set; }
    }
}
