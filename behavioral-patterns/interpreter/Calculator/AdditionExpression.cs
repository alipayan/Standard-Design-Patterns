namespace Calculator;

internal class AdditionExpression : IExpression
{

    private IExpression left;
    private IExpression right;

    public AdditionExpression(IExpression left, IExpression right)
    {
        this.left = left;
        this.right = right;
    }

    public int Interpret(Context context)
    {
        return left.Interpret(context) + right.Interpret(context);
    }
}