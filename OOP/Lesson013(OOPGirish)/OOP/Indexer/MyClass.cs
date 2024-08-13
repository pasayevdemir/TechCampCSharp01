using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class MyClass
    {
        public int MyProperty { get; set; }
        private ArrayList Names = new();//field
        public string this[int i]
        {
            get
            {
                if (Names.Count > i)
                    return (string)Names[i];
                return "Not found index";
            }
            set
            {
                Names.Add(value);
            }
        }
    }
}
