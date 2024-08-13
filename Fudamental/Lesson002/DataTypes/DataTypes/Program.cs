using System.Text;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Deyisen
            //özündə data saxlayan mexanizmadır
            //bool     8             true false 
            //char     8             0 255 

            //byte     8             0 255
            //short    16             -32min +32min
            //int      32             -2milyard +2milyard
            //long     64            -9triliyon +9triliyon
            //decimal  128bit   

            //float   32
            //double  64

            //string
            //char ch = 'A';
            //string str = "Salam TechCamp";
            //bool check = true;
            //int value = 20555245;
            //sbyte by = -25;//-128 to +128
            //byte by1 = 25;//0 to 255
            //float fl = 45.564F;
            //double dl = 98878.5454D;
            //decimal dc = 4545.54M;
            #endregion
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Adını daxil et:");
            string firstName = Console.ReadLine();
            Console.Write("Soyadını daxil et:");
            string lastName = Console.ReadLine();


            Console.WriteLine("Adı: {0} Soyad: {1}", firstName, lastName);
            //
            /* */
            Console.ReadKey();
        }
    }
}