namespace SingletonPattern
{

    public class Singleton
    {
        private static readonly Singleton _instance;
        public static Singleton Instance => _instance;

        private Singleton() { }

        static Singleton()
        {
            if (_instance == null)
                _instance = new Singleton();
        }

        public List<int> Numbers { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.Numbers = new List<int> { 1, 2, 3, 4 };
            foreach (var item in Singleton.Instance.Numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
