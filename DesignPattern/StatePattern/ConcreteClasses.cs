public class StartState : State
{
    public void DoAction(Context context)
    {
        Console.WriteLine("Player is in start state");
        context.SetState(this);
    }
    public string ToString() => "Start State";
}

public class StopState : State
{
    public void DoAction(Context context)
    {
        Console.WriteLine("Player is in stop state");
        context.SetState(this);
    }
    public string ToString() => "Stop State";
}