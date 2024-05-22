using SOLIDDemo.OCP.Applicants;

namespace SOLIDDemo.OCP.Accounts
{
    public interface IAccounts
    {
        EmployeeModel Create(IApplicantModel person);
    }
}