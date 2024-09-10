using MobilSeller.Models;
using MobilSeller.Service.Concret;
using System.Data;
using System.Text;

namespace MobilSeller
{
    internal class Program
    {
        static void Main(string[] args)
        {



            DataTable dataTable = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customers", connection))
            {
                adapter.Fill(dataTable);
            }


            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            bool isCountion = true;
            PhoneManager phoneManager = new();

            while (isCountion)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("1-Telefon əlavə et");
                Console.WriteLine("2-Telefon yenilə");
                Console.WriteLine("3-Telefon sil");
                Console.WriteLine("4-Telefonları göstər");
                Console.WriteLine("5-Silinmiş telefonları göstər");
                Console.WriteLine("6-Silinməmiş telefonları göstər");
                Console.WriteLine("7-Proqramı bağla");

                if (int.TryParse(Console.ReadLine(), out int chioce))
                {
                    switch (chioce)
                    {
                        case 1:
                            Console.Clear();
                            Phone newPhone = new Phone();
                            Console.WriteLine("--------------Məlumatları əlavə et-----------");
                            Console.Write("Model: ");
                            newPhone.Model = Console.ReadLine();
                            
                            Console.Write("Marka: ");
                            newPhone.Marka = Console.ReadLine();
                            
                            Console.Write("Memory: ");
                            newPhone.MemmoryCapacity = short.Parse(Console.ReadLine());
                            
                            Console.Write("Price: ");
                            newPhone.Price = double.Parse(Console.ReadLine());

                            if(phoneManager.AddPhone(newPhone))
                            {
                                Console.WriteLine("Əlavə olundu.");
                            }
                            else
                            {
                                Console.WriteLine("Əməliyyat uğursuz!!");
                            }

                            break;
                        case 2:
                            Console.Clear();
                            Phone updatePhone = new Phone();
                            DisplayPhone(phoneManager.GetAll());
                            Console.WriteLine("--------------Məlumatları yenilə-----------");
                            Console.Write("Yeniləcək telefonun ID-si: ");
                            int id = int.Parse(Console.ReadLine());

                            Console.Write("Model: ");
                            updatePhone.Model = Console.ReadLine();

                            Console.Write("Marka: ");
                            updatePhone.Marka = Console.ReadLine();

                            Console.Write("Memory: ");
                            updatePhone.MemmoryCapacity = short.Parse(Console.ReadLine());

                            Console.Write("Price: ");
                            updatePhone.Price = double.Parse(Console.ReadLine());

                            if (phoneManager.UpdatePhone(updatePhone, id))
                            {
                                Console.WriteLine("Yeniləndi.");
                            }
                            else
                            {
                                Console.WriteLine("Əməliyyat uğursuz!!");
                            }
                            break;
                        case 3:
                            Console.Clear();
                            DisplayPhone(phoneManager.GetAllNonDeleted());
                            Console.Write("Silinəcək telefonun ID-si: ");
                            int deletedId = int.Parse(Console.ReadLine());

                            if (phoneManager.DeletedPhone(deletedId))
                            {
                                Console.WriteLine("Silindi.");
                            }
                            else
                            {
                                Console.WriteLine("Əməliyyat uğursuz!!");
                            }
                            break;
                        case 4:
                            DisplayPhone(phoneManager.GetAll());
                            break;
                        case 5:
                            DisplayPhone(phoneManager.GetAllDeleted());
                            break;
                        case 6:
                            DisplayPhone(phoneManager.GetAllNonDeleted());
                            break;
                        case 7:
                            Thread.Sleep(1000);
                            isCountion = false;
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Doğru seçim etməmisən!!");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Doğru simvol daxil olmayıb!!");
                }
            }
        }

        private static void DisplayPhone(List<Phone> phones)
        {
            foreach (var item in phones)
            {
                Console.WriteLine(item.Model);
                Console.WriteLine(item.Marka);
                Console.WriteLine(item.MemmoryCapacity);
                Console.WriteLine(item.Price);
            }
        }
    }
}
