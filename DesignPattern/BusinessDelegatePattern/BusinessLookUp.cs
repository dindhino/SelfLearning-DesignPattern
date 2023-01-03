public class BusinessLookUp
{
    public BusinessService GetBusinessService(string serviceType) => serviceType.ToUpper() == "EJB".ToUpper() ? new EJBService() : new JMSService();
}