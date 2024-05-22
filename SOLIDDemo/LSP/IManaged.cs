namespace SOLIDDemo.LSP;

internal interface IManaged : IEmployee
{
    IEmployee Manager { get; set; }
    void AssignManager(IEmployee manager);
}
