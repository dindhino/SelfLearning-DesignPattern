public class ShapeFactory
{
    public Shape GetShape(String shapeType)
    {
        if (shapeType.ToUpper().Equals("CIRCLE"))
        {
            return new Circle();
        }
        else if (shapeType.ToUpper().Equals("RECTANGLE"))
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