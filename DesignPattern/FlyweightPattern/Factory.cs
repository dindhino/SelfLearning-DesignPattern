public class ShapeFactory
{
    private static readonly Dictionary<string, Circle> circleMap = new Dictionary<string, Circle>();

    public static Shape GetCircle(string color)
    {
        Circle circle = (Circle)circleMap.GetValueOrDefault(color);

        if (circle == null)
        {
            circle = new Circle(color);
            circleMap.Add(color, circle);
            Console.WriteLine("Creating circle of color : " + color);
        }

        return circle;
    }
}