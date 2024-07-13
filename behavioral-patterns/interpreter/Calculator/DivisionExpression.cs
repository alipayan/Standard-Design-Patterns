namespace Calculator;

internal class DivisionExpression : IExpression
{
    private IExpression left;
    private IExpression right;

    public DivisionExpression(IExpression left, IExpression right)
    {
        this.left = left;
        this.right = right;
    }

    public int Interpret(Context context)
    {
        return left.Interpret(context) / right.Interpret(context);
    }
}