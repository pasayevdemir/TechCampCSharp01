using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            TeacherCourses = new HashSet<TeacherCourse>();
            TeachersLessons = new HashSet<TeachersLesson>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public byte Age { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? Deleted { get; set; }

        public virtual ICollection<TeacherCourse> TeacherCourses { get; set; }
        public virtual ICollection<TeachersLesson> TeachersLessons { get; set; }
    }
}
