using Lesson1.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1._01.Entities.Concret
{
    public class Tag : BaseEntity
    {
        public string TagName { get; set; }
        public string Answer { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
