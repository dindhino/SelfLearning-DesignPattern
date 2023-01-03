public class BusinessDelegate
{
    private BusinessLookUp lookUpService = new BusinessLookUp();
    private BusinessService businessService;
    private string serviceType;

    public void SetServiceType(string serviceType) => this.serviceType = serviceType;

    public void DoTask() 
    {
        businessService = lookUpService.GetBusinessService(this.serviceType);
        businessService.DoProcessing();
    }
}