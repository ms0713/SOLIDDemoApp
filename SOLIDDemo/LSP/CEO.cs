namespace SOLIDDemo.LSP;

public class CEO : BaseEmployee, IManager
{
    public override void CalculatePerHourRate(int rank)
    {
        decimal baseAmount = 150M;

        Salary = baseAmount * rank;
    }

    public void GeneratePerformanceReview()
    {
        Console.WriteLine("I m reviewing a direct report's performance");
    }

    public void FireSomeone()
    {
        Console.WriteLine("You are fired!");
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


