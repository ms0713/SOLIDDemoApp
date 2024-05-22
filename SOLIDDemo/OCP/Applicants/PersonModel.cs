using SOLIDDemo.OCP.Accounts;

using StaffAccounts = SOLIDDemo.OCP.Accounts.Accounts;

namespace SOLIDDemo.OCP.Applicants;

public class PersonModel : IApplicantModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IAccounts AccountProcessor { get; set; } = new StaffAccounts();
}
