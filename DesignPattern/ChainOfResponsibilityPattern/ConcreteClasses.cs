public class ConsoleLogger : AbstractLogger
{
    public ConsoleLogger(int level)
    {
        this.level = level;
    }

    protected override void Write(string message)
    {
        Console.WriteLine("Standard Console::Logger: " + message);
    }
}

public class ErrorLogger : AbstractLogger
{
    public ErrorLogger(int level)
    {
        this.level = level;
    }

    protected override void Write(string message)
    {
        Console.WriteLine("Error Console::Logger: " + message);
    }
}

public class FileLogger : AbstractLogger
{
    public FileLogger(int level)
    {
        this.level = level;
    }

    protected override void Write(string message)
    {
        Console.WriteLine("File::Logger: " + message);
    }
}