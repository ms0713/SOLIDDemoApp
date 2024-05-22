namespace SOLIDDemo.SRP;

public class AccountGenerator
{
    public static void CreateAccount(Person person)
    {
        Console.WriteLine($"Username : {person.FirstName.Substring(0, 1)}{person.LastName}");
    }
}
