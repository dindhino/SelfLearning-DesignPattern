public class BinaryObserver : Observer
{
    public BinaryObserver(Subject subject)
    {
        this.subject = subject;
        this.subject.Attach(this);
    }
    public override void Update()
    {
        Console.WriteLine("Binary String: " + Convert.ToString(subject.GetState(), 2));
    }
}

public class OctalObserver : Observer
{
    public OctalObserver(Subject subject)
    {
        this.subject = subject;
        this.subject.Attach(this);
    }
    public override void Update()
    {
        Console.WriteLine("Octal String: " + Convert.ToString(subject.GetState(), 8));
    }
}

public class HexaObserver : Observer
{
    public HexaObserver(Subject subject)
    {
        this.subject = subject;
        this.subject.Attach(this);
    }
    public override void Update()
    {
        Console.WriteLine("Hex String: " + Convert.ToString(subject.GetState(), 16));
    }
}