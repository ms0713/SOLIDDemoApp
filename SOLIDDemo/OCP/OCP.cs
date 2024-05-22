using SOLIDDemo.OCP.Applicants;

namespace SOLIDDemo.OCP;

/// <summary>
/// 1. Close for modification but Open for extention
/// 2. Open Close Principle
/// 3. Once in production, we should not change it for new scenario
/// 4. New scenrio is some of the employees are Manager
/// and we need to identify it
/// 5. In development, it is allowed to create default property IsManager = false
/// 6. If there is bug in production, then it should be allowed to change.
/// 7. Do not tie up directly to classes, instead create interface
/// </summary>
internal class OCP
{
    public static void Run()
    {
        List<IApplicantModel> applicants =
        [
            new PersonModel
            {
                FirstName = "Milan",
                LastName = "Sangani",
            },
            new ManagerModel
            {
                FirstName = "Nayan",
                LastName = "Surani",
            },
            new ExecutiveModel
            {
                FirstName = "Pratik",
                LastName = "Thakkar",
            }
        ];

        List<EmployeeModel> employees = new();

        foreach (var person in applicants)
        {
            employees.Add(person.AccountProcessor.Create(person));
        }

        foreach (var emp in employees)
        {
            Console.WriteLine($"{emp.FirstName} " +
                $"{emp.LastName}:" +
                $" {emp.EmailAddress}" +
                $" IsManager {emp.IsManager}" +
                $" IsExecutive : {emp.IsExecutive}");
        }

        Console.ReadLine();
    }
}
