internal class Program
{
    //Rule: Robert and John are male
    public static Expression GetMaleExpression()
    {
        Expression robert = new TerminalExpression("Robert");
        Expression john = new TerminalExpression("John");
        return new OrExpression(robert, john);
    }

    //Rule: Julie is a married women
    public static Expression GetMarriedWomanExpression()
    {
        Expression julie = new TerminalExpression("Julie");
        Expression married = new TerminalExpression("Married");
        return new AndExpression(julie, married);
    }
    private static void Main(string[] args)
    {
        Expression isMale = GetMaleExpression();
        Expression isMarriedWoman = GetMarriedWomanExpression();

        Console.WriteLine("John is male? " + isMale.Interpret("John"));
        Console.WriteLine("Julie is a married women? " + isMarriedWoman.Interpret("Married Julie"));

        Console.ReadLine();
    }
}