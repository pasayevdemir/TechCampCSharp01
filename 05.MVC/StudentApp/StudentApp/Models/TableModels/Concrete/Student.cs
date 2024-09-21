using StudentApp.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DataAccess
{
    public class Student : BaseEntity, IEntity
    {
        [MaxLength(50)]
        [NotNull]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [NotNull]
        public string LastName { get; set; }
    }
}
