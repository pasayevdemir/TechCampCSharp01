using CourseProject.Entities.Concret;
using CourseProject.Operations.Concret;
using System.Text;

namespace CourseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool isCoun = true;
            StudentManager manager = new();
            while (isCoun)
            {
                Console.WriteLine("-----------\n");
                Console.WriteLine("1-Əlavə et.");
                Console.WriteLine("2-Yenilə.");
                Console.WriteLine("3-Sil.");
                Console.WriteLine("4-Hamsını göstər.");
                Console.WriteLine("5-Seç.");
                Console.WriteLine("6-Proqramı bağla.");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    switch (value)
                    {
                        case 1:
                            Console.Clear();
                            Student newStud = new Student();
                            Console.WriteLine("----------Tələbəni daxil et-------*");
                            Console.Write("Adı:");
                            newStud.FirstName = Console.ReadLine();

                            Console.Write("Soyadı:");
                            newStud.LastName = Console.ReadLine();

                            var result = manager.Add(newStud);
                            Console.WriteLine(result.Message);
                            break;

                        case 2:
                            Console.Clear();
                            Student updateSt = new Student();
                            Console.WriteLine("----------Yenilənəçək tələbənin id-sini daxil et-------*");
                            Console.Write("ID:");
                            int.TryParse(Console.ReadLine(), out int updateId);
                            Console.Write("Adı:");
                            updateSt.FirstName = Console.ReadLine();

                            Console.Write("Soyadı:");
                            updateSt.LastName = Console.ReadLine();

                            var resultUp = manager.Update(updateSt, updateId);
                            Console.WriteLine(resultUp.Message);

                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("----------Tələbənin id daxil et-------*");
                            Console.Write("ID:");
                            int.TryParse(Console.ReadLine(), out int deletedID);
                            var resultD = manager.Deleted(deletedID);
                            Console.WriteLine(resultD.Message);

                            break;

                        case 4:

                            Console.Clear();
                            Console.WriteLine("----------Tələbələr-------*");

                            var students = manager.GetAll().Data;
                            foreach (var item in students)
                            {
                                Console.WriteLine($"Id: {item.ID}");
                                Console.WriteLine($"Adı: {item.FirstName}");
                                Console.WriteLine($"Soyadı: {item.LastName}");
                                Console.WriteLine($"Silimiş ID: {item.Deleted}");
                                Console.WriteLine();
                            }

                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("----------Tələbənin id daxil et-------*");
                            Console.Write("ID:");
                            int.TryParse(Console.ReadLine(), out int findID);
                            var resultFound = manager.GetById(findID);
                            if (resultFound.IsSuccess)
                            {
                                var data = resultFound.Data;
                                Console.WriteLine($"Id: {data.ID}");
                                Console.WriteLine($"Adı: {data.FirstName}");
                                Console.WriteLine($"Soyadı: {data.LastName}");
                                Console.WriteLine($"Silimiş ID: {data.Deleted}\n");
                            }
                            else
                                Console.WriteLine(resultFound.Message);

                            break;
                        case 6:
                            isCoun = false;

                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Belə seçim yoxdur!");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Doğru simvol daxil et!");
                }
            }
        }
    }
}
