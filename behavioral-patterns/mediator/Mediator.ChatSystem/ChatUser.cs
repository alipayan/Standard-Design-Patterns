namespace Mediator.ChatSystem
{
    public class ChatUser : IChatUser
    {
        private IChatMediator _mediator;

        public string Name { get; }

        public ChatUser(IChatMediator chatMediator, string username)
        {
            _mediator = chatMediator;
            Name = username;
        }

        public void RecieveMessage(string message)
        {
            Console.WriteLine($"I'm {Name} and I'm recieving this message :{message}");
            Console.WriteLine("-----------------");
        }

        public void SendMessage(string message)
        {
            _mediator.SendMessage(Name, message);
        }
    }
}
