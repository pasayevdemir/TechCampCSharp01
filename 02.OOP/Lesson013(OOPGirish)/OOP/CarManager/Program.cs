namespace CarManagers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               -- Tətbiq başladıqda istifadəçiyə aşağıdakı menyu göstəriləcək:
                 1. Maşın əlavə et
                 2. Maşınlara bax
                 3. ID`yə görə maşın sil
                 4. Maşını update et
                 0. Çıxış
                 İstifadəçi uyğun rəqəmi daxil edərək əməliyyatı seçəcək.
               
               --Databaza kimi List-dən istifadə olunacaq.
               
               --Car adlı bir sinif yaradılmalıdır. Bu sinifdə maşına aid aşağıdakı xüsusiyyətlər olmalıdır:
                 Id, Brand, Model, Year, Price
               
               --Qeyd: Proqramı yazarkən interfeyslərdən istifadə olunmaalıdır.
             */

            ICarManager manager = new CarManager();
            bool isClose = false;
            while (!isClose)
            {
                Console.WriteLine("---------------------");

                Console.WriteLine("1. Maşın əlavə et");
                Console.WriteLine("2. Maşınlara bax");
                Console.WriteLine("3. ID`yə görə maşın sil");
                Console.WriteLine("4. Maşını update et");
                Console.WriteLine("0. Çıxış");

                Console.Write("Seçim et: ");
                int.TryParse(Console.ReadLine(), out int choice);

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Car newCar = new();
                        Console.Write("Model: ");
                        newCar.Model = Console.ReadLine();
                        Console.Write("Marka: ");
                        newCar.Brand = Console.ReadLine();
                        Console.Write("İli: ");
                        newCar.Year = short.Parse(Console.ReadLine());
                        Console.Write("Qiyməti: ");
                        newCar.Price = double.Parse(Console.ReadLine());

                        manager.AddCar(newCar);
                        Console.Clear();
                        Console.WriteLine("...");
                        Thread.Sleep(2000);
                        Console.WriteLine("Əlavə edildi!!");
                        break;
                    case 2:
                        Console.Clear();
                        var data = manager.GetAll();
                        foreach (var item in data)
                        {
                            Console.WriteLine($"\n-----------{item.Model}-----------");
                            Console.WriteLine("ID: " + item.Id);
                            Console.WriteLine("Model: " + item.Model);
                            Console.WriteLine("Marka: " + item.Brand);
                            Console.WriteLine("İli: " + item.Year);
                            Console.WriteLine("Qiyməti: " + item.Price);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Silinəcək maşının ID-si: ");
                        int.TryParse(Console.ReadLine(), out int intoID);
                        if (manager.DeleteCar(intoID))
                        {
                            Console.WriteLine("Əməliyyat uğurlu!");
                        }
                        else
                        {
                            Console.WriteLine("Əməliyyat uğursuz!");
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Yenilənəcək maşının ID-si: ");
                        int.TryParse(Console.ReadLine(), out int updateID);

                        Car updateCar = new();
                        Console.Write("Model: ");
                        updateCar.Model = Console.ReadLine();
                        Console.Write("Marka: ");
                        updateCar.Brand = Console.ReadLine();
                        Console.Write("İli: ");
                        updateCar.Year = short.Parse(Console.ReadLine());
                        Console.Write("Qiyməti: ");
                        updateCar.Price = double.Parse(Console.ReadLine());

                        if (manager.UpdateCar(updateCar, updateID))
                        {
                            Console.WriteLine("Əməliyyat uğurlu!");
                        }
                        else
                        {
                            Console.WriteLine("Əməliyyat uğursuz!");
                        }
                        break;

                        break;
                    case 5:
                        isClose = true;
                        break;
                    default:
                        Console.WriteLine("Belə seçim yoxdur!");
                        break;
                }
            }

        }
    }

    public class Car
    {
        private static int _id = 1;
        public int Id { get => _id; private set => _id++; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public short Year { get; set; }
        public double Price { get; set; }
    }

    public interface ICarManager
    {
        bool AddCar(Car car);
        bool DeleteCar(int id);
        bool UpdateCar(Car car, int id);
        List<Car> GetAll();
    }

    public class CarManager : ICarManager
    {
        private static List<Car> CarsDB { get; set; } = new();
        public bool AddCar(Car car)
        {
            CarsDB.Add(car);
            return true;
        }
        public bool DeleteCar(int id)
        {
            Car foundCar = CarsDB.Find(x => x.Id == id);
            if (foundCar != null)
            {
                CarsDB.Remove(foundCar);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateCar(Car car, int id)
        {
            Car foundUpdateCar = CarsDB.Find(x => x.Id == car.Id);
            if (foundUpdateCar != null)
            {
                foundUpdateCar.Model = car.Model;
                foundUpdateCar.Brand = car.Brand;
                foundUpdateCar.Year = car.Year;
                foundUpdateCar.Price = car.Price;
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Car> GetAll()
        {
            List<Car> allData = CarsDB.OrderBy(x => x.Model).ToList();

            return allData;
        }

    }
}
