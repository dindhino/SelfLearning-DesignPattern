// See https://aka.ms/new-console-template for more information
FrontController frontController = new FrontController();
frontController.DispatchRequest("HOME");
frontController.DispatchRequest("STUDENT");

Console.ReadLine();