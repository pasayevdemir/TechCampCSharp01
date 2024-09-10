using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilSeller.Models
{
    public abstract class BaseClass
    {
        private static int _id = 1;
        public int ID { get; set; }
        public int Deleted { get; set; } = 0;
        protected BaseClass()
        {
            ID = _id++;
        }
       /*
        ID  Ad       Soyad   Deleted
        1   abbasov   ferid   0
        2   xelilov   emin    0
        3   eliyev    umid    3
        4   abbasov   eli     4
        5   pasahyev  saleh   5
       */
    }
}
