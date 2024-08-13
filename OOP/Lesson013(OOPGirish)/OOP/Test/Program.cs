using System.Text;
using Test.Model;
using Test.Operation;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            ProductOperation operation = new ProductOperation();
            bool isCont = true;
            while (isCont)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1-Məhsul əlavə et");
                Console.WriteLine("2-Məhsul dəyiş");
                Console.WriteLine("3-Məhsul göstər");
                Console.WriteLine("4-Proqramı bağla");
                Console.Write("Seçim et: ");
                int choich = int.Parse(Console.ReadLine());
                switch (choich)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\t\tMəhsul Əlavə et");
                        Console.Write("ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Açıqlama: ");
                        string desc = Console.ReadLine();
                        operation.Add(new Product
                        {
                            Id = id,
                            Name = name,
                            Description = desc
                        });
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\t\tMəhsulu dəyiş");
                        Console.Write("Dəyişəcəyin Məhsul ID-si: ");
                        int idU = int.Parse(Console.ReadLine());
                        Console.Write("Name: ");
                        string nameU = Console.ReadLine();
                        Console.Write("Açıqlama: ");
                        string descU = Console.ReadLine();
                        operation.Update(new Product
                        {
                            Id = idU,
                            Name = nameU,
                            Description = descU
                        });
                        break;
                    case 3:
                        Console.Write("ID: ");
                        int idD = int.Parse(Console.ReadLine());
                        operation.Display(idD);
                        break;

                    case 4:
                        isCont = false;
                        Console.Clear();
                        Console.WriteLine("Proqram Bağlandı");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Səhv seçim\n\n");
                        break;
                }
            }
        }
    }

}
