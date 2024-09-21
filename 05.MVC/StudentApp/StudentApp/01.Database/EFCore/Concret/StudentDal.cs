namespace DataAccess
{
    public class StudentDal : EFCoreRepository<Student, MyDbContext>, IStudentDal
    {
        public StudentDal(MyDbContext context) : base(context)
        {
        }
    }
}
