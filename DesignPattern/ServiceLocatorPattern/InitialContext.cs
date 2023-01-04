public class InitialContext
{
    public Object Lookup(string jndiName)
    {
        if (jndiName.ToUpper() == "SERVICE1".ToUpper())
        {
            Console.WriteLine("Looking up and creating a new Service1 object");
            return new Service1();
        }
        else if (jndiName.ToUpper() == "SERVICE2".ToUpper())
        {
            Console.WriteLine("Looking up and creating a new Service2 object");
            return new Service2();
        }
        return null;
    }
}