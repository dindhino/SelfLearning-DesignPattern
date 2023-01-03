public class FrontController
{
    private Dispatcher dispatcher;

    public FrontController()
    {
        dispatcher = new Dispatcher();
    }

    private bool IsAuthenticUser()
    {
        Console.WriteLine("User is authenticated successfully.");
        return true;
    }

    private void TrackRequest(String request)
    {
        Console.WriteLine("Page requested: " + request);
    }

    public void DispatchRequest(String request)
    {
        TrackRequest(request);

        if (IsAuthenticUser())
        {
            dispatcher.Dispatch(request);
        }
    }
}