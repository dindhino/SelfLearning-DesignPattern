public class Subject
{
    private List<Observer> observers = new List<Observer>();
    private int state;
    public int GetState() => state;
    public void SetState(int state)
    { 
        this.state = state;
        NotifyAllObservers();
    }
    private void NotifyAllObservers() => observers.ForEach(observer => observer.Update());
    public void Attach(Observer observer) => observers.Add(observer);
}
