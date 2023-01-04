public class AuthenticationFilter : Filter
{
    void Filter.Execute(string request) => Console.WriteLine("Authenticating request: " + request);
}

public class DebugFilter : Filter
{
    void Filter.Execute(string request) => Console.WriteLine("Request log: " + request);
}