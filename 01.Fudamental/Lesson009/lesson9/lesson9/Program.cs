namespace lesson9
{
    internal class Program
    {
        //readonly int a;
        //public Program()
        //{
        //    a = 25;
        //}
        static void Main(string[] args)
        {
            #region MyRegion
            //int a = 5;
            //int b = a;//deep copy
            //a = 20;
            ////output b = 5 , a=20

            //MyClass myClass = new MyClass();
            //MyClass myClass1 = myClass;//shallow copy
            //implicitly 
            //byte imByt = 25;
            //int imInt = imByt;

            //explicitly
            //checked
            //{
            //    int a = 257;
            //    byte byt = (byte)a;

            //    Console.WriteLine(byt);
            //}

            //default
            //int a = default;
            //bool check = default;
            //byte by = default;
            //short sho = default;
            //string str = default;
            //char ch = default;

            //Console.WriteLine(a);
            //Console.WriteLine(check);
            //Console.WriteLine(by);
            //Console.WriteLine(sho);
            //Console.WriteLine(str);
            //Console.WriteLine(ch);

            //sizeof typeof

            //Console.WriteLine(sizeof(int));
            //Console.WriteLine(typeof(string));

            //object boxing unboxing
            //MyClass myClass = new MyClass();
            //object obj = myClass;//boxing
            //object obj1 = myClass;

            //MyClass newModel = (MyClass)obj;//unboxing
            //Console.WriteLine(obj.GetType());
            //object obj = "TechCamp";
            //string str = obj.ToString();
            //Console.WriteLine(str);


            //null
            //int? a = null;
            //byte? by = null;

            //int? day = null;//possible null reference

            //?? null coalescing
            //??= null coalescing assingment

            //string text = null;

            //string str = text ?? "This is null";

            //string strAss = text ??= "This is null";
            //Console.WriteLine(str);

            //ternary

            //if (a == 5)
            //{
            //    Console.WriteLine("a={0} dir", a);
            //}
            //else
            //{
            //    Console.WriteLine("a {0} den ferqlidir ", a);
            //}



            //int a = 66;

            //string str = a > 5 && a<100  ? "5 beraberdir" : "5 beraber deyil";
            //Console.WriteLine(str);


            //const and readonly
            //const static insadir
            //const int a = 5;
            //const double PI = 3.14678D;
            #endregion

            #region Array
            //int[] arr = new int[5];
            //arr[0] = 125;
            //arr[1] = 255;
            //arr[2] = 45;
            //arr[3] = 88;
            //arr[4] = 123;

            //int[] arr1 = { 1, 5, 8, 99, 55 };
            //int[] arr2 = new int[7] { 1, 5, 66, 88, 99, 55, 86 };

            //string str = "Salam";

            //int[] arr = new int[7] { 1, 5, 66, 88, 99, 55, 86 };

            //int i = 0;
            //while (i < arr.Length)
            //{
            //    Console.WriteLine(arr[i]);
            //    i++;
            //}

            //int[] arr = new int[7] { 1, 5, 66, 88, 99, 55, 86 };
            //int sum = default;//c#8
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    //sum = sum + arr[i];
            //    sum += arr[i];
            //}
            //Console.WriteLine(sum);
            //int a =6;
            //while (a < 5)
            //{

            //}

            //do
            //{
            //    //some code 
            //    //anyone opertion
            //}
            //while (a<5);


            //var b = "Salam";
            //var c = false;
            //var ch = 'G';

            //object obj = 7;
            //if (obj.GetType() == typeof(int))
            //{
            //    int c = (int)obj;
            //}
            //if (obj.GetType() == typeof(double))
            //{
            //    double c = (double)obj;
            //}

            //var b = 5;

            //dynamic a = 25;

            int[] arr = new int[7] { 1, 5, 66, 88, 99, 55, 86 };

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}

class MyClass
{

}