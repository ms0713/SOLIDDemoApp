namespace SOLIDDemo.DIP;

public interface IMessageSender
{
    void SendMessage(IPerson person, string message);
}