public class ServiceLocator
{
    private static Cache cache;

    static ServiceLocator()
    {
        cache = new Cache();
    }

    public static Service GetService(string jndiName)
    {
        Service service = cache.GetService(jndiName);
        if (service != null)
            return service;

        InitialContext context = new InitialContext();
        Service selectedService = (Service)context.Lookup(jndiName);
        cache.AddService(selectedService);
        return selectedService;
    }
}