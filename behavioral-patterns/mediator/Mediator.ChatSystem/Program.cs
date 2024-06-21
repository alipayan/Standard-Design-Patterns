using Mediator.ChatSystem;

Console.WriteLine("Wellcome to our chat!");

var mediator = new ChatMediator();

var ali = new ChatUser(mediator, "ali");
var reza = new ChatUser(mediator, "reza");
var mohammad = new ChatUser(mediator, "mohammad");

mediator.RegisterUser(ali);
mediator.RegisterUser(reza);
mediator.RegisterUser(mohammad);

ali.SendMessage("Hello, I'm ali");

reza.SendMessage("Hello ali,nice to meet you. I'm reza");

mohammad.SendMessage("Hey guys. welcome to our mediator chat!");
