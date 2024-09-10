using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class MathOperation
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Sum(int a, int b, double c)
        {
            return Convert.ToInt32(a + b + c);
        }
    }
}
