using System.Text;

namespace Algorthim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1


            //1.Dördrəqəmli natural ədəd verilmişdir.
            //Onun rəqəmlərinin kvadratları cəmini hesablayın.
            //Cəmi konsol ekranına yazdırın.
            //Məsələn: 7894 bu ədədi 7 * 7 + 8 * 8 + 9 * 9 + 4 * 4 = 210
            //Console.WriteLine(210);
            //eded*eded
            //int value = 2222;
            ////Qaliq tapmaq mod(%) opratorundan istifadə 
            //int tek = value % 10;//4
            //             //94
            //int onl = (value % 100) / 10;//9
            //               //894
            //int yuz = (value % 1000) / 100;//8

            //int min = value / 1000;//7


            //int sum = min * min + yuz * yuz + onl * onl + tek * tek;

            //Console.WriteLine(sum);

            #endregion Task1

            //int x = 9;
            //int y = 7;

            //if (x > y)
            //{
            //    Console.WriteLine("{0} > {1} Boyukdur", x, y);
            //}
            //else if(x < y)
            //{
            //    Console.WriteLine("{0} < {1} kicikdir", x, y);
            //}
            //else
            //{
            //    //diger butun hallar ve ya vairantlar
            //    Console.WriteLine("{0} == {1} beraberdir", x, y);
            //}

            int x = 50;
            int y = 11;
            int z = 50;

            if (x > y)
            {
                if (y > z)
                {
                    Console.WriteLine(x + ">" + y + ">" + z);
                }
                else if (y < z)
                {
                    if (x > z)
                        Console.WriteLine(x + ">" + z + ">" + y);
                    else if (x < z)
                        Console.WriteLine(z + ">" + x + ">" + y);
                    else
                        Console.WriteLine(x + "=" + z + ">" + y);
                }
                else
                {
                    Console.WriteLine(x + ">" + y + "=" + z);
                }
            }
            else if (y > x)
            {
                if (x > z)
                {
                    Console.WriteLine(y + ">" + x + ">" + z);
                }
                else if (x < z)
                {
                    if (y > z)
                        Console.WriteLine(y + ">" + z + ">" + z);
                    else if (y < z)
                        Console.WriteLine(z + ">" + y + ">" + y);
                    else
                        Console.WriteLine(z + "=" + y + ">" + y);
                }
                else
                {
                    if (y > z)
                        Console.WriteLine(y + ">" + z + ">" + z);
                    else if (y < z)
                        Console.WriteLine(z + ">" + y + ">" + y);
                    else
                        Console.WriteLine(z + "=" + y + ">" + y);
                }
            }
            else
            {
                if (x > z)
                    Console.WriteLine(x + "=" + y + ">" + z);
                else if (x < z)
                    Console.WriteLine(z + ">" + y + "=" + z);
                else
                    Console.WriteLine(z + "=" + y + "=" + z);
            }

            //if (x >= y && y >= z)
            //{
            //    Console.WriteLine("{0}>={1}>={2}", x, y, z);
            //}
            //else if (x >= y && x > z && z > y)
            //{
            //    Console.WriteLine("{0}>={1}>={2}", x, z, y);
            //}
            //else if (z >= x && x >= y && z >= y)
            //{
            //    Console.WriteLine("{0}>={1}>={2}", z, x, y);
            //}
            //else if (z >= x && y >= x && z >= y)
            //{
            //    Console.WriteLine("{0}>={1}>={2}", z, y, x);
            //}
            //else if (y >= x && x >= z && y >= z)
            //{
            //    Console.WriteLine("{0}>={1}>={2}", y, x, z);
            //}
            //else if (y >= x && z >= x && y >= z)
            //{
            //    Console.WriteLine("{0}>={1}>={2}", y, z, x);
            //}
            //else
            //{
            //    Console.WriteLine(x+y+z);
            //}
        }
    }
}
