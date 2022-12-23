public class TerminalExpression : Expression
{
    private string data;
    public TerminalExpression(string data)
    {
        this.data = data;
    }
    bool Expression.Interpret(string context)
    {
        if (context.ToLower().Contains(data.ToLower()))
            return true;
        return false;
    }
}
public class OrExpression : Expression
{
    private Expression expr1 = null;
    private Expression expr2 = null;
    public OrExpression(Expression expr1, Expression expr2)
    {
        this.expr1 = expr1;
        this.expr2 = expr2;
    }
    bool Expression.Interpret(string context)
    {
        return expr1.Interpret(context) || expr2.Interpret(context);
    }
}
public class AndExpression : Expression
{
    private Expression expr1 = null;
    private Expression expr2 = null;
    public AndExpression(Expression expr1, Expression expr2)
    {
        this.expr1 = expr1;
        this.expr2 = expr2;
    }
    bool Expression.Interpret(string context)
    {
        return expr1.Interpret(context) && expr2.Interpret(context);
    }
}

