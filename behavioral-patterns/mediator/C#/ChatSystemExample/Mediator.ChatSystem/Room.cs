namespace Mediator.ChatSystem;
public class Room : IChatMediator
{
    private readonly IList<IChatUser> _users;

    public Room()
    {
        _users = new List<IChatUser>();
    }

    public void RegisterUser(IChatUser chatUser)
        => _users.Add(chatUser);

    public void UnregisterUser(IChatUser chatUser)
        => _users.Remove(chatUser);

    public void SendMessage(string senderName, string message)
    {
        foreach (var user in _users)
        {
            if (!user.Name.Equals(senderName))
                user.RecieveMessage(message);
        }
    }
}
