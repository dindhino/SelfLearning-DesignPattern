public interface Iterator
{
    public bool HasNext();
    public object Next();
}

public interface Container
{
    public Iterator GetIterator();
}