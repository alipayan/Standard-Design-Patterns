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
        IExpression expressionTree = buildExpressionTree(expression);

        // Interpret expression tree
        return expressionTree.Interpret(context);
    }

    private IExpression buildExpressionTree(string expression)
    {
        // Logic to parse expression and create expression tree
        // For simplicity, assume the expression is already parsed
        // and represented as an expression tree
        return new AdditionExpression(
new NumberExpression(2),
new MultiplicationExpression(
new NumberExpression(3),
new NumberExpression(4)
)
);
    }
}