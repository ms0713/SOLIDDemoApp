using SOLIDDemo.OCP.Applicants;

namespace SOLIDDemo.OCP.Accounts;

internal class ExecutiveAccounts : IAccounts
{
    public EmployeeModel Create(IApplicantModel person)
    {
        var output = new EmployeeModel
        {
            FirstName = person.FirstName,
            LastName = person.LastName,
            EmailAddress = $"{person.FirstName}{person.LastName}@acmecorp.com",
            IsManager = true,
            IsExecutive = true
        };

        return output;
    }
}
