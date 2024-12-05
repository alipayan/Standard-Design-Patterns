using Calculator;

Console.WriteLine("Enter an expression to evaluate: ");

string expression = Console.ReadLine();

if (string.IsNullOrEmpty(expression))
{
    while (string.IsNullOrEmpty(expression))
    {
        Console.WriteLine("Please enter an expression.");
        expression = Console.ReadLine();
    }
}

// Create interpreter
Context context = new Context();
Interpreter interpreter = new Interpreter(context);

// Interpret expression
int result = interpreter.Interpret(expression);
Console.WriteLine("Result: " + result);