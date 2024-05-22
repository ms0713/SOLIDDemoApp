namespace SOLIDDemo.SRP;

public class StandardMessages
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the appplication");
    }

    public static void DisplayValidationError(string fieldName)
    {
        Console.WriteLine($"Invalid {fieldName}");
    }

    public static void EndApplication()
    {
        Console.WriteLine("Press enter to close...");
        Console.ReadLine();
    }
}
