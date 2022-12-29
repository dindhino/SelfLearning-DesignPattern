// See https://aka.ms/new-console-template for more information
Context context = new Context();

StartState startState = new StartState();
startState.DoAction(context);

Console.WriteLine(context.GetState().ToString());

StopState stopState = new StopState();
stopState.DoAction(context);

Console.WriteLine(context.GetState().ToString());

Console.ReadLine();
