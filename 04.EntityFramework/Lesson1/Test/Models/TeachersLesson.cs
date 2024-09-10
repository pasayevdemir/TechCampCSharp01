using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TeachersLesson
    {
        public TeachersLesson()
        {
            LessonDetails = new HashSet<LessonDetail>();
        }

        public int Id { get; set; }
        public int? TeacherId { get; set; }
        public int? LessonId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public byte LessonCredits { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? Deleted { get; set; }

        public virtual Lesson? Lesson { get; set; }
        public virtual Teacher? Teacher { get; set; }
        public virtual ICollection<LessonDetail> LessonDetails { get; set; }
    }
}
