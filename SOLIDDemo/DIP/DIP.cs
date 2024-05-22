

namespace SOLIDDemo.DIP;

/// <summary>
/// Dependency Inversion Principle
/// 1. High level module should not depend on Low level modules
/// 2. They both should depend on abstractions
/// 3. Those abstractions should not depend on details
/// 4. High Level modules DIP and Chore depend on Low level modules Emailer and Logger
/// 5. Wherever new instance created inside any class, it is hard dependency
/// 6. Dependency Inversion will resolve this issue
/// 7. Dependency Injection is one way of Dependency Inversion
/// 8. Emailer can be easily replced by Texter without breaking anything
/// 9. This way, SOLID breaks big chunks into small little parts
///     so it can be worked easily
/// 10.Dependecny Injection implements DIP
/// 11.Along with Dependecny Injection, it comes with Inversion of Control
/// 12.IoC means ILogger can be replaced from Microsoft, Serilog etc. as all has contract called ILogger
/// 13.Because of DIP, Unit Testing becomes very easy
/// </summary>
internal class DIP
{
    public static void Run()
    {
        //IPerson owner = new Person
        //{
        //    FirstName = "Milan",
        //    LastName = "Sangani",
        //    EmailAddress = "milan@ms0713.com",
        //    PhoneNumber = "123-4567"
        //};
        IPerson owner = Factory.CreatePerson();
        owner.FirstName = "Milan";
        owner.LastName = "Sangani";
        owner.EmailAddress = "milan@ms0713.com";
        owner.PhoneNumber = "123-4567";


        //Chore chore = new()
        //{
        //    ChoreName = "Take out the trash",
        //    Owner = owner,
        //};
        IChore chore = Factory.CreateChore();
        chore.ChoreName = "Take out the trash";
        chore.Owner = owner;

        chore.PerformedWork(3);
        chore.PerformedWork(1.5);
        chore.CompleteChore();

        Console.ReadLine();
    }
}

public class Person : IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public string PhoneNumber { get; set; }
}

public class Chore : IChore
{
    private readonly ILogger m_Logger;
    private readonly IMessageSender m_MessageSender;

    public string ChoreName { get; set; }
    public IPerson Owner { get; set; }
    public double HoursWorked { get; private set; }
    public bool IsComplete { get; private set; }

    public Chore(ILogger logger, IMessageSender messageSender)
    {
        m_Logger = logger;
        m_MessageSender = messageSender;
    }

    public void CompleteChore()
    {
        IsComplete = true;

        //Logger logger = new();
        m_Logger.Log($"Completed {ChoreName}");

        //Emailer emailer = new();
        m_MessageSender.SendMessage(Owner, $"The chore {ChoreName} is complete.");
    }

    public void PerformedWork(double hours)
    {
        HoursWorked += hours;
        //Logger log = new();
        m_Logger.Log($"Performed work on {ChoreName}");
    }
}

public class Emailer : IMessageSender
{
    public void SendMessage(IPerson owner, string msg)
    {
        Console.WriteLine($"Sending email to {owner.EmailAddress}");
    }
}

public class Texter : IMessageSender
{
    public void SendMessage(IPerson owner, string msg)
    {
        Console.WriteLine($"Texting text to {owner.PhoneNumber}");
    }
}

public class Logger : ILogger
{
    public void Log(string msg)
    {
        Console.WriteLine($"Log message : {msg}");
    }
}

public static class Factory
{
    public static IPerson CreatePerson()
    {
        return new Person();
    }

    public static IChore CreateChore()
    {
        return new Chore(CreateLogger(), CreateMessageSender());
    }

    public static ILogger CreateLogger()
    {
        return new Logger();
    }

    public static IMessageSender CreateMessageSender()
    {
        //return new Emailer();
        return new Texter();
    }
}


//internal class DIP
//{
//    public static void Run()
//    {
//        Person owner = new Person
//        {
//            FirstName = "Milan",
//            LastName = "Sangani",
//            EmailAddress = "milan@ms0713.com",
//            PhoneNumber = "123-4567"
//        };

//        Chore chore = new()
//        {
//            ChoreName = "Take out the trash",
//            Owner = owner,
//        };

//        chore.PerformedWork(3);
//        chore.PerformedWork(1.5);
//        chore.CompleteChore();

//        Console.ReadLine();
//    }
//}

//public class Person
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public string EmailAddress { get; set; }
//    public string PhoneNumber { get; set; }
//}

//public class Chore
//{
//    public string ChoreName { get; set; }
//    public Person Owner { get; set; }
//    public double HoursWorked { get; private set; }
//    public bool IsComplete { get; private set; }

//    internal void CompleteChore()
//    {
//        IsComplete = true;

//        Logger logger = new();
//        logger.Log($"Completed {ChoreName}");

//        Emailer emailer = new();
//        emailer.SendEmail(Owner, $"The chore {ChoreName} is complete.");
//    }

//    internal void PerformedWork(double hours)
//    {
//        HoursWorked += hours;
//        Logger log = new();
//        log.Log($"Performed work on {ChoreName}");
//    }
//}

//public class Emailer
//{
//    internal void SendEmail(Person owner, string msg)
//    {
//        Console.WriteLine($"Sending email to {owner.EmailAddress}");
//    }
//}

//public class Logger
//{
//    internal void Log(string msg)
//    {
//        Console.WriteLine($"Log message : {msg}");
//    }
//}