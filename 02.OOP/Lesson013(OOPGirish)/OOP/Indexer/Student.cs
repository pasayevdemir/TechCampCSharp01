using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class Student
    {
        public string name;
        public int age;
        public Student()
        {
            Console.WriteLine("Boş Consturctor işlədi");
        }

        public Student(string name) : this()
        {
            this.name = name;
            Console.WriteLine("Ad olan Consturctor işlədi");
        }
        public Student(string name, int age) : this(name)
        {
            this.age = age;
            Console.WriteLine("İki parametrli Consturctor işlədi");
        }

        static Student()
        {

        }
    }
}
