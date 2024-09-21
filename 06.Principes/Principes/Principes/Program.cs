namespace Principes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Parrot();
            (bird as IFlyable)?.Fly();
            bird = new Penguen();
            (bird as IFlyable)?.Fly();

            //Dependency Invertion
            //Loose Coupling- Genish asliliq
            //Tight Coupling - Six asliliq



        }
    }
}

//Tight Coupling
//public class MailManager
//{
//    public void Send(string userName, string password)
//    {
//        if (userName == "*@gamil.com")
//        {
//            var provider = new GmailProvider();
//            provider.Send(userName, password);
//        }
//        else if (userName == "*@yahoo.")
//        {
//            var provider = new YahooProvider();
//            provider.Send(userName, password);
//        }
//        else if (userName == "*@mail.ru")
//        {
//            var provider = new MailRuProvider();
//            provider.Send(userName, password);
//        }
//        else
//        {
//            Console.WriteLine("Error");
//        }
//    }
//}

//Loose Coupling- Genish asliliq
//public class MailManager
//{
//    private IMailService provider;
//    public void Send(string userName, string password)
//    {
//        if (userName == "*@gamil.com")
//        {
//            provider = new GmailProvider();
//            provider.Send(userName, password);
//        }
//        else if (userName == "*@yahoo.")
//        {
//            provider = new YahooProvider();

//            provider.Send(userName, password);
//        }
//        else if (userName == "*@mail.ru")
//        {
//            provider = new MailRuProvider();
//            provider.Send(userName, password);
//        }
//        else
//        {
//            Console.WriteLine("Error");
//        }
//    }
//}


//dependency injection
public class MailManager
{
    private readonly IMailService provider;
    public MailManager(IMailService provider)
    {
        this.provider = provider;
    }
    public void Send(string userName, string password)
    {
        provider.Send(userName, password);
    }
}

public interface IMailService
{
    void Send(string userName, string password);
}

public class GmailProvider : IMailService
{
    public void Send(string userName, string password)
    {
        Console.WriteLine("success");
    }
}

public class YahooProvider : IMailService
{
    public void Send(string userName, string password)
    {
        Console.WriteLine("success");
    }
}

public class MailRuProvider : IMailService
{
    public void Send(string userName, string password)
    {
        Console.WriteLine("success");
    }
}











public abstract class Bird
{
    public string Name { get; set; }
    public string GroupName { get; set; }
    public abstract void Voice();

}
public interface IFlyable
{
    void Fly();
}

public interface IWildable
{
    void Wild();
}

public class Parrot : Bird, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Parrot can fly");
    }

    public override void Voice()
    {
        Console.WriteLine("This is Parrot's voice");
    }
}


public class Penguen : Bird
{
    public override void Voice()
    {
        Console.WriteLine("This is Penguen's voice");
    }
}



public class Eagle : Bird, IFlyable, IWildable
{
    public void Fly()
    {
        Console.WriteLine("Parrot can fly");
    }

    public override void Voice()
    {
        Console.WriteLine("This is Parrot's voice");
    }

    public void Wild()
    {
        Console.WriteLine("Parrot is wild");

    }
}