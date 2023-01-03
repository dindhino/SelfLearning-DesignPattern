public class EJBService : BusinessService
{
    void BusinessService.DoProcessing() => Console.WriteLine("Processing task by invoking EJB Service");
}

public class JMSService : BusinessService
{
    void BusinessService.DoProcessing() => Console.WriteLine("Processing task by invoking JMS Service");
}