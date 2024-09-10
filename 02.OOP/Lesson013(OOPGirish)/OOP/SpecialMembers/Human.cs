using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialMembers
{
    public class Human
    {
        //bir sinifdən obyekt yaradanda işə düşən xüsusi methodur.
        //constructorun adı sinifin adı ilə eyni
        private readonly string _name;
        private readonly byte _age;

        public Human()//parametrless constructor
        {
            Console.WriteLine("Work constructor of human");
        }
        public Human(string name, byte age)
        {
            _name = name;
            _age = age;
        }

        public void HumanInfo()
        {
            Console.WriteLine("Human's Name: {0}",_name);
            Console.WriteLine("Human's Age: {0}",_age);
        }


        //Sinifden yaradılan obyekt Ram silindik də işə düşən metoddur.
        ~Human()
        {
            Console.WriteLine("Destructor");
        }
    }
}
