


namespace SignletonPractice
{
    public class User
    {
        private static int idNumber = 1;

        private int _id;
        public int ID => _id;
        public string UserName { get; set; }
        public string Password { get; set; }
        public User(string userName, string password)
        {
            if (ValidatoinUser(userName, password))
            {
                UserName = userName;
                Password = password;
                _id = idNumber++;
            }
        }

        private bool ValidatoinUser(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName) &&
                string.IsNullOrWhiteSpace(password) &&
                password.Length < 3
              )
            {
                return false;
            }
            else
                return true;
        }

        public static bool CheckUser(string userName, string password)
        {
            foreach (var item in DataBase.DB.Users)
            {
                if (userName == item.UserName &&
                   password == item.Password
                    )
                {
                    Console.Clear();
                    Console.WriteLine(item.ID);
                    Console.WriteLine(item.UserName);
                    Console.WriteLine(item.Password);
                    return true;
                }
            }
            return false;
        }
    }
}
