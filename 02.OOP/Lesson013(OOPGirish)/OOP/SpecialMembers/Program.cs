namespace SpecialMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Human human = new Human("Damir",25);

            //human.HumanInfo();
            //Human human = new();//target type new expression

            Mtd();
            
            GC.Collect();
        }

        public static void Mtd()
        {
            var a= new Human();
        }
    }
}
