public class Client
{
    private CompositeEntity compositeEntity = new CompositeEntity();

    public void PrintData()
    {
        foreach (string data in compositeEntity.GetData())
        {
            Console.WriteLine("Data: " + data);
        }
    }

    public void SetData(string data1, string data2) => compositeEntity.SetData(data1, data2);
}