public class Cricket : Game
{
    public override void EndPlay()
    {
        Console.WriteLine("Cricket Game Finished!");
    }

    public override void Initialize()
    {
        Console.WriteLine("Cricket Game Initialized! Start playing.");
    }

    public override void StartPlay()
    {
        Console.WriteLine("Cricket Game Started. Enjoy the game!");
    }
}

public class Football : Game
{
    public override void EndPlay()
    {
        Console.WriteLine("Football Game Finished!");
    }

    public override void Initialize()
    {
        Console.WriteLine("Football Game Initialized! Start playing.");
    }

    public override void StartPlay()
    {
        Console.WriteLine("Football Game Started. Enjoy the game!");
    }
}