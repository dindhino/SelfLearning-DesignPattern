// See https://aka.ms/new-console-template for more information
Subject subject = new Subject();

new HexaObserver(subject);
new OctalObserver(subject);
new BinaryObserver(subject);

Console.WriteLine("First state change: 15");
subject.SetState(15);
Console.WriteLine();
Console.WriteLine("Second state change: 10");
subject.SetState(10);

Console.ReadLine();