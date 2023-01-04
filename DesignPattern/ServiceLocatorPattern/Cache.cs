public class Cache
{
    private List<Service> services;
    public Cache() => services = new List<Service>();
    public Service GetService(string serviceName)
    {
        Service service = services.FirstOrDefault(x => x.GetName().ToUpper() == serviceName.ToUpper());
        if (service != null)
            Console.WriteLine("Returning cached " + serviceName + " object");
        return service;
    }
    public void AddService(Service newService)
    {
        if (services.Any(x => x.GetName().ToUpper() == newService.GetName().ToUpper()) == false)
            services.Add(newService);
    }
}