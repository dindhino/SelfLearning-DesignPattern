public class ShapeCache
{
    private static Dictionary<string, Shape> shapeMap = new Dictionary<string, Shape>();

    public static Shape getShape(string shapeId)
    {
        Shape cachedShape = shapeMap[shapeId];
        return (Shape)cachedShape.Clone();
    }

    public static void loadCache()
    {
        Circle circle = new Circle();
        circle.setId("circle");
        shapeMap.Add(circle.getId(), circle);

        Square square = new Square();
        square.setId("square");
        shapeMap.Add(square.getId(), square);

        Rectangle rectangle = new Rectangle();
        rectangle.setId("rectangle");
        shapeMap.Add(rectangle.getId(), rectangle);
    }
}