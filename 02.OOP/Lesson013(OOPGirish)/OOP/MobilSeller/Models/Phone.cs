using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilSeller.Models
{
    public class Phone : BaseClass
    {
        public string Model { get; set; }
        public string Marka { get; set; }
        public short MemmoryCapacity { get; set; }
        public double Price { get; set; }
    }
}
