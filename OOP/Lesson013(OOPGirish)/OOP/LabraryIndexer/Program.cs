using System.Collections;

namespace LabraryIndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i} kitabın adı:");
                library[i] = Console.ReadLine();
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(library[i]);
            }
        }
    }
    public class Library
    {
        private ArrayList BookNames = new();

        public string this[int index]
        {
            get
            {
                return BookNames[index].ToString();
            }
            set
            {
                BookNames.Add(value);
            }
        }
    }
}
