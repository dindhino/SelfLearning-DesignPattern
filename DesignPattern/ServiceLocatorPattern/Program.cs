// See https://aka.ms/new-console-template for more information
Service service = ServiceLocator.GetService("Service1");
service.Execute();
service = ServiceLocator.GetService("Service2");
service.Execute();
service = ServiceLocator.GetService("Service1");
service.Execute();
service = ServiceLocator.GetService("Service2");
service.Execute();

Console.ReadLine();