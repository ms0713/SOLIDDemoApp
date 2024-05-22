using SOLIDDemo.OCP.Accounts;

namespace SOLIDDemo.OCP.Applicants;

internal class ManagerModel : IApplicantModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IAccounts AccountProcessor { get; set; } = new ManagerAccounts();
}
