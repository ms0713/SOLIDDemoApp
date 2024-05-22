namespace SOLIDDemo.LSP;

/// <summary>
/// Liskov Substitute Principle
/// 1. If S is a subtype of T, then T maybe replace S without breaking program.
/// 2. Here Base type Employee should be replaceable by Manager, CEO
/// 3. It will break in case of CEO, it will work with Manager
/// 4. Co-variance talks about return type of method
/// 5. Contra-variance talks about input type of method
/// 6. Pre Condition : You cannot strengthen it (validation on input type)
/// 7. Post Condition : You cannot weaken it (return type range)
/// 8. Its all about writing a good Inheritance
/// </summary>
internal class LSP
{
    public static void Run()
    {
        Manager accountingVP = new();
        accountingVP.FirstName = "Milan";
        accountingVP.LastName = "Sangani";
        accountingVP.CalculatePerHourRate(4);

        Employee employee = new Manager();
        employee.FirstName = "Milan";
        employee.LastName = "Sangani";
        employee.AssignManager(accountingVP);
        employee.CalculatePerHourRate(4);

        Console.WriteLine($"{employee.FirstName}'s salary is ${employee.Salary}/hour.");

        Console.ReadLine();
    }
}

//internal class LSP
//{
//    public static void Run()
//    {
//        Manager accountingVP = new();
//        accountingVP.FirstName = "Milan";
//        accountingVP.LastName = "Sangani";
//        accountingVP.CalculatePerHourRate(4);

//        Employee employee = new();
//        employee.FirstName = "Milan";
//        employee.LastName = "Sangani";
//        employee.AssignManager(accountingVP);
//        employee.CalculatePerHourRate(4);

//        Console.WriteLine($"{employee.FirstName}'s salary is ${employee.Salary}/hour.");

//        Console.ReadLine();
//    }
//}

//public class Manager :Employee
//{
//    public override void CalculatePerHourRate(int rank)
//    {
//        decimal baseAmount = 19.75M;

//        Salary = baseAmount + (rank * 4);
//    }

//    public void GeneratePerformanceReview()
//    {
//        Console.WriteLine("I m reviewing a direct report's performance");
//    }
//}

//public class Employee
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public Employee Manager { get; set; } = null;
//    public decimal Salary { get; set; }

//    public virtual void AssignManager(Employee manager)
//    {
//        Manager = manager;
//    }

//    public virtual void CalculatePerHourRate(int rank)
//    {
//        decimal baseAmount = 12.50M;

//        Salary = baseAmount + (rank * 2);
//    }


//}

//public class CEO : Employee
//{
//    public override void CalculatePerHourRate(int rank)
//    {
//        decimal baseAmount = 150M;

//        Salary = baseAmount * rank;
//    }

//    public void GeneratePerformanceReview()
//    {
//        Console.WriteLine("I m reviewing a direct report's performance");
//    }

//    public virtual void AssignManager(Employee manager)
//    {
//        throw new InvalidOperationException("The CEO has no manager.");
//    }

//    public void FireSomeone()
//    {
//        Console.WriteLine("You are fired!");
//    }
//}


