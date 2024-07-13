using Calculator;

string expression = "2 + 3 * 4";

// Create interpreter
Context context = new Context();
Interpreter interpreter = new Interpreter(context);

// Interpret expression
int result = interpreter.Interpret(expression);
Console.WriteLine("Result: " + result);