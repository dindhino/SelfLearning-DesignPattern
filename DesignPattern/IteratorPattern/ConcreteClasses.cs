public class NameRepository : Container
{
    public List<string> names = new List<string>() { "Robert", "John", "Julie", "Lora" };
    public Iterator GetIterator()
    {
        return new NameIterator();
    }

    private class NameIterator : Iterator
    {
        int index = 0;
        List<string> names = new NameRepository().names;
        public bool HasNext() => index < names.Count;
        public object Next() => this.HasNext() ? names[index++] : null;
    }
}