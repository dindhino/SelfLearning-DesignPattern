public class ComputerPartDisplayVisitor : ComputerPartVisitor
{
    public void Visit(Computer computer)
    {
        Console.WriteLine("Diplaying Computer.");
    }

    public void Visit(Mouse mouse)
    {
        Console.WriteLine("Diplaying Mouse.");
    }

    public void Visit(Keyboard keyboard)
    {
        Console.WriteLine("Diplaying Keyboard.");
    }

    public void Visit(Monitor monitor)
    {
        Console.WriteLine("Diplaying Monitor.");
    }
}
