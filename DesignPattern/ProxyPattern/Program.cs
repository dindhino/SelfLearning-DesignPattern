// See https://aka.ms/new-console-template for more information
Image image = new ProxyImage("test_10mb.jpg");
Console.WriteLine("Image will be loaded from disk...");
image.Display();

Console.WriteLine("\nImage will not be loaded from disk...");
image.Display();

Console.ReadLine();