public class ShapeFactory : AbstractFactory
{
    public override Shape GetShape(string shapeType)
    {
        if (shapeType.ToUpper().Equals("RECTANGLE"))
        {
            return new Rectangle();

        }
        else if (shapeType.ToUpper().Equals("SQUARE"))
        {
            return new Square();
        }
        else
        {
            return null;
        }
    }
}

public class RoundedShapeFactory : AbstractFactory
{
    public override Shape GetShape(string shapeType)
    {
        if (shapeType.ToUpper().Equals("RECTANGLE"))
        {
            return new RoundedRectangle();

        }
        else if (shapeType.ToUpper().Equals("SQUARE"))
        {
            return new RoundedSquare();
        }
        else
        {
            return null;
        }
    }
}