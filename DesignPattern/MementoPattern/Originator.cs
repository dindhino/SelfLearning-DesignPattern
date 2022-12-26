public class Originator
{
    private string state;
    public void SetState(string state) => this.state = state;
    public string GetState() => state;
    public Memento SaveStateToMemento() => new Memento(state);
    public void GetStateFromMemento(Memento memento) => this.state = memento.GetState();
}