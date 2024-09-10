
namespace SignletonPractice
{
    public class DataBase
    {
        private static readonly DataBase _db;
        public static DataBase DB => _db;
        private DataBase() { }
        static DataBase()
        {
            if (_db == null)
                _db = new DataBase();
        }

        public List<User> Users { get; set; } = new();
    }
}
