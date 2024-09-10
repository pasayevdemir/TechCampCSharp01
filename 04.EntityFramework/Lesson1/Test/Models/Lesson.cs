using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Lesson
    {
        public Lesson()
        {
            TeachersLessons = new HashSet<TeachersLesson>();
        }

        public int Id { get; set; }
        public string LessonName { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? Deleted { get; set; }

        public virtual ICollection<TeachersLesson> TeachersLessons { get; set; }
    }
}
