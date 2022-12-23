internal class ChainPatternDemo
{
    private static AbstractLogger GetChainOfLoggers()
    {
        AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
        AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
        AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

        errorLogger.SetNextLogger(fileLogger);
        fileLogger.SetNextLogger(consoleLogger);

        return errorLogger;
    }

    private static void Main(string[] args)
    {
        AbstractLogger loggerChain = GetChainOfLoggers();

        loggerChain.LogMessage(AbstractLogger.INFO,
           "This is an information.");

        Console.WriteLine("");

        loggerChain.LogMessage(AbstractLogger.DEBUG,
           "This is an debug level information.");

        Console.WriteLine("");

        loggerChain.LogMessage(AbstractLogger.ERROR,
           "This is an error information.");

        Console.ReadLine();
    }
}