using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //WordName - PascalCase
            //camelCaseValue

            //accessModifier returnValue MethodName(type valueName,.. ,...)
            //{

            //}

            //1.geri deyer donderib parametrli olan methodlar.
            //public int Sum(int x, int y)
            //{
            //    return x + y;
            //}

            //2.geri deyer gonderib parametri olmayan methodlar
            //public int Sum()
            //{
            //    int x=5;
            //    int y=85;
            //    return x + y;
            //}

            //3.geri deyer gondermeyib parametri olan methodlar
            //public void Sum(int x, int y)
            //{
            //    int z = x + y;
            //}

            //4.geri deyer gondermeyib parametri olmayan methodlar
            //public void Sum()
            //{
            //    int z = 5 + 6;
            //}


            //int result = Sum(5, 8);
            //Console.WriteLine(result);

            //int[] nums = { 1, 2, 3, 5 };

            //int[] nums2 = { 9, 5, 1, 5 };

            //int result = SumToArray(nums2);

            //Console.WriteLine(result);
            int[] ints = { 1,4,5};
            Sum(ints);
            Console.WriteLine(ints[0]);
        }

        public static void Sum(int[] arr)
        {
            arr[0] = 5;
        }
        //public static int SumToArray(int[] ints)
        //{
        //    int sum = 0;
        //    foreach (var item in ints)
        //    {
        //        sum += item;
        //    }

        //    return sum;
        //}

        //public static int Sum(int x, int y)
        //{
        //    int netice = x + y;
        //    return netice;
        //}
    }
}
