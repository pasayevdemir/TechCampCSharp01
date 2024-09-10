using MobilSeller.Models;

namespace MobilSeller.DataBase
{
    public class DB
    {
        private static readonly  DB _instance;//field
        public static DB Instance { get => _instance; }
        private DB(){}
        static DB()
        {
            if (_instance is null)
                _instance = new DB();
        }

        public List<Phone> Phones = new();
    }
}
