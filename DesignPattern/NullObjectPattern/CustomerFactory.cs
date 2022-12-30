using System.Xml.Linq;

public class CustomerFactory
{
    public static readonly List<string> names = new List<string>() { "Rob", "Joe", "Julie" };
    public static AbstractCustomer GetCustomer(string name) => names.Any(x => x.ToUpper() == name.ToUpper()) ? new RealCustomer(name) : new NullCustomer();
}