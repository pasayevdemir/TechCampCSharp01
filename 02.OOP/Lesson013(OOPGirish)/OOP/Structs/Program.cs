using Structs;
using System.Text;

namespace Structs
{
    //public struct StructTest
    //{
    //    //Struct is a value type

    //    //feilds
    //    //properties
    //    //methods
    //    //indexer
    //    //constructor
    //}

    public struct Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }

        public Person(int id, string name, string adress)
        {
            Id = id;
            Name = name;
            Adress = adress;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;



            bool isCont = true;
            StudentManager studentManager = new();
            while (isCont)
            {
                Console.WriteLine("-----------------------------------\n");

                Console.WriteLine("1-Tələbə əlavə et");
                Console.WriteLine("2-Tələbə göstər");
                Console.WriteLine("3-Proqramı bağla");

                Console.Write("Seçim  et: ");
                if (int.TryParse(Console.ReadLine(), out int choich))
                {
                    switch (choich)
                    {
                        case 1:
                            Console.Clear();
                            Person newPerson = new Person();
                            Console.Write("Tələbənin ID: ");
                            newPerson.Id = int.Parse(Console.ReadLine());
                            Console.Write("Tələbənin adı: ");
                            newPerson.Name = Console.ReadLine();
                            Console.Write("Tələbənin Adresi: ");
                            newPerson.Adress = Console.ReadLine();
                            Console.Write("Tələbənin ortalması: ");
                            double avg = double.Parse(Console.ReadLine());

                            studentManager.Add(new Student(newPerson, avg));
                            break;


                        case 2:
                            Console.Clear();
                            Console.Write("Tələbənin ID: ");
                            int id = int.Parse(Console.ReadLine());
                            StudentManager.Display(id);
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("Proqram bağlanır...");
                            Thread.Sleep(3000);
                            isCont = false;
                            break;
                        default:
                            break;
                    }
                }

            }


        }
    }
}


public abstract class Human
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Adress { get; set; }
}

public class Student : Human
{
    public double ExamScore { get; set; }
    public Student(Person person, double examScore)
    {
        ID = person.Id;
        Name = person.Name;
        Adress = person.Adress;
        ExamScore = examScore;
    }

}


public class StudentManager
{
    readonly static List<Student> students = new(); // fields


    public void Add(Student student)
    {
        students.Add(student);
        Thread.Sleep(3000);
        Console.Clear();
        Console.WriteLine("Əlavə olundu!\n\n");
    }

    public static void Display(int id)
    {
        var student = students.Find(x => x.ID == id);
        Console.Clear();
        Console.WriteLine("Tələbə axtarılır...");
        Thread.Sleep(3000);
        if (student is null)
        {
            Console.WriteLine("Tələbə tapılmadı!!");
            return;
        }
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(student.ID);
        Console.WriteLine(student.Name);
        Console.WriteLine(student.Adress);
        Console.WriteLine("-----------------------------------");
    }
}