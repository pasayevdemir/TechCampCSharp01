using System.IO;

namespace Types
{
    class MyClass
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            X.MyClass myClass = new X.MyClass();
        }
    }
}

namespace X
{
    class MyClass
    {

    }
}