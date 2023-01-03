// See https://aka.ms/new-console-template for more information
Client client = new Client();
client.SetData("Test", "Data");
client.PrintData();
client.SetData("Second Test", "Data1");
client.PrintData();

Console.ReadLine();
