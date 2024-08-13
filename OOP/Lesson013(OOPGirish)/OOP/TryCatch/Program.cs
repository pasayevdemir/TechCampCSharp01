namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Covert console value: "+a);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Work Finally block");
            }

        }
    }
}
