using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class StudentCourse
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? Deleted { get; set; }

        public virtual Course? Course { get; set; }
        public virtual Student? Student { get; set; }
    }
}
