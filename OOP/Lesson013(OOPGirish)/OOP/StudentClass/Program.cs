using System.Collections;
using System.Text;

namespace StudentClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Kodunu daxil et:");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Adını daxil et:");
            string name = Console.ReadLine();

            Console.Write("Soyadını daxil et:");
            string surname = Console.ReadLine();
            Console.Write("Yaşını daxil et:");
            byte age = byte.Parse(Console.ReadLine());

            Console.Write("Imtahan Sayını daxil et:");
            int count = int.Parse(Console.ReadLine());
            ArrayList scores = new();
            for (int i = 1; i <= count; i++)
            {
                Console.Write($"{i} imtahan balı: ");
                scores.Add(double.Parse(Console.ReadLine()));
            }
            Student student = new(id, name, surname, age, scores);

            student.CalculateAverageScore(student);
            Console.WriteLine("----------------------------------------");
            student.ConsleStudentInfo();
            Console.WriteLine("----------------------------------------");
            student.ExamPerfomance(student);
        }
    }
}
