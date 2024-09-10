using System.Text;

namespace SignletonPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Azətbaycan Dili Üçün
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            bool isEnd = true;

            while (isEnd)
            {
                Console.WriteLine("1-Profil əlavə et");
                Console.WriteLine("2-Profilə daxil ol");
                Console.WriteLine("3-Proqramdan çıx");

                Console.Write("Bir seçim et: ");
                int choich = int.Parse(Console.ReadLine());
            start:
                switch (choich)
                {
                    case 1:
                        Console.Write("Profil adı:");
                        string name = Console.ReadLine();

                        Console.Write("Parol:");
                        string parol = Console.ReadLine();
                        User inputUser = new(name, parol);
                        DataBase.DB.Users.Add(inputUser);
                        Console.Clear();
                        Console.WriteLine("Istifadci əlavə oldu.\n\n");
                        break;
                    case 2:
                        Console.Write("Profil adı:");
                        string userName = Console.ReadLine();

                        Console.Write("Parol:");
                        string password = Console.ReadLine();

                        if (!User.CheckUser(userName, password))
                        {
                            Console.Clear();
                            Console.WriteLine("Parol və ya Name səhvdir!!\n\n");
                            goto start;
                        }
                        break;
                    case 3:
                        isEnd = false;
                        break;
                    default:
                        Console.WriteLine("Belə seçim yoxdur");
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
