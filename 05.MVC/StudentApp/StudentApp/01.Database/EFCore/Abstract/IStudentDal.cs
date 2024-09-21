
using StudentApp.Models;
namespace DataAccess
{
    public interface IStudentDal : IEfCoreRepository<Student,MyDbContext>
    {
    }
}
