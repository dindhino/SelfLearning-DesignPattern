// See https://aka.ms/new-console-template for more information

AbstractFactory shapeFactory = FactoryProducer.getFactory(false);

Shape rectangleShape = shapeFactory.GetShape("RECTANGLE");
rectangleShape.Draw();

Shape squareShape = shapeFactory.GetShape("SQUARE");
squareShape.Draw();


AbstractFactory roundedShapeFactory = FactoryProducer.getFactory(true);

Shape roundedRectangleShape = roundedShapeFactory.GetShape("RECTANGLE");
roundedRectangleShape.Draw();

Shape roundedSquareShare = roundedShapeFactory.GetShape("SQUARE");
roundedSquareShare.Draw();

Console.ReadLine();