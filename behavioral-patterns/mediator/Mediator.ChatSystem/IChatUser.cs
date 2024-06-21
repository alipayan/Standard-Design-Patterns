namespace Mediator.ChatSystem
{
    public interface IChatUser
    {
        public string Name { get; }

        void SendMessage(string message);

        void RecieveMessage(string message);
    }
}
