using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class LessonDetail
    {
        public int Id { get; set; }
        public int? TeacherLessonId { get; set; }
        public int? StudentId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? Deleted { get; set; }

        public virtual Student? Student { get; set; }
        public virtual TeachersLesson? TeacherLesson { get; set; }
    }
}
