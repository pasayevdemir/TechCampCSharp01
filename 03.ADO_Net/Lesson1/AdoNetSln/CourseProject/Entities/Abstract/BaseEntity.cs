using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set; } /*= DateTime.Now;*/
        public DateTime UpdateDate { get; set; }
        public int Deleted { get; set; }    
    }
}
