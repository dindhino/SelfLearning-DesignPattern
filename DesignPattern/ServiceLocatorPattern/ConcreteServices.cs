public class Service1 : Service
{
    void Service.Execute() => Console.WriteLine("Executing Service1");

    string Service.GetName() => "Service1";
}

public class Service2 : Service
{
    void Service.Execute() => Console.WriteLine("Executing Service2");

    string Service.GetName() => "Service2";
}