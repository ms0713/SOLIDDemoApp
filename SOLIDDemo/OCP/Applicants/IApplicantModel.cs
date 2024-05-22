using SOLIDDemo.OCP.Accounts;

namespace SOLIDDemo.OCP.Applicants
{
    public interface IApplicantModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        IAccounts AccountProcessor { get; set; }
    }
}