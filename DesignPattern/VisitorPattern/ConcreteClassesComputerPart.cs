public class Keyboard : ComputerPart
{
    public void Accept(ComputerPartVisitor computerPartVisitor)
    {
        computerPartVisitor.Visit(this);
    }
}
public class Monitor : ComputerPart
{
    public void Accept(ComputerPartVisitor computerPartVisitor)
    {
        computerPartVisitor.Visit(this);
    }
}
public class Mouse : ComputerPart
{
    public void Accept(ComputerPartVisitor computerPartVisitor)
    {
        computerPartVisitor.Visit(this);
    }
}

public class Computer : ComputerPart
{
    List<ComputerPart> parts;
    public Computer() => this.parts = new List<ComputerPart>() { new Mouse(), new Keyboard(), new Monitor() };
    public void Accept(ComputerPartVisitor computerPartVisitor)
    {
        for (int i = 0; i < parts.Count; i++)
        {
            parts[i].Accept(computerPartVisitor);
        }
        computerPartVisitor.Visit(this);
    }
}
