using CourseProject.Entities.Abstract;

namespace CourseProject.Entities.Concret
{
    public class Lesson : BaseEntity
    {
        public string LessonName { get; set; }
        public List<LessonDetail> lessonDetails { get; set; }
    }
}
