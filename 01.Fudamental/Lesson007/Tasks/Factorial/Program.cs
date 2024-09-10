namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {//baslangic
         //Verilmiş bir ədədin faktorialını hesablayın.
         //     n(müsbət tam ədəd)
         //     n ədədin faktorialını konsola yazır
         //   Məsələn:
         //   Giriş: 5
         //   Çıxış: 120


            int eded = 18;//6!
            long faktrial = 1;
            while (eded > 0)
            {
                //emeliyyatlar yerine yetir
                //Console.WriteLine("faktrial: {0} eded : {1}", faktrial, eded);
                faktrial = faktrial * eded;
                eded = eded - 1;
            }
            Console.WriteLine(faktrial);
         //son
        }
    }
}
