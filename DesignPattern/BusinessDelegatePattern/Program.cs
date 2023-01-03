// See https://aka.ms/new-console-template for more information
BusinessDelegate businessDelegate = new BusinessDelegate();
businessDelegate.SetServiceType("EJB");

Client client = new Client(businessDelegate);
client.DoTask();

businessDelegate.SetServiceType("JMS");
client.DoTask();

Console.ReadLine();