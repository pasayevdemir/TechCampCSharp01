
namespace PropertiesAndMethods
{
    public class Calulate
    {
        #region Properties
        /*
        <access_modifier> <return_type> <property_name>
        {
                get { // body return }
                set { // body }

        }
        */

        //private int z;

        //public int X { get; set; }//shorthand || auto implement property


        /*************************Write-Only Properties:******************/
        //get accessor(Methodu) olmayan və ya
        //yalnız set methodu(accessoru) olandır.
        //public int Y
        //{
        //    set
        //    {
        //        Y = value;
        //    }
        //}
        /*************************Read-Only Properties:******************/
        //set accessor(Methodu) olmayan və ya
        //yalnız get methodu(accessoru) olandır.
        //public int Z
        //{
        //    get
        //    {
        //        z = X + Y;
        //        return z * 3;
        //    }
        //}

        //auto implement property-ni set accessor yazmaq olar.
        //lakin get accessor yazmaq olmaz.
        //private int myProperty;
        //full-property
        //public int MyProperty
        //{
        //    get
        //    {
        //        return myProperty;
        //    }
        //    private set
        //    {
        //        myProperty = value;
        //    }
        //}

        #endregion

        #region Methods
        /*Metodlar yadığımız proqraam daxilindəmüəyyən tapşırıqların 
         * yerinə yetirilməsi, lazım gəldikdə çoxlu sayda kodun 
         * təkrar-təkrar yazılmadan istifadəsini təmin edir.
         */

        /* Metodlar bir class memberdir(sinif üzvüdür).*/
        public int X { get; set; }
        public int Sum(int a, int b = 0)//OPTIONAL PARAMETR(C# 4.0)
        {
            int result = a + b;

            return result;
        }

        public int Factorial(int n)
        {
            var isRangeOverload = LocalMethod();
            int factorial = 1;
            if (isRangeOverload)
            {
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
            else
            {
                return 0;
            }

            bool LocalMethod()//C# 7.0
            {
                if (n < 20 && n > 0)
                    return true;
                else
                    return false;
            }
        }

        //params c# 1.0
        public int ArraySumElement(in int arrayLength,params int[] massiv)//{1,2,3,4,5,6}
        {
            int sum = 0;
            if (arrayLength <= massiv.Length && arrayLength>=0)
            {
                ArraySum(arrayLength);
            }
            else
            {
                ArraySum(massiv.Length);

            }

            return sum;

            void ArraySum(int length)
            {
                for (int i = 0; i < length; i++)
                {
                    sum += massiv[i];
                }
            }
        }

        #endregion
    }
}
