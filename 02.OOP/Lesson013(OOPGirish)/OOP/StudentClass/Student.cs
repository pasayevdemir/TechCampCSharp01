using System.Collections;

namespace StudentClass
{
    public class Student
    {
        public int ID { get; }
        public string Name { get; private set; } = string.Empty;
        public string Surname { get; private set; } = string.Empty;
        public string FullName { get => string.Format("{0} {1}", Name, Surname); }

        private ArrayList _examScores = new();
        public ArrayList ExamScores
        {
            get => _examScores;
            private set
            {
                foreach (var item in value)
                {
                    if ((double)item > 100)
                    {
                        Console.WriteLine("Must be exam score max 100");
                        Console.WriteLine(new ArgumentOutOfRangeException().Message);
                    }
                }
                
                _examScores = value;
            }
        }

        private double _average = 0.0D;

        private byte _age;
        public byte Age
        {
            get => _age;
            private set
            {
                if (value < 150)
                    _age = value;
                else
                {
                    Console.WriteLine("must be Age max 150");
                    Console.WriteLine(new ArgumentOutOfRangeException().Message);
                }
            }
        }

        public Student(int id, string name, string surname, byte age, ArrayList examScores)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Age = age;
            ExamScores = examScores;
        }



        public double CalculateAverageScore(Student student)
        {
            double sum = 0.0D;
            foreach (var item in student._examScores)
            {
                sum += (double)item;//unboxing
            }
            _average = sum / student._examScores.Count;
            return _average;
        }

        public void ExamPerfomance(Student student)
        {
            CalculateAverageScore(student);
            Console.WriteLine(_average < 51 ? "Kəsildi" : "Keçdi");
        }

        public void ConsleStudentInfo()
        {
            Console.WriteLine($"Tələbənin Kodu: {ID}");
            Console.WriteLine($"Tələbənin Adı: {FullName}");
            Console.WriteLine($"Tələbənin Yaş: {Age}");
            Console.WriteLine($"Tələbənin Ortalamsı: {_average}");
        }
    }
}
