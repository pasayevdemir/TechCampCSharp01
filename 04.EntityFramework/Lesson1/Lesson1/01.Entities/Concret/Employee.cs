namespace Lesson1.Entities.Concret
{
    public class Employee : Human
    {
        public double Salary { get; set; }
        public List<Order> Orders { get; set; }
    }
}
