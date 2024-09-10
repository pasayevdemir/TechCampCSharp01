namespace Lesson1.Entities.Concret
{
    public class Customer : Human
    {
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public List<Order> Orders { get; set; }
    }
}
