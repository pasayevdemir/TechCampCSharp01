using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOrRef
{
    public class Operation
    {

        public void Test(ref int value)
        {
        }


        public void TestOut(out int value)
            //out məcbur edir ki parametrin dəyərini dəyişək
        {
            value = 45;
        }

        public bool IsSamePassword(string password, string repeatPassword, out string ms)
        {
            if (password == repeatPassword)
            {
                ms = "Əməliyyat uğurla sonladı";
                return true;
            }
            ms = "Parol və Təkrar Parol fərqlidir";
            return false;
        }

        public bool IsCheck(int age, out string message)
        {
            if (age < 18)
            {
                message = "Sizin yaşınız keçərli deyil!!";
                return false;
            }
            message = "Sayta Xoş Gəldiniz!";
            return true;
        }
    }
}
