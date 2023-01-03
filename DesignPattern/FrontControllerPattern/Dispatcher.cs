public class Dispatcher
{
    private StudentView studentView;
    private HomeView homeView;

    public Dispatcher()
    {
        studentView = new StudentView();
        homeView = new HomeView();
    }

    public void Dispatch(string request)
    {
        if (request.ToUpper() == "STUDENT".ToUpper())
        {
            studentView.Show();
        }
        else
        {
            homeView.Show();
        }
    }
}