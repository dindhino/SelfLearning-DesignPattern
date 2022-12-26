public class User
{
    private string name;

    public string GetName() => name;
    public User(string name)
    {
        this.name = name;
    }

    public void SendMessage(string message)
    {
        ChatRoom.ShowMessage(this, message);
    }
}