using Mediator.ChatSystem;

Console.WriteLine("Wellcome to our chat!");

var group1 = new Room();
var group2 = new Room();

var ali = new ChatUser(group1, "ali");
var reza = new ChatUser(group1, "reza");
var mohammad = new ChatUser(group1, "mohammad");
var nabi = new ChatUser(group2, "nabi");
var alex = new ChatUser(group2, "alex");

group1.RegisterUser(ali);
group1.RegisterUser(reza);
group1.RegisterUser(mohammad);

group2.RegisterUser(nabi);
group2.RegisterUser(alex);

ali.SendMessage("Hello, I'm ali");

reza.SendMessage("Hello ali,nice to meet you. I'm reza");

mohammad.SendMessage("Hey guys. welcome to our mediator chat!");


nabi.SendMessage("Hello, I'm nabi");

alex.SendMessage("Hello nabi,nice to meet you. I'm alex");

nabi.SendMessage("Hey guys. welcome to our mediator chat!");
