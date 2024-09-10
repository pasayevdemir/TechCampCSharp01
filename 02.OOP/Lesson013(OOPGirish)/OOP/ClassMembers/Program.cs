using Properies;

namespace ClassMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[8];
            //Console.WriteLine(students[0]);//NullReferenceException

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
                Console.Write("Telebenin adini daxilet:");
                students[i].Name = Console.ReadLine();
            }
        }
    }
}
