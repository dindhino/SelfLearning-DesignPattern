public class CareTaker
{
    private List<Memento> mementoList = new List<Memento>();
    public void Add(Memento state) => mementoList.Add(state);
    public Memento Get(int index) => mementoList[index];
}