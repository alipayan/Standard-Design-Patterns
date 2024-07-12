namespace Calculator;

internal class MultiplicationExpression : IExpression
{
    private IExpression left;
    private IExpression right;

    public MultiplicationExpression(IExpression left, IExpression right)
    {
        this.left = left;
        this.right = right;
    }

    public int Interpret(Context context)
    {
        return left.Interpret(context) * right.Interpret(context);
    }
}