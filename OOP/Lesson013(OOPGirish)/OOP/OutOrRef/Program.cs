namespace OutOrRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ref And Out
            //int deegre = 5 ;
            //Incremend(ref deegre);

            //Console.WriteLine(deegre);

            //string str = "TechCamp";//String value type davaranis gosterir
            //char[] chars = {'T','e','c','h','H','a','m','p'}; 
            //CatAString(str);
            //CatAString(chars);

            //Console.WriteLine(str);
            //Console.WriteLine(chars[0]);
            //ref keyword-u variable-a deyer teyin etmeden gondermeye icaze verimir
            //out keyword-u isə göndərdiyimiz yerdə macbur edir ki dəyər təyin edək
            //int deegre ;

            //Incremend(out deegre);//variable

            //Console.WriteLine(deegre);

            //int userAge = 15;
            //Operation operation = new();
            //string ms;
            //operation.IsCheck(userAge, out ms);

            //bool ck = operation.IsCheck(userAge, out string ms);
            //Console.WriteLine(ms);
            //Operation operation = new();

            //Console.Write("Email:");
            //string email = Console.ReadLine();
            //Console.Write("Password:");
            //string pass = Console.ReadLine();
            //Console.Write("Repeat Password:");
            //string repPass = Console.ReadLine();

            //operation.IsSamePassword(pass, repPass,out string message);
            //Console.WriteLine(message);
            #endregion

            Operation op = new();
            int variable = 25;//ref-ə göndərilmədən öncə dəyər mənimsədilməlidir.
            op.Test(ref variable);

            op.TestOut(out int x);

        }


        #region Ref out
        //public static void Incremend(out int value)
        //{
        //    value = 45;
        //}

        //public static void Incremend(ref int value)
        //{
        //    value = 45;
        //}



        //public static void CatAString(char[] array)
        //{
        //    array[0] = 't';
        //}
        //public static void CatAString(string value)
        //{
        //    value = "Salam";
        //}
        #endregion
    }

}
