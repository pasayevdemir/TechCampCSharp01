namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new();
            Teacher tc = new();
            Assistant ass = new();

            Console.WriteLine(ConsoleMessage(ass));

        }

        public static string ConsoleMessage(IExam gasdsa)
        {
            return gasdsa.StartExam();
        }

    }


    public interface IExam
    {
        string StartExam();
        string EndExam();
        string AddExam();
    }

    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Student : Person //Student is a Person
    {

    }
    
    public class Teacher : Person, IExam //can do
    {
        public Student StudentProperty { get; set; }//has a
        public string AddExam()
        {
            return "Imtahan elave edildi";
        }

        public string EndExam()
        {
            return "Imtahan bashladi";
        }

        public string StartExam()
        {
            return "Imtahan sonlandi";
        }
    }

    public class Assistant : Person, IExam
    {
        public string AddExam()
        {
            return "Assistant Imtahan elave edildi";
        }

        public string EndExam()
        {
            return "Assistant Imtahan bashlatdi";
        }

        public string StartExam()
        {
            return "Assistant Imtahan sonlandirdi";
        }
    }

}
