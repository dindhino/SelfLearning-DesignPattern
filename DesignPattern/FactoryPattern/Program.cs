// See https://aka.ms/new-console-template for more information

ShapeFactory shapeFactory = new ShapeFactory();

Shape circleShape = shapeFactory.GetShape("CIRCLE");
circleShape.Draw();

Shape rectangleShape = shapeFactory.GetShape("RECTANGLE");
rectangleShape.Draw();

Shape squareShape = shapeFactory.GetShape("SQUARE");
squareShape.Draw();

Console.ReadLine();