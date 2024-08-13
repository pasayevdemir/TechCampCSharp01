namespace AbstractionAndPolimorfizim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.
            //BaseClass obj= new BaseClass();//errorlu kod
            Car car = new Bmw();

            Bmw obj = (Bmw)car;//downcasting


            Car car2 = obj;//upcasting
        }
    }
    public abstract class Car
    {
        public string Name { get; set; }
        public abstract void Driver();//imazasi
    }

    public class Bmw : Car
    {
        public override void Driver()
        {
            Console.WriteLine("Bmw Driver");
        }
    }

    public class Lada : Car
    {
        public override void Driver()
        {
            Console.WriteLine("Lada Driver");
        }
    }

    //public abstract class BaseClass
    //{
    //    public int ID { get; set; }
    //    public abstract int Test { get; set; }
    //}

    //public class Student : BaseClass
    //{
    //    public override int Test { get; set; }
    //    public string Name { get; set; }
    //}

    //public class Product : BaseClass
    //{
    //    public override int Test { get; set; }
    //    public string ProductName { get; set; }
    //}
}
