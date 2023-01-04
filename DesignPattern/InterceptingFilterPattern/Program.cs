// See https://aka.ms/new-console-template for more information
FilterManager filterManager = new FilterManager(new Target());
filterManager.SetFilter(new AuthenticationFilter());
filterManager.SetFilter(new DebugFilter());

Client client = new Client();
client.SetFilterManager(filterManager);
client.SendRequest("HOME");

Console.ReadLine();
