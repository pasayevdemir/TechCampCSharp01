using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyword
{
    public class Human
    {
        public static int MyProperty { get; set; }
        public static string Name { get; set; }
        public int Age { get; set; }

        static Human()
        {
            Name = "msdam";
            //Age = 25; //error
        }
    }
}
