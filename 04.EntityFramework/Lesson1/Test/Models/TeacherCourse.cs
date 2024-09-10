using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TeacherCourse
    {
        public int Id { get; set; }
        public int? TeacherId { get; set; }
        public int? CourseId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? Deleted { get; set; }

        public virtual Course? Course { get; set; }
        public virtual Teacher? Teacher { get; set; }
    }
}
