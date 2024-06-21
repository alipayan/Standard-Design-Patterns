namespace Mediator.ChatSystem;

public interface IChatMediator
{
    void RegisterUser(IChatUser chatUser);

    void UnregisterUser(IChatUser chatUser);

    void SendMessage(string senderName, string message);
}
