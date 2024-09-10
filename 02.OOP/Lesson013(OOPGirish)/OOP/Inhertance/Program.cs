using System.Text;

namespace Inhertance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region Inheritance...
            //SubClass obj = new();
            //obj.MyProperty = 25;
            //CustomerManager manager = new();

            //manager.Add(new Customer
            //{
            //    Name = "Aynure",
            //    Age = 19,
            //    Payment = 10.5D,
            //    SendService = "Satış",
            //    ServiceCode = "ay19n45"
            //});

            //manager.Add(new Customer
            //{
            //    Name = "Susan",
            //    Age = 30,
            //    Payment = 10.5D,
            //    SendService = "Temir",
            //    ServiceCode = "su30a45"
            //});

            //Customer findResult = manager.GetCustomer("su30a45");

            //manager.CustomerInfo(findResult);
            #endregion Inheritance...


            //Student newStudent = new("Aynurə", 19, "Sosialogiya", 80.5);

            B eresetun = new B();
            eresetun.Test();
        }//End Main Method
    }//End Program class

    public class A
    {
        public virtual void Test()
        {
            Console.WriteLine("A class");
        }
    }

    public class B 
        : A
    {
        public override void Test()
        {
            base.Test();
            Console.WriteLine("B class");
        }
    }

    //public class Person
    //{
    //    private string _name = string.Empty;//field
    //    public string Name => _name;//Property _name
    //    public byte Age { get; }//Property
    //    public Person(string name, byte age)
    //    {
    //        _name = "Mr" + name;
    //        Age = age;
    //    }
    //}

    //public class Student : Person
    //{
    //    public string ExamName { get; }
    //    public double ExamScore { get; }

    //    public Student(string studentName, byte studentAge, string examName, double examScore)
    //        : base(studentName, studentAge)
    //    {
    //        ExamName = examName;
    //        ExamScore = examScore;
    //    }

    //}


    //public class A
    //{
    //    public A()
    //    {
    //        Console.WriteLine("Empty Parent class constructor");
    //    }

    //    public A(int a)
    //    {
    //        a = a * 42 / 8;
    //        Console.WriteLine("Parametrly Parent class constructor");
    //    }
    //}

    //public class B : A
    //{
    //    public B(int ab, int x, int b) : base(x)
    //    {
    //        Console.WriteLine("Child class constructor");
    //    }
    //}


    public class Human//BaseClass, ParentClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Employee : Human //SubClass, ChildClass, Derrived
    {
        public double Salary { get; set; }
        public void GiveReport()
        {
            Console.WriteLine("Report");
        }
    }

    public class Customer : Human
    {
        public string ServiceCode { get; set; }
        public string SendService { get; set; }
        public double Payment { get; set; }
        public void ToOrder()
        {
            Console.WriteLine("Order");
        }
    }

    public class CustomerManager
    {
        //Müştərilər
        private List<Customer> Customers { get; set; } = new();

        public void Add(Customer customer)
        {
            if (customer.Name != null &&
                customer.SendService != null &&
                customer.Age > 18 &&
                customer.Payment > 0 &&
                !string.IsNullOrWhiteSpace(customer.ServiceCode)
                )
            {
                Customers.Add(customer);
            }
        }
        public Customer GetCustomer(string serviceCode)
        {
            Customer findCustomer = new();
            for (int i = 0; i < Customers.Count; i++)
            {
                if (Customers[i].ServiceCode == serviceCode)
                {
                    findCustomer = Customers[i];
                    break;
                }
            }
            return findCustomer;
        }

        public void CustomerInfo(Customer customer)
        {
            Console.WriteLine($"Müştəri adı:{customer.Name}");
            Console.WriteLine($"Müştəri yaşı:{customer.Age}");
            Console.WriteLine($"Müştəri aldığı servis:{customer.SendService}");
            Console.WriteLine($"Müştəri ödənişi:{customer.Payment} aze");
            Console.WriteLine($"Müştəri servis kodu:{customer.ServiceCode}");
        }
    }
}
