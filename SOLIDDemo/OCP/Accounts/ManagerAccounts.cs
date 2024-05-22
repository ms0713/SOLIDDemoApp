using SOLIDDemo.OCP.Applicants;

namespace SOLIDDemo.OCP.Accounts;

internal class ManagerAccounts : IAccounts
{
    public EmployeeModel Create(IApplicantModel person)
    {
        var output = new EmployeeModel
        {
            FirstName = person.FirstName,
            LastName = person.LastName,
            EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@acmecorp.com",
            IsManager = true
        };

        return output;
    }
}
