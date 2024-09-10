using Lesson1.Entities.Abstract;

namespace Lesson1.Entities.Concret
{
    public class Order : BaseEntity
    {
        public string OrderCode { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
