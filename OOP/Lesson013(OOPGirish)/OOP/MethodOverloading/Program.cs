namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperation operation = new();

            Console.WriteLine("int a, int b =>"+operation.Sum(5, 3));
            Console.WriteLine("int a, int b, int c =>" + operation.Sum(5, 3, 5));
            Console.WriteLine("int a, int b, double c =>" + operation.Sum(5, 3,45D));
        }
    }
}
