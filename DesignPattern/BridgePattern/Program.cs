// See https://aka.ms/new-console-template for more information
Shape redCircle = new Circle(100, 100, 10, new RedCircle());
Shape greenCircle = new Circle(100, 100, 10, new GreenCircle());

redCircle.Draw();
greenCircle.Draw();

Console.ReadLine();