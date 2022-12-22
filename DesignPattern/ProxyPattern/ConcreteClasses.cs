public class RealImage : Image
{
    private string fileName;

    public RealImage(string fileName)
    {
        this.fileName = fileName;
        loadFromDisk(fileName);
    }

    private void loadFromDisk(string fileName)
    {
        Console.WriteLine("Loading " + fileName);
    }

    public void Display()
    {
        Console.WriteLine("Displaying " + fileName);
    }
}

public class ProxyImage : Image
{
    private RealImage realImage;
    private string fileName;

    public ProxyImage(string fileName)
    {
        this.fileName = fileName;
    }

    void Image.Display()
    {
        if (realImage == null)
        {
            realImage = new RealImage(fileName);
        }
        realImage.Display();
    }
}