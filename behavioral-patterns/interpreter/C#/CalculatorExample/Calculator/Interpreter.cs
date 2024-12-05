namespace Calculator;

public class Interpreter
{
    private Context context;

    public Interpreter(Context context)
    {
        this.context = context;
    }

    public int Interpret(string expression)
    {
        // Parse expression and create expression tree
        IExpression expressionTree = BuildExpressionTree(expression);

        // Interpret expression tree
        return expressionTree.Interpret(context);
    }

    private IExpression BuildExpressionTree(string expression)
    {
        expression = expression.Trim();

        // Split the expression into individual tokens
        List<string> tokens = TokenizeExpression(expression);

        // Convert the tokens into an expression tree
        IExpression expressionTree = ConvertToExpressionTree(tokens);

        return expressionTree;
    }

    private List<string> TokenizeExpression(string expression)
    {
        List<string> tokens = new List<string>();
        string currentToken = "";

        foreach (char c in expression)
        {
            if (char.IsDigit(c))
            {
                currentToken += c;
            }
            else if (char.IsWhiteSpace(c))
            {
                if (!string.IsNullOrEmpty(currentToken))
                {
                    tokens.Add(currentToken);
                    currentToken = "";
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(currentToken))
                {
                    tokens.Add(currentToken);
                    currentToken = "";
                }
                tokens.Add(c.ToString());
            }
        }

        if (!string.IsNullOrEmpty(currentToken))
        {
            tokens.Add(currentToken);
        }

        return tokens;
    }

    private IExpression ConvertToExpressionTree(List<string> tokens)
    {
        Stack<IExpression> expressionStack = new Stack<IExpression>();
        Stack<string> operatorStack = new Stack<string>();

        foreach (string token in tokens)
        {
            if (IsNumber(token))
            {
                expressionStack.Push(new NumberExpression(int.Parse(token)));
            }
            else if (IsOperator(token))
            {
                while (operatorStack.Count > 0 && Precedence(operatorStack.Peek()) >= Precedence(token))
                {
                    string op = operatorStack.Pop();
                    IExpression right = expressionStack.Pop();
                    IExpression left = expressionStack.Pop();

                    expressionStack.Push(CreateBinaryExpression(op, left, right));
                }

                operatorStack.Push(token);
            }
        }

        while (operatorStack.Count > 0)
        {
            string op = operatorStack.Pop();
            IExpression right = expressionStack.Pop();
            IExpression left = expressionStack.Pop();

            expressionStack.Push(CreateBinaryExpression(op, left, right));
        }

        return expressionStack.Pop();
    }

    private bool IsNumber(string token)
    {
        return int.TryParse(token, out _);
    }

    private bool IsOperator(string token)
    {
        return token == "+" || token == "-" || token == "*" || token == "/";
    }

    private int Precedence(string op)
    {
        if (op == "+" || op == "-")
        {
            return 1;
        }
        else if (op == "*" || op == "/")
        {
            return 2;
        }

        return 0;
    }

    private IExpression CreateBinaryExpression(string op, IExpression left, IExpression right)
    {
        switch (op)
        {
            case "+":
                return new AdditionExpression(left, right);
            case "-":
                return new SubtractionExpression(left, right);
            case "*":
                return new MultiplicationExpression(left, right);
            case "/":
                return new DivisionExpression(left, right);
            default:
                throw new ArgumentException($"Invalid operator: {op}");
        }
    }
}
