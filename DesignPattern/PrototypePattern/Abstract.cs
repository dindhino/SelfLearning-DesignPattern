public abstract class Shape : ICloneable
{
    private string id;
    protected string type;

    public abstract void draw();

    public string getType()
    {
        return type;
    }

    public string getId()
    {
        return id;
    }

    public void setId(string id)
    {
        this.id = id;
    }

    public object Clone()
    {
        object clone = null;

        try
        {
            clone = base.MemberwiseClone();
        }
        catch (NotSupportedException e)
        {
            Console.WriteLine(e.Message);
        }

        return clone;
    }
}