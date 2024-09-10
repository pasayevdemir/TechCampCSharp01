namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Switch-Case...
            //switch-case
            //5 nəfər yarışçı var
            //int value = 2;//2ci catıb
            //switch (value)//nəzər alınmış case-lərdən fərqli hal olarsa default işləyir.
            //{//kod blokunun başlanğıcı
            //    case 1:
            //        Console.WriteLine("Yarışçı 1-ci bitirdi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Yarışçı 2-ci bitirdi");
            //        break;
            //    case 3:
            //        Console.WriteLine("Yarışçı 3-ci bitirdi");
            //        break;
            //    case 4:
            //        Console.WriteLine("Yarışçı 4-ci bitirdi");
            //        break;
            //    case 5:
            //        Console.WriteLine("Yarışçı 5-ci bitirdi");
            //        break;
            //    default:
            //        Console.WriteLine("Gələn dəyər səhvdir!!");
            //        break;
            //}//kod blokunun sonu


            //int ay = -5;
            //if (0 < ay)
            //    switch (ay)
            //    {
            //        case 12:
            //        case 1:
            //        case 2:
            //            Console.WriteLine("Qış ayıdır");
            //            break;
            //        case 3:
            //        case 4:
            //        case 5:
            //            Console.WriteLine("Yaz ayıdır");
            //            break;
            //        case 6:
            //        case < 9:
            //            Console.WriteLine("Yay ayıdır");
            //            break;
            //        case 9:
            //        case < 12:
            //            Console.WriteLine("Payız ayıdır");
            //            break;
            //        default:
            //            Console.WriteLine("Belə bir ay yoxdur!!");
            //            break;
            //    }
            //Console.WriteLine("test");

            //if (false)//{}
            //    Console.WriteLine("1test");
            //Console.WriteLine("2test");
            //Console.WriteLine("3test");

            //int age = 24;
            //int value = 1;
            //switch (value)
            //{
            //    case 1:
            //        Console.WriteLine("case 1");
            //        if (age == 24)
            //            goto case 3;
            //        break;
            //    case 2:
            //        Console.WriteLine("case 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("case 3");
            //        break;
            //    case 4:
            //        Console.WriteLine("case 4");
            //        break;
            //    default:
            //        break;
            //}

            //string ay = "Mart";
            //switch (ay)
            //{
            //    case "Dekabr":
            //    case "Yanvar":
            //    case "Fevral":
            //        Console.WriteLine("Qış ayıdır");
            //        break;
            //    case "Mart":
            //    case "Aprel":
            //    case "May":
            //        Console.WriteLine("Yaz ayıdır");
            //        break;
            //    default:
            //        Console.WriteLine("Belə bir ay yoxdur!!");
            //        break;
            //}
            #endregion Switch-Case...

            #region increment and decrement
            //int a = 5;
            //int b = 7;
            //b = b + a;//b+=a
            //Console.WriteLine(b);
            //b += a;
            //b -= a;
            //b *= a;
            //b /= a;
            //b %= a;
            //int a = 5;
            //int b, c;//declaration
            //a = a + 1;//6
            //a += 1;//7
            //b = a++;//8
            //++a;


            //int a = 5;

            //int b = a++;
            ////int b = a;
            ////a = a + 1;
            //Console.WriteLine("b:" + b);
            //Console.WriteLine("a:" + a);


            //int d = 2;
            ////int c = ++d;//3
            //d = d + 1;
            //int c = d;
            //Console.WriteLine("c:" + c);//3
            //Console.WriteLine("d:" + d);//3
            #endregion
            //loops
            //While
            //do while
            //for
            #region While
            int i = 0;
            while (i<20)
            {
                i++;
                int qaliq = i % 3;
                if (qaliq == 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion

        }
    }
}
