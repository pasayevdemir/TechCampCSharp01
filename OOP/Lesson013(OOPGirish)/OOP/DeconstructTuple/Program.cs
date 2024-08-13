namespace DeconstructTuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test obj = new Test(45, 88.99,"TechCamp");

            //obj.Deconstruct(out int aa, out double bb, out string str);

            //(int aa, double bb, string str) = obj;

            //Console.WriteLine(aa);
            //Console.WriteLine(bb);
            //Console.WriteLine(str);

            //var tupl = obj.TestTuple();
            //(int tp1, double tp2, bool tp3) = obj.TestTuple();

            //Console.WriteLine(tupl.Item1);
            //Console.WriteLine(tupl.Item2);
            //Console.WriteLine(tupl.Item3);
        }
    }
}

//public class Test
//{
//    public int A { get; set; }
//    public double B { get; set; }
//    public string Str { get; set; }

//    public (int, double, bool) TestTuple()
//    {
//        return (45, 88.99, true);
//    }
//    public Test()
//    {
        
//    }
//    public Test(int a, double b, string str)
//    {
//        A = a;
//        B = b;
//        Str = str;
//    }
//    public void Deconstruct(out int a, out double b, out string str)
//    {
//        a = A;
//        b = B;
//        str = Str;
//    }
//}