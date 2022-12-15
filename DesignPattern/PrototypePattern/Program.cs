// See https://aka.ms/new-console-template for more information
ShapeCache.loadCache();

Shape clonedCircleShape = (Shape)ShapeCache.getShape("circle");
Console.WriteLine("Shape : " + clonedCircleShape.getType());

Shape clonedSquareShape = (Shape)ShapeCache.getShape("square");
Console.WriteLine("Shape : " + clonedSquareShape.getType());

Shape clonedRectangleShape = (Shape)ShapeCache.getShape("rectangle");
Console.WriteLine("Shape : " + clonedRectangleShape.getType());

Console.ReadLine();
