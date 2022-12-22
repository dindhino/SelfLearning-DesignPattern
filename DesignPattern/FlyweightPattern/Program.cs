internal class FlyweightPatternDemo
{
    private static readonly List<string> colors = new List<string> { "Red", "Green", "Blue", "White", "Black" };
    private static readonly Random random = new Random();
    private static string getRandomColor()
    {
        return colors[(int)(random.Next(0, colors.Count))];
    }
    private static int getRandomXY()
    {
        return (int)(random.Next(0, 100));
    }
    private static void Main(string[] args)
    {
        for (int i = 0; i < 20; ++i)
        {
            Circle circle = (Circle)ShapeFactory.GetCircle(getRandomColor());
            circle.SetX(getRandomXY());
            circle.SetY(getRandomXY());
            circle.SetRadius(100);
            circle.Draw();
        }
        Console.ReadLine();
    }
}