public abstract class Burger : Item
{
    public abstract string Name();
    public Packing ItemPack() => new Wrapper();
    public abstract float Price();
}

public abstract class ColdDrink : Item
{
    public abstract string Name();
    public Packing ItemPack() => new Bottle();
    public abstract float Price();
}