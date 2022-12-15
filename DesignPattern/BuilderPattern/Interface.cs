public interface Packing 
{
    public string Pack();
}

public interface Item
{
    public string Name();
    public Packing ItemPack();
    public float Price();
}