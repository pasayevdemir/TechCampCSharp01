using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Student
    {
        public Student()
        {
            LessonDetails = new HashSet<LessonDetail>();
            StudentCourses = new HashSet<StudentCourse>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? Deleted { get; set; }

        public virtual ICollection<LessonDetail> LessonDetails { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
