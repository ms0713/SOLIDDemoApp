namespace SOLIDDemo.SRP;

internal class SRP
{
    //public static void Run()
    //{
    //    Console.WriteLine("Welcome to the appplication");

    //    Person user = new();

    //    Console.WriteLine("What is your first name: ");
    //    user.FirstName = Console.ReadLine();

    //    Console.WriteLine("What is your last name: ");
    //    user.LastName = Console.ReadLine();

    //    if (string.IsNullOrWhiteSpace(user.FirstName))
    //    {
    //        Console.WriteLine("Invalid first name");
    //        Console.ReadLine();
    //        return;
    //    }

    //    if (string.IsNullOrWhiteSpace(user.LastName))
    //    {
    //        Console.WriteLine("Invalid last name");
    //        Console.ReadLine();
    //        return;
    //    }

    //    Console.WriteLine($"Username : {user.FirstName.Substring(0,1)}{user.LastName}");
    //    Console.ReadLine();
    //}

    public static void Run()
    {
        StandardMessages.WelcomeMessage();

        var user = PersonDataCapture.Capture();

        var isValid = PersonValidator.Validate(user);

        if (isValid == false)
        {
            StandardMessages.EndApplication();
            return;
        }

        AccountGenerator.CreateAccount(user);

        StandardMessages.EndApplication();

    }
}
