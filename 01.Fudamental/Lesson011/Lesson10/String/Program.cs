namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string bir char array-dir.
            //string value type davaranış göstərir ancaq bir reference type-dir
            //string immutable
            //string str = "TechCamp";
            //string str2 = str;

            //str[0] = 'a'; // error

            //String CONCAT

            //string str1 = "Hello";
            //string str2 = "TechCamp";

            //string result = str1 + " " + str2 + " " + "c# 001";

            //Console.WriteLine(result);


            //Verbatim String
            //            string text = @"Salam Techcamp qrupu,
            //bu gun dersimiz stringdir   ";
            //            Console.WriteLine(text);


            //Interpolation String =>c# 6.0
            //string name = "Damir";
            //int age = 25;

            //            string aboutText = $@"My name is:{name}
            //and my age is :{age}";

            //            Console.WriteLine(aboutText);

            //*String Format
            //string name = "Damir";
            //int age = 25;
            //var result = string.Format("My name is: {1} and my age is: {0}", age, name);
            //Console.WriteLine(result);

            /*String Methods
                 Equals
                 IndexOf
                 LastIndexOf
                 Compare
                 CompareTo
            */

            //string str = "aac";
            //string str2 = "abc";
            //bool yoxlama = str.Equals("Hello TechCamp");
            //Console.WriteLine(str.Equals("Hello TechCam"));

            //object obyekt = str.Clone();

            //sbyte netice = (sbyte)str.CompareTo(str2);
            //Console.WriteLine(netice);

            //str = str.Replace('a' , 'd' );

            //Console.WriteLine(str);

            //string str = "Aac    Salam   TechCamp";
            //string[] massivMetn = str.Split('a');
            //foreach (var metn in massivMetn)
            //{
            //    Console.WriteLine(metn);
            //}

            //string str = "Salam";

            //Console.WriteLine(str.IndexOf('a'));


            //string str = default;//null
            //string string2 = " ";//""
            //if (string.IsNullOrWhiteSpace(string2))
            //{
            //    Console.WriteLine("Null ve ya bosdur ");
            //}
        }
    }
}
